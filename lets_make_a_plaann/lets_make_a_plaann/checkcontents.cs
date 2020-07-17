using MetroFramework;
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
    
    public partial class checkcontents : MetroForm
    {
        string str1 = null;
        string connectionString = "server = 127.0.0.1,1433; uid = ajtwoddltka; pwd = toor; database = PD_DB;";
        public checkcontents(string s)
        {
           
            this.str1 = s;
            InitializeComponent();
           
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();   //DB 연결

            date_text.Text = str1;

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = sqlConn;

            string contents1 = "select contents from pt	where Date_='" + str1 + "'";
            string contents2 = "select contents from dt	where Date_='" + str1 + "'";
            SqlCommand cmd1 = new SqlCommand(contents1, sqlConn);
            SqlDataReader table1 = cmd1.ExecuteReader();

            table1.Read();
            while (table1.Read())
            {
                richTextBox1.Text = table1["contents"].ToString();

            }
            table1.Close();
            cmd1.Cancel();


            SqlCommand cmd2 = new SqlCommand(contents2, sqlConn);
            SqlDataReader table2 = cmd2.ExecuteReader();

            while (table2.Read())
            {
                richTextBox2.Text = table2["contents"].ToString();

            }
            

            //if (table["name__"].ToString() == "1")



            table2.Close();

        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            checkplan showForm2 = new checkplan();
            showForm2.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                conn.Open();
                command.Connection = conn;
                command.CommandText = "UPDATE dt SET contents ='" +richTextBox1.Text + "'WHERE Date_ = '" + str1+"'";
                command.ExecuteNonQuery();
            }
        }
    }
}
