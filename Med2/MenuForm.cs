using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Med2
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            //finallyWorkingDBDataSet1.PersonSet.AddPersonSetRow()
            string mes;
            Person pers;
            if (!ControlFunctions.LoginPasswordCheck(this.loginTextBox.Text, this.passwordTextBox.Text, out mes, out pers))
                MessageBox.Show(mes);
            else
                if (pers is Patient)
            {
                PatientMenu patientMenu = new PatientMenu((Patient)pers);
                patientMenu.ShowDialog();
                //Thread myThread = new Thread(patientMenu.Show);
                //myThread.IsBackground = false;
                //myThread.Start();
            }
            else
            {
                DoctorMenu doctorMenu = new DoctorMenu((Doctor)pers);
                doctorMenu.ShowDialog();
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Form regForm = new RegPatForm();
            regForm.Owner = this;
            regForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                ControlFunctions.ClearDataBase();
                int doctorsCount = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor as Doctor)).Count();
                if (doctorsCount == 0)
                {
                    Doctor newDoctor = new Doctor();
                    newDoctor.FullName = "Администратор";
                    newDoctor.Gender = "Администратор";
                    newDoctor.BirthDate = new DateTime(2000, 1, 1);
                    newDoctor.Nationality = "Администратор";
                    newDoctor.LiveAdress = "Администратор";
                    newDoctor.RegAdress = "Администратор";
                    newDoctor.RegDate = new DateTime(2000, 1, 1); ;
                    newDoctor.InsuranceBillNum = "Администратор";
                    newDoctor.Education = "Администратор";
                    newDoctor.Job = "Главврач";
                    newDoctor.Memberships = "Администратор";

                    newDoctor.Documents = new Documents { DocumentName = "Паспорт", DocumentNum = 1, Person = newDoctor };
                    newDoctor.WorkTime = new List<WorkTime>();
                    newDoctor.FreeTime = new List<FreeTime>();
                    newDoctor.DoctorRecord = new List<DoctorRecord>();
                    newDoctor.Password = "123qwe";
                    newDoctor.NameHashID = newDoctor.FullName.GetHashCode();

                    db.PersonSet.Add(newDoctor);
                    db.SaveChanges();
                }
                ControlFunctions.GenerateRandomDataBase();
            }
        }
    }
}
