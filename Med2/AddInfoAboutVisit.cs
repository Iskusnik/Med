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
    public partial class AddInfoAboutVisit : Form
    {
        Patient patient;
        Doctor doctor;
        DoctorRecord doctorRecord;
        public AddInfoAboutVisit(Patient pat, Doctor doct, DoctorRecord rec = null)
        {
            patient = pat;
            doctor = doct;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                patient = (Patient)db.PersonSet.Find(patient.BirthDate, patient.NameHashID);
                doctor = (Doctor)db.PersonSet.Find(doctor.BirthDate, doctor.NameHashID);
                if (doctorRecord == null)
                    patient.MedCard.DoctorRecord.Add(new DoctorRecord
                    {
                        Anamnesis = richTextBoxAnamnes.Text,
                        Diagnosis = richTextBoxDiagnos.Text,
                        Date = dateTimePicker1.Value,
                        HelpAmount = richTextBoxHelpAmount.Text,
                        HelpType = richTextBoxHelpType.Text,
                        Result = richTextBoxResult.Text,
                        DoctorInfo = doctor.FullName,
                        Doctor = doctor,
                        DoctorID = doctor.NameHashID,
                        Standarts = richTextBoxStand.Text
                    });
                else
                {
                    doctorRecord = db.DoctorRecordSet.Find(doctorRecord.DoctorID, doctorRecord.Date);
                    doctorRecord.Anamnesis = richTextBoxAnamnes.Text;
                    doctorRecord.Diagnosis = richTextBoxDiagnos.Text;
                    doctorRecord.Date = dateTimePicker1.Value;
                    doctorRecord.HelpAmount = richTextBoxHelpAmount.Text;
                    doctorRecord.HelpType = richTextBoxHelpType.Text;
                    doctorRecord.Result = richTextBoxResult.Text;
                    doctorRecord.DoctorInfo = doctor.FullName;
                    doctorRecord.Doctor = doctor;
                    doctorRecord.DoctorID = doctor.NameHashID;
                    doctorRecord.Standarts = richTextBoxStand.Text;
                }
                db.SaveChangesAsync();
            }
            this.Close();
        }

        private void AddInfoAboutVisit_Load(object sender, EventArgs e)
        {
            textBoxDoctor.Text = doctor.FullName;
            if (doctorRecord != null)
            {
                richTextBoxAnamnes.Text = doctorRecord.Anamnesis;
                richTextBoxDiagnos.Text = doctorRecord.Diagnosis;
                dateTimePicker1.Value = doctorRecord.Date;
                richTextBoxHelpAmount.Text = doctorRecord.HelpAmount;
                richTextBoxHelpType.Text = doctorRecord.HelpType;
                richTextBoxResult.Text = doctorRecord.Result;
                textBoxDoctor.Text = doctorRecord.DoctorInfo;
                richTextBoxStand.Text = doctorRecord.Standarts;
            }
        }
    }
}
