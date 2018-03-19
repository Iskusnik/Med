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
    public partial class ShowVisitRecords : Form
    {
        public ShowVisitRecords()
        {
            InitializeComponent();
        }

        private void ShowVisitRecords_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newMedDBDataSet.VisitInfoSet". При необходимости она может быть перемещена или удалена.
            this.visitInfoSetTableAdapter.Fill(this.newMedDBDataSet.VisitInfoSet);

        }
    }
}
