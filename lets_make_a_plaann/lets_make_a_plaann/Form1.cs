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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static readonly Form1 theForm1 = new Form1();
        public static readonly Form2 theForm2 = new Form2();

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

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false; 
            Form2 showForm2 = new Form2();
            showForm2.Show();
        }
    }
}
