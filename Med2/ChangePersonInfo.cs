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
    public partial class ChangePersonInfo : Form
    {
        Person person;
        public ChangePersonInfo(Person Info)
        {
            person = Info;
            InitializeComponent();
        }

        private void ChangePersonInfo_Load(object sender, EventArgs e)
        {
            this.Text += " " + person.FullName;
            if (person is Doctor)
            {
                this.textInsurancePolicyNum.Hide();
                this.textBoxWorkIncapacity.Hide();
                this.textBoxBloodType.Hide();
                this.textBoxJob.Show();
                this.textInsuranceMemberships.Show();
                this.textBoxEducation.Show();
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Doctor thisDoctor = (Doctor)db.PersonSet.Find(person.BirthDate, person.NameHashID);

                    this.Text += thisDoctor.FullName;
                    this.textBoxName.Text = thisDoctor.FullName;
                    this.textBoxGender.Text = thisDoctor.Gender;
                    this.textBoxBirthDate.Text = thisDoctor.BirthDate.Date.ToShortDateString();
                    this.textNation.Text = thisDoctor.Nationality;
                    this.textLiveAdress.Text = thisDoctor.LiveAdress;
                    this.textRegAdress.Text = thisDoctor.RegAdress;
                    this.textBoxRegDate.Text = thisDoctor.RegDate.Date.ToShortDateString();
                    this.textBoxInsuranceBillNum.Text = thisDoctor.InsuranceBillNum;
                    this.textBoxEducation.Text = thisDoctor.Education;
                    this.textBoxJob.Text = thisDoctor.Job;
                    this.textInsuranceMemberships.Text = thisDoctor.Memberships;

                    this.textBoxDocType.Text = thisDoctor.Documents.DocumentName;
                    this.textDocumentN.Text = thisDoctor.Documents.DocumentNum.ToString();
                }

            }
            else
            {
                if (this.Owner is DoctorMenu)
                    textBoxBloodType.ReadOnly = false;
                else
                    textBoxBloodType.ReadOnly = true;

                this.textInsurancePolicyNum.Show();
                this.textBoxWorkIncapacity.Show();
                this.textBoxBloodType.Show();
                this.textBoxJob.Hide();
                this.textInsuranceMemberships.Hide();
                this.textBoxEducation.Hide();


                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Patient thisPatient = (Patient)db.PersonSet.Find(person.BirthDate, person.NameHashID);

                    this.Text += thisPatient.FullName;
                    this.textBoxName.Text = thisPatient.FullName;
                    this.textBoxGender.Text = thisPatient.Gender;
                    this.textBoxBirthDate.Text = thisPatient.BirthDate.Date.ToShortDateString();
                    this.textNation.Text = thisPatient.Nationality;
                    this.textLiveAdress.Text = thisPatient.LiveAdress;
                    this.textRegAdress.Text = thisPatient.RegAdress;
                    this.textBoxRegDate.Text = thisPatient.RegDate.Date.ToShortDateString();
                    this.textBoxInsuranceBillNum.Text = thisPatient.InsuranceBillNum;
                    this.textInsurancePolicyNum.Text = thisPatient.InsurancePolicyNum;
                    this.textBoxWorkIncapacity.Text = thisPatient.WorkIncapacityListNum;
                    this.textBoxBloodType.Text = thisPatient.Rhesus + thisPatient.BloodType.ToString();


                    this.textBoxDocType.Text = thisPatient.Documents.DocumentName;
                    this.textDocumentN.Text = thisPatient.Documents.DocumentNum.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Person info = db.PersonSet.Find(person.BirthDate, person.NameHashID);
                info.LiveAdress = textLiveAdress.Text;
                info.Nationality = textNation.Text;
                info.InsuranceBillNum = textBoxInsuranceBillNum.Text;

                if (info is Patient)
                {
                    
                    if (textBoxBloodType.Text != "Неизвестно0")
                    {
                        if (textBoxBloodType.Text[0] == '-')
                        {
                            (info as Patient).Rhesus = "-";
                            (info as Patient).BloodType -= byte.Parse(textBoxBloodType.Text);
                        }
                        else
                        {
                            (info as Patient).Rhesus = "+";
                            (info as Patient).BloodType = byte.Parse(textBoxBloodType.Text);
                        }
                    }
                    (info as Patient).WorkIncapacityListNum = textBoxWorkIncapacity.Text;
                    (info as Patient).InsurancePolicyNum = textInsurancePolicyNum.Text;
                    
                }
                else
                {
                    (info as Doctor).Memberships = textInsuranceMemberships.Text;
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
