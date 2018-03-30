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
                var thisPersonVisits = (from visit in thisPatient.MedCard.DoctorRecord  select new { Время_начала_приёма = visit.Date, Имя_врача = visit.Doctor.FullName}).ToList();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                dataGridView1.Columns.Add("Имя врача", "Имя врача");
                foreach (var s in thisPersonVisits)
                    dataGridView1.Rows.Add(s.Время_начала_приёма, s.Имя_врача);

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Refresh();
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null && dataGridView1.SelectedCells.Count != 0)
            {
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                    var info = new { dateSt = dataGridView1.SelectedCells[0].Value, name = dataGridView1.SelectedCells[1].Value };
                    long hash = (info.name as string).GetHashCode();
                    DateTime dt = (DateTime)(info.dateSt);
                    DoctorRecord temp = db.DoctorRecordSet.Find(info.dateSt, hash);
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
