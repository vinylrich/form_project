using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lets_make_a_plaann
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void diary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("다이어리를 쓰십시오");
        }

        private void planner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("플래너를 쓰십시오");
        }

        private void check_plan_Click(object sender, EventArgs e)
        {

            this.Visible = false; 
            checkplan showForm2 = new checkplan();
            showForm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
