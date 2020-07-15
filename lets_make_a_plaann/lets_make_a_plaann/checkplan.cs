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
    public partial class checkplan : MetroForm
    {
        public checkplan()
        {
            InitializeComponent();
        }

        private void back_to_Main_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlannerForm main = new PlannerForm();
            main.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
    