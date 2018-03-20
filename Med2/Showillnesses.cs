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
    public partial class Showillnesses : Form
    {
        Patient thisPatient;
        public Showillnesses(Patient pers)
        {
            thisPatient = pers;
            InitializeComponent();
        }

        private void Showillnesses_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = thisPatient.Illness;
        }
    }
}
