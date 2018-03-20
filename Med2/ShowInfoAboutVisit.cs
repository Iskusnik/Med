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
    public partial class ShowInfoAboutVisit : Form
    {
        DoctorRecord thisRecord;
        public ShowInfoAboutVisit(DoctorRecord r)
        {
            thisRecord = r;
            InitializeComponent();
        }

        private void ShowInfoAboutVisit_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = thisRecord.Date.ToString();
            textBoxDoctor.Text = thisRecord.DoctorInfo;
            richTextBoxAnamnes.Text = thisRecord.Anamnesis;
            richTextBoxDiagnos.Text = thisRecord.Diagnosis;
            richTextBoxHelpType.Text = thisRecord.HelpType;
            richTextBoxHelpAmount.Text = thisRecord.HelpAmount;
            richTextBoxResult.Text = thisRecord.Result;
            richTextBoxStand.Text = thisRecord.Standarts;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
