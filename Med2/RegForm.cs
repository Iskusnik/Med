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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedItem = comboBoxGender.Items[0];
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            ControlFunctions.RegistrationCall(this);
        }
    }
}
