using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med2
{
    public partial class Showillnesses : Form
    {
        Patient thisPatient;
        public Showillnesses(Patient pers)
        {
            thisPatient = pers;
            InitializeComponent();
        }

        private void Showillnesses_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);
                var IllNames = (from n in thisPatient.Illness.AsParallel() select n.Name).ToList();
                dataGridView1.Columns.Add("Название болезни", "Название болезни");
                foreach (string s in IllNames)
                    dataGridView1.Rows.Add(s);
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Refresh();
            }
        }
    }
}
