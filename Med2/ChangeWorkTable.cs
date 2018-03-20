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
    public partial class ChangeWorkTable : Form
    {
        Doctor Head;
        public ChangeWorkTable(Doctor head)
        {
            Head = head;
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox1.Text != "")
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Head = (Doctor)db.PersonSet.Find(Head.BirthDate, Head.NameHashID);
                    
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
                {
                    MessageBox.Show("Врачей нет");
                }
            }
            
        }
        
    }
}
