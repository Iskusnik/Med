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
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                var thisPersonVisits = (from visit in thisPatient.MedCard.DoctorRecord select new { visit.Date, visit.Doctor.FullName}).ToList();
                
                dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                dataGridView1.Columns.Add("Имя врача", "Имя врача");
                foreach (var s in thisPersonVisits)
                    dataGridView1.Rows.Add(s.Date.ToString(), s.FullName);

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Refresh();
                dataGridView1.DataSource = thisPersonVisits;
                dataGridView1.Refresh();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
