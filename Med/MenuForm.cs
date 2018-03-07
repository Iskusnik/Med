using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            if(!ControlFunctions.LoginPasswordCheck("1","1"))
                MessageBox.Show("Заполните поля");
        }
    }
}
