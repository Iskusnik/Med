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
    public partial class ShowVisitRecords : Form
    {
        Patient thisPatient;
        public ShowVisitRecords(Patient pat)
        {
            thisPatient = pat;
            InitializeComponent();
        }

        private void ShowVisitRecords_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newMedDBDataSet.VisitInfoSet". При необходимости она может быть перемещена или удалена.
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                var thisPersonVisits = (from visit in thisPatient.VisitInfo select new { visit.DateStart, visit.DateFinish, visit.WorkTime.Doctor.FullName }).ToList();
                //this.visitInfoSetTableAdapter.Fill(thisPersonVisits);
                dataGridView1.DataSource = thisPersonVisits;
                dataGridView1.Refresh();
            }
            //var thisPersonVisits = from visit in thisPatient.VisitInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo select new { visit.DateStart, visit.DateFinish, visit.WorkTime.Doctor.FullName }).ToList();
                            dataGridView1.DataSource = thisPersonVisits;
                            break;
                        }
                    case 1:
                        {
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo where (visit.DateStart > DateTime.Today) select new { visit.DateStart, visit.DateFinish, visit.WorkTime.Doctor.FullName }).ToList();
                            dataGridView1.DataSource = thisPersonVisits;
                            break;
                        }
                    case 2:
                        {
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo where (visit.DateStart < DateTime.Today) select new { visit.DateStart, visit.DateFinish, visit.WorkTime.Doctor.FullName }).ToList();
                            dataGridView1.DataSource = thisPersonVisits;
                            break;
                        }
                }
                dataGridView1.Columns[0].Name = "Начало приёма";
                dataGridView1.Columns[0].Name = "Конец приёма";
                dataGridView1.Columns[0].Name = "Имя врача";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null || dataGridView1.SelectedCells.Count == 0)
            {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                    var info = new { dateSt = dataGridView1.SelectedRows[0], dateFn = dataGridView1.SelectedCells[1], s = dataGridView1.SelectedCells[2] };
                    VisitInfo vInfo = db.VisitInfoSet.Find(info.dateSt, info.dateFn, info.s);
                    var dR = (from dRecs in vInfo.Patient.MedCard.DoctorRecord where (dRecs.DoctorID == vInfo.DoctorID && dRecs.Date == vInfo.DateStart) select dRecs).ToList();
                    DoctorRecord temp = dR[0];
                    Form showInfoAboutVisit = new ShowInfoAboutVisit(temp);
                    showInfoAboutVisit.Show();
                }
            }
        }
    }
}
