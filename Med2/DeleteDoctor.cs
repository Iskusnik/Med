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
        Doctor Head;
        public DeleteDoctor(Doctor head)
        {
            Head = head;
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox1.Text != "")
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    string name = comboBox1.Text.Split('_')[0];
                    string[] date = (comboBox1.Text.Split('_')[1]).Split('.');
                    DateTime birth = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                    db.DocumentsSet.Remove(db.PersonSet.Find(birth, (long)name.GetHashCode()).Documents);
                    db.PersonSet.Remove(db.PersonSet.Find(birth, (long)name.GetHashCode()));
                    db.SaveChanges();
                    this.Close();
                }
            else
                MessageBox.Show("Удалять некого");
        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Head = (Doctor)db.PersonSet.Find(Head.BirthDate, Head.NameHashID);
                var temp = (from docs in db.PersonSet where (docs is Doctor && docs.NameHashID != Head.NameHashID && docs.BirthDate != Head.BirthDate) select docs).ToList();
                List<Person> doctors = (List<Person>)temp;
                if (doctors != null)
                foreach (Doctor d in doctors)
                    comboBox1.Items.Add(d.FullName + "_" + d.BirthDate.ToShortDateString());
                else
                    MessageBox.Show("Удалять некого");
            }
            
        }
        
    }
}
