using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DataBase_Final
{
    public partial class LeaveRequestForm : Form
    {
        public LeaveRequestForm()
        {
            InitializeComponent();
            this.U_ID_txtbox.Text = Login.StudentLoginID;
            GetRequestStatus();
            this.RequestView_pnl.Visible = false;
        }
        private void GetRequestStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from attendance WHERE STUDENT_ID = '" + this.U_ID_txtbox.Text + "' and status = 0";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    LeaveRequest_grid.DataSource = dTable;
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }
        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaveRequest_btn_Click(object sender, EventArgs e)
        {
            if(this.UReturnHour_txtbox.Text!="")
            {
                try
                {
                    int hours;
                    Int32.TryParse(this.UReturnHour_txtbox.Text, out hours);
                    string connetionString = Login.ConnectionStr();
                    string sql = " INSERT into attendance (student_ID,out_time,in_time) values ('" + this.U_ID_txtbox.Text + "',to_char(sysdate,'DD-MON-YY HH:MI:SS'),to_char((sysdate+" + hours + "/24),'DD-MON-YY HH:MI:SS'))";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    MessageBox.Show("Record is Saved in the System", "Record Saved!");
                    MyConn.Close();
                    GetRequestStatus();
                }
                catch
                {
                    MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
                }
            }
            else
            {
                MessageBox.Show("Please Provided Your time to Return", "Input Failure!");
            }
        }

        private void PassedRequestHistory_btn_Click(object sender, EventArgs e)
        {
            this.RequestView_pnl.Visible = true;
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from attendance WHERE STUDENT_ID = '" + this.U_ID_txtbox.Text + "' and status = 1";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    History_grid.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("No thing to Show!", "Task Requirement!");
                }

                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.RequestView_pnl.Visible = false;
        }

    }
}
