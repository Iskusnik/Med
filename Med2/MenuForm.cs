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
            }   
            else
            {
                DoctorMenu patientMenu = new DoctorMenu((Doctor)pers);
                patientMenu.ShowDialog();
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            
            Form regForm = new RegForm();
            regForm.Owner = this;
            regForm.ShowDialog();
        }
    }
}
