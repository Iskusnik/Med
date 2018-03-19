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
    public partial class PatientToDoctor : Form
    {

        Doctor[] DoctorsList;
        int index;
        public PatientToDoctor()
        {
            DoctorsList = null;
            InitializeComponent();
        }

        private void PatientToDoctor_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string[] distinct = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor as Doctor).Job).Distinct().ToArray();

                this.comboBoxJob.Items.Remove("Главврач");
                foreach (string job in distinct)
                    this.comboBoxJob.Items.Add(job);
            }
            if (comboBoxJob.Items.Count == 0)
            {
                MessageBox.Show("Врачей нет");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.Text == "")
                MessageBox.Show("Выберите специальность, врача, день и время");
            else
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    DoctorsList[index] = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].NameHashID);
                    FreeTime selectedTime = (FreeTime)(from times in DoctorsList[index].FreeTime where (times.Start.Date.ToShortDateString() == comboBoxDate.Text && times.Start.TimeOfDay.ToString() == comboBoxTime.Text) select (times));
                    DoctorsList[index].WorkTime.Add(new WorkTime{ Doctor = DoctorsList[index], Start = selectedTime.Start, Finish = selectedTime.Finish });
                    DoctorsList[index].FreeTime.Remove(selectedTime);
                    db.SaveChanges();
                }
        }

        private void comboBoxJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                object[] temp = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor)).ToArray();
                DoctorsList = (from doctor in temp where ((Doctor)doctor).Job == comboBoxJob.Text select (Doctor)doctor).ToArray();
                
            }
            foreach (Doctor doct in DoctorsList)
                this.comboBoxDoctor.Items.Add(doct.FullName);
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBoxDoctor.SelectedIndex;
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                try
                {
                    Doctor d = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].GetHashCode());

                    string[] distinct = (from dates in d.FreeTime select dates.Start.ToShortDateString()).Distinct().ToArray();

                    foreach (string doct in distinct)
                        this.comboBoxDate.Items.Add(doct);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("На данный момент нет времени для записи к этому врачу");
                }
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Doctor d = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].FullName);
                string[] distinct = (from dates in d.FreeTime where (dates.Start.ToShortDateString() == comboBoxDate.Text) select (dates.Start.TimeOfDay.ToString())).ToArray();

                foreach (string doct in distinct)
                    this.comboBoxDate.Items.Add(doct);
            }
        }
    }
}