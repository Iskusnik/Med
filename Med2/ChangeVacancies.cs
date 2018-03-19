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
                
                FileStream fs = new FileStream(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter t = new StreamWriter(fs);
                for (int i = 0; i < jobs.Length; i++)
                    if (job != jobs[i])
                        t.WriteLine((jobs[i]));
                t.Close();
                fs.Close();

                Refresh_Menu();
            }
            else
                MessageBox.Show("Удалять нечего");
        }
        private void Refresh_Menu()
        {
            comboBox1.Items.Clear();
            string[] jobs = File.ReadAllLines(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
            if (!(jobs == null || jobs.Length == 0))
                foreach (string job in jobs)
                    this.comboBox1.Items.Add(job);
        }
        private void ChangeVacancies_Load(object sender, EventArgs e)
        {
            Refresh_Menu();
            comboBox1.SelectedItem = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] jobs = File.ReadAllLines(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");

            string job = textBox1.Text;
            StreamWriter w = new StreamWriter(@"C:\Users\IskusnikXD\Source\Repos\Med\Med2\Работы.txt");
            w.WriteLine(job);
            foreach(string s in jobs)
                w.WriteLine(s);
            w.Close();
            Refresh_Menu();
        }
    }
}
