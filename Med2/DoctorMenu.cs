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
    public partial class DoctorMenu : Form
    {
        Doctor thisDoctor;
        public DoctorMenu(Doctor doct)
        {
            thisDoctor = doct;
            InitializeComponent();
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {//собриаем все возможные значения профессий
            var distinct = objs.GroupBy(car => car.typeID).Select(g => g.First()).ToList();
        }
        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regDocForm = new RegDocForm();
            regDocForm.Owner = this;
            regDocForm.ShowDialog();
        }
    }
}
