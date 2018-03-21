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
        public Doctor thisDoctor;
        public DoctorMenu(Doctor doct)
        {
            thisDoctor = doct;
            InitializeComponent();
        }
        private void RefreshMenu()
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                thisDoctor = (Doctor)db.PersonSet.Find(thisDoctor.BirthDate, thisDoctor.NameHashID);

                this.Text = "Врач:" + thisDoctor.FullName;
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
                this.textBoxBirthPlace.Text = thisDoctor.BirthPlace;
                this.textBoxDocType.Text = thisDoctor.Documents.DocumentName;
                this.textDocumentN.Text = thisDoctor.Documents.DocumentNum.ToString();
            }

            //ClinicManageToolStripMenuItem.Enabled = thisDoctor.Job == "Главврач";
            ClinicManageToolStripMenuItem.Enabled = true;
        }
        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }
        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regDocForm = new RegDocForm();
            regDocForm.Owner = this;
            regDocForm.ShowDialog();
            RefreshMenu();
        }

        private void изменитьСписокСпециальностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vac = new ChangeVacancies();
            vac.Owner = this;
            vac.ShowDialog();
            RefreshMenu();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form del = new ChangeWorkTable(thisDoctor);
            del.Owner = this;
            del.ShowDialog();
            RefreshMenu();
        }

        

        private void изменитьРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form changeWork = new ChangeWorkTable(thisDoctor);
            changeWork.Show();
        }

        private void найтиЧеловекаИИзменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form selPer = new SelectPerson();
            selPer.Show();
            RefreshMenu();

        }

        private void открытьМедицинскуюКартуПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form selectPerson = new SelectPerson(1);
            selectPerson.Owner = this;
            selectPerson.ShowDialog();
        }

        private void просмотретьЗапланированныеПриёмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form docsVisits = new ShowDocsVisits(thisDoctor);
            docsVisits.Show();
        }

        private void статистикаОбращенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            string fileName;
            save.Filter = "Таблиа Excel|*.xlsx";
            save.ShowDialog();
            fileName = save.FileName;
            ControlFunctions.AnalyseVisits(fileName);
        }
    }
}
