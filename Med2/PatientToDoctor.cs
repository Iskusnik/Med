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
    public partial class PatientToDoctor : Form
    {

        Doctor[] DoctorsList;
        int index;
        Patient thisPatient;

        public PatientToDoctor(Patient pers)
        {
            DoctorsList = null;
            thisPatient = pers;
            InitializeComponent();
        }

        private void PatientToDoctor_Load(object sender, EventArgs e)
        {
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                string[] distinct = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor as Doctor).Job).Distinct().ToArray();

                this.comboBoxJob.Items.Remove("Главврач");
                foreach (string job in distinct)
                    this.comboBoxJob.Items.Add(job);
            }
            if (comboBoxJob.Items.Count == 0)
            {
                MessageBox.Show("Врачей нет");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.Text == "")
                MessageBox.Show("Выберите специальность, врача, день и время");
            else
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    Doctor tempDoctor = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].NameHashID);


                    FreeTime freeTi = (FreeTime)(from times in tempDoctor.FreeTimes
                                                                         where (times.Start.Date.ToShortDateString() == comboBoxDate.Text
                                                                              && times.Start.TimeOfDay.ToString() == comboBoxTime.Text)
                                                                         select (times)).ToArray()[0]; ;

                    comboBoxTime.Items.Remove(comboBoxTime.Text);
                    WorkTime workTi = new WorkTime { Start = freeTi.Start, Doctor = tempDoctor, Finish = freeTi.Finish, BirthDate = tempDoctor.BirthDate, NameHashID = tempDoctor.NameHashID };

                    db.FreeTimeSet.Remove(freeTi);
                    Patient t = (Patient)(db.PersonSet.Find(thisPatient.BirthDate, thisPatient.NameHashID));
                    workTi.VisitInfo = new VisitInfo
                    {
                        WorkTimes = workTi,
                        DateStart = workTi.Start,
                        DateFinish = workTi.Finish,
                        DoctorID = tempDoctor.NameHashID,
                        Patient = t,
                        PatientBirthDate = t.BirthDate,
                        PatientFullName = t.FullName
                    };
                    t.VisitInfo.Add(workTi.VisitInfo);
                    tempDoctor.WorkTimes.Add(workTi);
                    db.WorkTimeSet.Add(workTi);
                    db.VisitInfoSet.Add(workTi.VisitInfo);




                    db.SaveChanges();
                    MessageBox.Show("Запись совершена");
                    button1.Enabled = false;
                }
        }

        private void comboBoxJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.comboBoxDoctor.Items.Clear();
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                
                object[] temp = (from doctor in db.PersonSet where (doctor is Doctor) select (doctor)).ToArray();
                string s = comboBoxJob.Text;
                DoctorsList = (from doctor in temp  where ((Doctor)doctor).Job == s select (Doctor)doctor).ToArray();
                
            }
            foreach (Doctor doct in DoctorsList)
                this.comboBoxDoctor.Items.Add(doct.FullName);
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoctor.SelectedIndex != -1)
            {
                button1.Enabled = false;
                this.comboBoxDate.Items.Clear();

                index = comboBoxDoctor.SelectedIndex;
                using (ModelMedDBContainer db = new ModelMedDBContainer())
                {
                    try
                    {
                        Doctor d = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].NameHashID);

                        string[] distinct = (from dates in d.FreeTimes select dates.Start.ToShortDateString()).Distinct().ToArray();

                        foreach (string doct in distinct)
                            this.comboBoxDate.Items.Add(doct);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("На данный момент нет времени для записи к этому врачу");
                    }
                }
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.comboBoxTime.Items.Clear();
            using (ModelMedDBContainer db = new ModelMedDBContainer())
            {
                Doctor d = (Doctor)db.PersonSet.Find(DoctorsList[index].BirthDate, DoctorsList[index].NameHashID);
                string s = comboBoxDate.Text;
                string[] distinct = (from dates in d.FreeTimes where (dates.Start.ToShortDateString() == s) select (dates.Start.TimeOfDay.ToString())).ToArray();

                foreach (string doct in distinct)
                    this.comboBoxTime.Items.Add(doct);
            }
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTime.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}