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
    public partial class DoctorMenu : Form
    {
        Doctor thisDoctor;
        public DoctorMenu(Doctor doct)
        {
            thisDoctor = doct;
            InitializeComponent();
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisDoctor = (Doctor)db.PersonSet.Find(thisDoctor.BirthDate, thisDoctor.NameHashID);

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

            ClinicManageToolStripMenuItem.Enabled = thisDoctor.Job == "Главврач";
        }
        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regDocForm = new RegDocForm();
            regDocForm.Owner = this;
            regDocForm.ShowDialog();
        }

        private void изменитьСписокСпециальностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vac = new ChangeVacancies();
            vac.Owner = this;
            vac.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form del = new DeleteDoctor();
            del.Owner = this;
            del.ShowDialog();
        }

        

        private void изменитьРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиЧеловекаИИзменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
