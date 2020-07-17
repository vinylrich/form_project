using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lets_make_a_plaann
{
    public partial class checkplan : MetroForm
    {
            public event EventHandler DoubleClickEx;
            public checkplan()
            {
              
                InitializeComponent();
            }




       

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectionRange val = new SelectionRange(monthCalendar1.SelectionRange);
       
            MessageBox.Show(val.End.ToString("yyyy/M/d"));
            //label1.Text = selected_Date;
            string connectionString = "server = 127.0.0.1,1433; uid = ajtwoddltka; pwd = toor; database = PD_DB;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();   //DB 연결

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT contents FROM pt,dt";
            if (cmd.CommandText == null)
            {
                MessageBox.Show("등록된 플래너나 다이어리가 없습니다...");
            }
            else
            {
                this.Visible = false;
                checkcontents main = new checkcontents(val.End.ToString("yyyy/M/d"));
                main.Show();
            }
            
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlannerForm main = new PlannerForm();
            main.Show();
        }
    }
}
    