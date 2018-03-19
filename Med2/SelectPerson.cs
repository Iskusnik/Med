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
    public partial class SelectPerson : Form
    {
        public SelectPerson()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string name = textBoxName.Text;
                DateTime date = dateTimePicker1.Value.Date;
                List<Person> searchResult = db.PersonSet.ToList();

                try
                {
                    if (checkBoxName.Checked)
                        searchResult = (from d in searchResult where (d.FullName == name) select d).ToList();
                    if (checkBoxBirth.Checked)
                        searchResult = (from d in searchResult where (d.BirthDate == date) select d).ToList();
                    if (checkBoxDocs.Checked)
                        searchResult = (from d in searchResult where (d is Doctor) select d).ToList();
                    if (checkBoxPat.Checked)
                        searchResult = (from d in searchResult where (d is Patient) select d).ToList();

                    foreach (Person per in searchResult)
                        comboBox1.Items.Add(per.FullName + " " + per.BirthDate);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Искомые люди не обнаружены");
                }
            }
        }

        private void buttonSelectPerson_Click(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string[] personInfo = comboBox1.Text.Split('_');
                string[] birthInfo = personInfo[1].Split('.');
                long hash = (long)personInfo[0].GetHashCode();
                DateTime birth = new DateTime(int.Parse(birthInfo[2]), int.Parse(birthInfo[1]), int.Parse(birthInfo[0]));
                Person pers = db.PersonSet.Find(birth, hash);
                Form changeInfo = new ChangePersonInfo(pers);
                changeInfo.Owner = this;
                changeInfo.Show();
                this.Close();
            }
        }
    }
}
