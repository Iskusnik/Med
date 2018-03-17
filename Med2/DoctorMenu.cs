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

        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regDocForm = new RegDocForm();
            regDocForm.Owner = this;
            regDocForm.ShowDialog();
        }
    }
}
