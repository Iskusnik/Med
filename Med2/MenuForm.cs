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
            ControlFunctions.AnalyseVisits("11111");
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
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
                    newDoctor.BirthPlace = "Администратор";

                    newDoctor.Documents = new Documents { DocumentName = "Паспорт", DocumentNum = -1, Person = newDoctor };
                    newDoctor.WorkTimes = new List<WorkTime>();
                    newDoctor.FreeTimes = new List<FreeTime>();
                    newDoctor.DoctorRecord = new List<DoctorRecord>();
                    newDoctor.Password = "123qwe";
                    newDoctor.NameHashID = newDoctor.FullName.GetHashCode();

                    db.PersonSet.Add(newDoctor);
                    db.SaveChanges();
                }
            }
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                int patientCount = (from patient in db.PersonSet where (patient is Patient && patient.FullName == "Пациент") select (patient as Patient)).Count();
                if (patientCount == 0)
                {
                    Patient newPatient = new Patient();
                    newPatient.FullName = "Пациент";
                    newPatient.Gender = "Пациент";
                    newPatient.BirthDate = new DateTime(2000, 1, 1);
                    newPatient.Nationality = "Пациент";
                    newPatient.LiveAdress = "Пациент";
                    newPatient.RegAdress = "Пациент";
                    newPatient.RegDate = new DateTime(2000, 1, 1);
                    newPatient.InsuranceBillNum = "Пациент";
                    newPatient.BloodType = 255;
                    newPatient.Rhesus = "Пациент";
                    newPatient.WorkIncapacityListNum = "Пациент";
                    newPatient.InsurancePolicyNum = "Пациент";
                    newPatient.BirthPlace = "Пациент";


                    newPatient.Password = "1";

                    newPatient.Documents = new Documents { DocumentName = "Паспорт", DocumentNum = -2, Person = newPatient };
                    newPatient.MedCard = new MedCard();
                    Illness ill = new Illness { Name = "Пациент" };
                    ill.Hash = ill.Name.GetHashCode();
                    if (db.IllnessSet.Find(ill.Hash) != null)
                        ill = db.IllnessSet.Find(ill.Hash);
                    ill.Patient.Add(newPatient);
                    newPatient.Illness.Add(ill);

                    newPatient.NameHashID = newPatient.FullName.GetHashCode();

                    db.PersonSet.Add(newPatient);
                    //db.IllnessSet.Add(newPatient.Illness.First());
                    //db.IllnessSet.Find(newPatient.Illness.First().Hash).Patient.Add(newPatient);
                    //newPatient.Illness.Add(new Illness { Cured = true, Name = "Пациент", Hash = Name.GetHashCode()});

                    db.SaveChanges();}}
        
                    
                    //ControlFunctions.GenerateRandomDataBase();
            
        }
    }
}
