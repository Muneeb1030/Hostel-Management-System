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
    public partial class STDShiftRequestform : Form
    {
        public STDShiftRequestform()
        {
            InitializeComponent();
            this.RoomRequestApply_pnl.Visible = false;
            this.WaitRequest_pnl.Visible = false;
            this.ShifterID_txtbox.Text = Login.StudentLoginID;
            GetRequestStatus();
        }
        private void GetRequestStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                    string sql = "select status from shift_requests WHERE requesterID = '" + Login.StudentLoginID + "' and status = 0";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    if (dTable.Rows.Count > 0)
                    {
                        this.WaitRequest_pnl.Visible = true;
                    }
                    else
                    {
                        this.RoomRequestApply_pnl.Visible = true;
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
        private void getrooms()
        {
            try
            {
                string connetionString = Login.ConnectionStr();
                string sql = "select STDroomNo from student WHERE student_ID = '" + Login.StudentLoginID + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if(dTable.Rows.Count>0)
                {
                    this.ShifterRoomNo_txtbox.Text = dTable.Rows[0]["STDroomNo"].ToString();
                }
                sql = "select STDroomNo from student WHERE student_ID = '" + this.SwapperID_txtbox.Text + "'";

                MyAdapter = new OracleDataAdapter(sql, MyConn);
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if(dTable.Rows.Count>0)
                {
                    this.SwapperRoomNo_txtbox.Text = dTable.Rows[0]["STDroomNo"].ToString();
                }
                else
                {
                    MessageBox.Show("The Provided Swapper ID is Incorrect!", "Input Failure!");
                }
                
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }
        private void SendShiftrequest_btn_Click_1(object sender, EventArgs e)
        {
            if (this.SwapperID_txtbox.Text != "")
            {
                try
                {
                    getrooms();
                    string connetionString = Login.ConnectionStr();
                    string sql = "insert into SHIFT_REQUESTS ( requesterID, requester_roomNo, swapperID, swapper_RoomNo, reason) VALUES ('" + this.ShifterID_txtbox.Text + "', '" + this.ShifterRoomNo_txtbox.Text + "', '" + this.SwapperID_txtbox.Text + "', '" + this.SwapperRoomNo_txtbox.Text + "','" + this.ShiftReason_txtbox.Text + "')";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    MessageBox.Show("Request is Added in the Queue. Wait Patiently!", "Request Submitted!");
                    this.RoomRequestApply_pnl.Visible = false;
                    MyConn.Close();
                }
                catch
                {
                    MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
                }
            }
            else
            {
                MessageBox.Show("Please Provide appropriate Data for Shifting", "Input Failure!");
            }
        }

        private void RoomRequestCancel_btn_Click_2(object sender, EventArgs e)
        {
            try
            {
                string connetionString = Login.ConnectionStr();
                string sql = "delete from shift_requests where requesterid = '" + Login.StudentLoginID + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MessageBox.Show("Request is being remove from the Session!", "Request Cancelled!");
                MyConn.Close();
                this.WaitRequest_pnl.Visible = false;
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }

        private void RequestCancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
