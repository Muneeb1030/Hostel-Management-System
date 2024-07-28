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
    public partial class AdminViewRoomShift : Form
    {
        string requester_ID = "", requestroom = "",
            swapperId = "", Swapperroom = "";
        public AdminViewRoomShift()
        {
            InitializeComponent();
            GetRequestStatus();
        }
        private void GetRequestStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from shift_requests WHERE status = 0";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    RoomRequest_grid.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("No Requests are Pending", "Task Requirement!");
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure", "Connection Failure!");
            }
        }
        private void ChangeRequestStatus()
        {
            string connetionString = Login.ConnectionStr();

            try
            {
                string sql = "update shift_requests set status = 1 where requesterid = '" + requester_ID + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn.Close();
                GetRequestStatus();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure", "Connection Failure!");
            }
        }
        private void SwapRooms()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from shift_requests where requesterid = '" + requester_ID + "' and status = 0";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                requester_ID = dTable.Rows[0]["requesterID"].ToString();
                requestroom= dTable.Rows[0]["requester_roomNo"].ToString();
                swapperId = dTable.Rows[0]["swapperID"].ToString();
                Swapperroom = dTable.Rows[0]["swapper_roomNo"].ToString();
                MyConn.Close();
                MakeSwap();
                GetRequestStatus();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure", "Connection Failure!");
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomRequest_grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow MySelectedRow = this.RoomRequest_grid.Rows[e.RowIndex];
                requester_ID = MySelectedRow.Cells["requesterID"].Value.ToString();
            }
        }
        private void MakeSwap()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "update student set STDroomno = '"+Swapperroom+"' where student_id='"+requester_ID+"'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                sql = "update student set STDroomno = '" + requestroom+ "' where student_id='" + swapperId + "'";
                 MyAdapter = new OracleDataAdapter(sql, MyConn);
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure", "Connection Failure!");
            }
        }

        private void ApproveRoom_btn_Click(object sender, EventArgs e)
        {
            SwapRooms();
            ChangeRequestStatus();
        }
    }
}
