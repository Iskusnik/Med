﻿using System;
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
    public partial class ShowPatientInfo : Form
    {
        Patient thisPatient;
        public ShowPatientInfo(Patient p)
        {
            thisPatient = p;
            InitializeComponent();
        }

        private void ShowPatientInfo_Load(object sender, EventArgs e)
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
    }
}
