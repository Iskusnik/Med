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
        Doctor[] docs;
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
                    if (MessageBox.Show("Изменение расписания приведёт к удалению всех грядущих приёмов пациентов для этого врача. Продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        long nameID = docs[comboBox1.SelectedIndex].NameHashID;
                        DateTime date = docs[comboBox1.SelectedIndex].BirthDate;
                        Doctor t = (Doctor)db.PersonSet.Find(date, nameID);
                        db.FreeTimeSet.RemoveRange(t.FreeTimes);
                        t.FreeTimes.Clear();
                        bool[] weekCheck = { checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked };
                        t.FreeTimes = ControlFunctions.makeJob(weekCheck, dateTimePicker1.Value, t, (int)numericUpDownPeriod.Value, (int)numericUpDownHours.Value, (int)numericUpDownDays.Value);
                        var workTime = (from workT in db.WorkTimeSet where (workT.Doctor == t && workT.Start > DateTime.Today) select workT).ToList();
                        db.WorkTimeSet.RemoveRange(workTime);
                        db.SaveChanges();
                    }
                }
            else
                MessageBox.Show("Удалять некого");
        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Head = (Doctor)db.PersonSet.Find(Head.BirthDate, Head.NameHashID);
                var temp = (from docs in db.PersonSet  where (docs is Doctor && docs.NameHashID != Head.NameHashID && docs.BirthDate != Head.BirthDate) select docs).ToList();
                List<Person> doctors = (List<Person>)temp;
                docs = new Doctor[doctors.Count];
                for (int i = 0; i < doctors.Count; i++)
                    docs[i] = (Doctor)doctors[i];

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
