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
    public partial class STDGYMViewform : Form
    {
        public STDGYMViewform()
        {
            InitializeComponent();
            this.CancelMember_pnl.Visible = false;
            this.ApplyMember_pnl.Visible = false;
            this.WaitRequest_pnl.Visible = false;
            GetMemberStatus();
            this.U_ID_txtbox.Text = Login.StudentLoginID;
        }
        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetMemberStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select membership_status from Gym WHERE STUDENT_ID = '" + Login.StudentLoginID + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if(dTable.Rows.Count>0)
                {
                    int requeststatus = 0;
                    Int32.TryParse(dTable.Rows[0]["membership_status"].ToString(), out requeststatus);
                    if(requeststatus==0)
                    {
                        this.WaitRequest_pnl.Visible = true;
                    }
                    else
                    {
                        this.CancelMember_pnl.Visible = true;
                    }
                }
                else
                {
                    this.ApplyMember_pnl.Visible = true;
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }
        private void STDGYMApply_btn_Click(object sender, EventArgs e)
        {
            if (this.MemberShip_combo.Text != "")
            {
                try
                {
                    string connetionString = Login.ConnectionStr();
                    string sql = "INSERT INTO GYM (student_ID, type, join_date) values ('" + this.U_ID_txtbox.Text + "','" + this.MemberShip_combo.Text + "',to_date(sysdate))";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    MyConn.Close();
                    MessageBox.Show("Membership Request Submitted", "Request Submit!");
                    this.ApplyMember_pnl.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
                }
            }
            else
            {
                MessageBox.Show("Please Provided Appropriate Data to Insert", "Input Failure!");
            }
        }

        private void CancelmemberShip_btn_Click(object sender, EventArgs e)
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "delete from gym where student_id = '"+Login.StudentLoginID+"'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn.Close();
                MessageBox.Show("Membership Is Cancelled", "Cancelled!");

                this.CancelMember_pnl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }

        private void WaitMsgClose_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
