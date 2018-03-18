using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Med2
{
    public partial class ChangeVacancies : Form
    {
        public ChangeVacancies()
        {
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                string[] jobs = File.ReadAllLines(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
                string job = comboBox1.Text;

                File.Delete(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
                File.Create(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");

                StreamWriter w = new StreamWriter(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");

                for (int i = 0; i < jobs.Length - 1; i++)
                    if (job != jobs[i])
                        w.WriteLine(jobs[i]);
            }
            else
                MessageBox.Show("Удалять нечего");
        }

        private void ChangeVacancies_Load(object sender, EventArgs e)
        {
            string[] jobs = File.ReadAllLines(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
            if (!(jobs == null || jobs.Length == 0))
                foreach (string job in jobs)
                    this.comboBox1.Items.Add(job);

            comboBox1.SelectedItem = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string job = textBox1.Text;
            StreamWriter w = new StreamWriter(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
            w.WriteLine(job);
            w.Close();
        }
    }
}
