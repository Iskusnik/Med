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
    public partial class RegPatForm : Form
    {
        public RegPatForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedItem = comboBoxGender.Items[0];
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string log, pas;
            if(ControlFunctions.PatientRegistrationCall(this, out log, out pas))
            {
                MessageBox.Show("Регистрация успешно завершена. \n Логин: " + log + "\n Пароль: " + pas);
                this.Close();
            }
            else
            {
                MessageBox.Show("Регистрация не завершена. Исправьте указанные ошибки");
            }
        }
    }
}
