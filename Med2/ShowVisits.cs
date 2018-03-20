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
    public partial class ShowVisits : Form
    {
        Patient thisPatient;
        public ShowVisits(Patient pat)
        {
            thisPatient = pat;
            InitializeComponent();
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
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo select new { visit.DateStart, visit.WorkTimes.Doctor.FullName }).ToList();

                            dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                            dataGridView1.Columns.Add("Имя врача", "Имя врача");
                            foreach (var s in thisPersonVisits)
                                dataGridView1.Rows.Add(s.DateStart.ToString(), s.FullName);

                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Refresh();
                            break;
                        }
                    case 1:
                        {
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo where (visit.DateStart > DateTime.Today) select new { visit.DateStart, visit.WorkTimes.Doctor.FullName }).ToList();

                            dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                            dataGridView1.Columns.Add("Имя врача", "Имя врача");
                            foreach (var s in thisPersonVisits)
                                dataGridView1.Rows.Add(s.DateStart.ToString(), s.FullName);

                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Refresh();
                            break;
                        }
                    case 2:
                        {
                            var thisPersonVisits = (from visit in thisPatient.VisitInfo where (visit.DateStart <= DateTime.Today) select new { visit.DateStart, visit.WorkTimes.Doctor.FullName }).ToList();

                            dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                            dataGridView1.Columns.Add("Имя врача", "Имя врача");
                            foreach (var s in thisPersonVisits)
                                dataGridView1.Rows.Add(s.DateStart.ToString(), s.FullName);

                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.Refresh();
                            break;
                        }
                }
                dataGridView1.Columns[0].Name = "Начало приёма";
                dataGridView1.Columns[0].Name = "Конец приёма";
                dataGridView1.Columns[0].Name = "Имя врача";
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowVisits_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                var thisPersonVisits = (from visit in thisPatient.VisitInfo select new { visit.DateStart, visit.WorkTimes.Doctor.FullName }).ToList();

                dataGridView1.Columns.Add("Время начала приёма", "Время начала приёма");
                dataGridView1.Columns.Add("Имя врача", "Имя врача");
                foreach (var s in thisPersonVisits)
                    dataGridView1.Rows.Add(s.DateStart.ToString(), s.FullName);

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Refresh();
                dataGridView1.DataSource = thisPersonVisits;
                dataGridView1.Refresh();
            }
        }
    }
}
