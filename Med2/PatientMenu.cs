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
   
                
                
    public partial class PatientMenu : Form
    {
         
        Patient thisPatient;

        public PatientMenu(Patient pers)
        {
            thisPatient = pers;
            InitializeComponent();
        }
        private void RefreshMenu()
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisPatient = (Patient)db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID);

                this.Text = "Пациент:" + thisPatient.FullName;
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
                this.textBoxBirthPlace.Text = thisPatient.BirthPlace;

                this.textBoxDocType.Text = thisPatient.Documents.DocumentName;
                this.textDocumentN.Text = thisPatient.Documents.DocumentNum.ToString();
            }
        }
        private void PatientMenu_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form changeInfo = new ChangePersonInfo(thisPatient);
            changeInfo.Owner = this;
            changeInfo.ShowDialog();
            RefreshMenu();
        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form record = new PatientToDoctor(thisPatient);
            record.Show();
        }

        private void просмотретьИсториюБолезнейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showIll = new Showillnesses (thisPatient);
            showIll.Show();
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void просмотретьИсториюЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showVisits = new ShowVisits(thisPatient);
            showVisits.Show();
        }

        private void записиВрачейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showVisits = new ShowVisitRecords(thisPatient);
            showVisits.Show();
        }

        private void редактироватьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
