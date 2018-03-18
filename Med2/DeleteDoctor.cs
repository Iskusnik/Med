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
    public partial class DeleteDoctor : Form
    {
        public DeleteDoctor()
        {
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox1.Text != "")
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    string name = comboBox1.Text.Split('_')[0];
                    string[] date = (comboBox1.Text.Split('_')[1]).Split('/');
                    DateTime birth = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
                    db.PersonSet.Remove(db.PersonSet.Find(birth, (long)name.GetHashCode()));
                }
            else
                MessageBox.Show("Удалять некого");
        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                var temp = (from docs in db.PersonSet where (docs is Doctor) select (Doctor)docs).ToList();
                List<Doctor> doctors = (List<Doctor>)temp;
                foreach (Doctor d in doctors)
                    comboBox1.Items.Add(d.FullName + "_" + d.BirthDate.ToShortDateString());

            }
        }
    }
}
