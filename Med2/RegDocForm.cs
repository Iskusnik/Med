using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Med2
{
    public partial class RegDocForm : Form
    {
        public RegDocForm()
        {
            InitializeComponent();
        }

        private void RegDocForm_Load(object sender, EventArgs e)
        {
            //собриаем все возможные значения профессий
            try
            {
                string[] jobs = File.ReadAllLines(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");//"Работы.txt");
                if (!(jobs == null || jobs.Length == 0))
                    foreach (string job in jobs)
                        this.comboBoxJob.Items.Add(job);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("На данный момент вакансий нет. Главврач должен создать вакансии");
                this.Close();
            }
            /*using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string[] distinct = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor as Doctor).Job).Distinct().ToArray();

                this.comboBoxJob.Items.Add("Главврач");
                foreach (string job in distinct)
                    this.comboBoxJob.Items.Add(job);
            }*/
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string log, pas;
            if (ControlFunctions.DoctorRegistrationCall(this, out log, out pas))
            {
                MessageBox.Show("Регистрация успешно завершена. \n Логин: " + log + "\n Пароль: " + pas);
                this.Close();
            }
            else
            {
                MessageBox.Show("Регистрация не завершена. Исправьте указанные ошибки");
            }
        }

        private void textBoxBirthPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
