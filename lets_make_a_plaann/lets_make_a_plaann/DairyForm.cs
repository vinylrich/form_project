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
    public partial class DairyForm : MetroForm
    {
        private DataTable date_table = null;
        private SqlConnection sqlconn = null;
        private string constr = "SERVER = 127.0.0.1,1433; DATABASE = PD_DB;" + "UID=ajtwoddltka; PASSWORD=toor ";

        public DairyForm()
        {
            try
            {
                sqlconn = new SqlConnection(constr);
                sqlconn.Open();
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.ToString());
            }
            InitializeComponent();
            sqlconn.Close();
        }



        private void diary_Click(object sender, EventArgs e)//"일기"를 클릭하면 dairyForm.cs로 넘어가 폼이 바뀜
        {
            MessageBox.Show("이미 다이어리 모드입니다!");
        }

        private void check_plan_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            checkplan showForm2 = new checkplan();
            showForm2.Show();
        }
        private void save_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string year = year_box.Text;
                string month = month_box.Text;
                string day = day_box.Text;
                string contents = text.Text;
                conn.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "INSERT INTO DATE(year, month, day,contents) VALUES('" + year + "','" + month + "','" + day + "','" + contents + "');";
                MessageBox.Show("저장 성공!");
                command.ExecuteNonQuery();

            }
        }


        private void connect_Click(object sender, EventArgs e)
        {
            string connectionString = "server = 127.0.0.1,1433; uid = ajtwoddltka; pwd = toor; database = PD_DB;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();   //DB 연결

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * FROM date";



            sqlConn.Close();	//DB 연결 해제
        }

        private void planner_Click_1(object sender, EventArgs e) //"플래너"를 클릭하면 plannerForm.cs로 넘어가 폼이 바뀜
            {
                this.Visible = false;
                DairyForm showForm2 = new DairyForm();
                showForm2.Show();
                MessageBox.Show("플래너 모드!");
            }
    }
}
