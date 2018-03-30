using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med2
{
    public partial class ChangeMedCard : Form
    {
        Doctor thisDoctor;
        Patient thisPatient;
        public ChangeMedCard(Doctor d, Patient p)
        {
            InitializeComponent();
            thisDoctor = d;
            thisPatient = p;
            Form showPatientInfo = new ShowPatientInfo(thisPatient);
            showPatientInfo.Show();
            this.Text = "Медицинская карта:" + thisPatient.FullName;
        }

        private void ChangeMedCard_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }
        private void ReloadForm()
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                comboBox1.Items.Clear();
                dataGridViewDocRecs.Columns.Clear();
                dataGWIllness.Columns.Clear();
                dataGWVisitInfo.Columns.Clear();

                var illnesses = (from ill in db.IllnessSet  select ill.Name).Distinct().ToList();
                foreach (string ill in illnesses)
                    comboBox1.Items.Add(ill);

                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);

                illnesses = null;
                illnesses = (from ill in thisPatient.Illness  select ill.Name).ToList();
                if (illnesses != null)
                {
                    thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                    var IllNames = (from n in thisPatient.Illness  select n.Name).ToList();
                    dataGWIllness.Columns.Add("Название болезни", "Название болезни");
                    foreach (string s in IllNames)
                        dataGWIllness.Rows.Add(s);
                    dataGWIllness.RowHeadersVisible = false;
                    dataGWIllness.Refresh();
                    /////////
                }


                var visitInfo = (from visits in thisPatient.VisitInfo
                                 where (visits.DateStart < DateTime.Today)
                                 select visits.DateStart).ToList();
                dataGWVisitInfo.Columns.Clear();
                dataGWVisitInfo.Columns.Add("Время приёма", "Время приёма");
                foreach (DateTime s in visitInfo)
                    dataGWVisitInfo.Rows.Add(s.ToString());
                dataGWVisitInfo.RowHeadersVisible = false;
                dataGWVisitInfo.Refresh();


                var doctorRecords = (from recs in thisPatient.MedCard.DoctorRecord select recs).ToList();
                dataGridViewDocRecs.Columns.Clear();
                dataGridViewDocRecs.Columns.Add("Время оказания помощи", "Время оказания помощи");
                dataGridViewDocRecs.Columns.Add("Доктор", "Доктор");
                dataGridViewDocRecs.Columns.Add("Диагноз", "Диагноз");
                dataGridViewDocRecs.Columns.Add("Результат", "Результат");

                foreach (var s in doctorRecords)
                    dataGridViewDocRecs.Rows.Add(s.Date, s.Doctor.FullName, s.Diagnosis, s.Result);

                dataGridViewDocRecs.RowHeadersVisible = false;
                dataGridViewDocRecs.Refresh();
            }
        }
        private void buttonAddIllness_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Illness temp = new Illness { Name = comboBox1.Text, Hash = comboBox1.Text.GetHashCode() };
                    thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                    if (!db.IllnessSet.Find(temp.Hash).Patient.Contains(thisPatient))
                    {
                        if (db.IllnessSet.Find(comboBox1.Text.GetHashCode()) != null)
                            thisPatient.Illness.Add(db.IllnessSet.Find(comboBox1.Text.GetHashCode()));
                        else
                        {
                            temp.Patient.Add(thisPatient);
                            db.IllnessSet.Add(temp);
                        }
                        db.SaveChanges();
                        dataGWIllness.Rows.Add(comboBox1.Text);
                        if(!comboBox1.Items.Contains(comboBox1.Text))
                            comboBox1.Items.Add(comboBox1.Text);
                    }
                    else
                        MessageBox.Show("Данная болезнь уже есть у данного человека");
                }
            }
            else
                MessageBox.Show("Выберите болезнь из известных или добавьте новую");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newDocRec = new AddInfoAboutVisit(thisPatient, thisDoctor);
            newDocRec.ShowDialog();
            ReloadForm();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocRecs.SelectedCells[0] != null && dataGridViewDocRecs.SelectedCells[0].ToString() != "")
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    DoctorRecord dr = db.DoctorRecordSet.Find(dataGridViewDocRecs.SelectedRows[0].Cells[0].Value, thisDoctor.NameHashID);
                    Form newDocRec = new AddInfoAboutVisit(thisPatient, thisDoctor, dr);
                    newDocRec.ShowDialog();
                }
            ReloadForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                Illness temp;
                
                    if (dataGWIllness.SelectedCells[0].Value != null && dataGWIllness.SelectedCells[0].Value.ToString() != "")
                    {
                        string s = dataGWIllness.SelectedCells[0].Value.ToString();
                        temp = db.IllnessSet.Find(s.GetHashCode());

                        thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);

                        temp.Patient.Remove(thisPatient);
                        thisPatient.Illness.Remove(temp);
                        db.SaveChanges();
                        dataGWIllness.Rows.Remove(dataGWIllness.Rows[dataGWIllness.SelectedCells[0].RowIndex]);
                    }
                }
            ReloadForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGWIllness.SelectedCells[0].Value != null && dataGWIllness.SelectedCells[0].Value.ToString() != "")
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    DoctorRecord dr = db.DoctorRecordSet.Find(dataGridViewDocRecs.SelectedRows[0].Cells[0].Value, thisDoctor.NameHashID);


                    Form showInfo = new ShowInfoAboutVisit(dr);
                    showInfo.Show();
                }
        }
    }
}
