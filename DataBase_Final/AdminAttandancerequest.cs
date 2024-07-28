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
    public partial class AdminAttandancerequest : Form
    {
        string STD_ID = "";
        int request_ID = 0;
        public AdminAttandancerequest()
        {
            InitializeComponent();
            GetRequestStatus();
        }
        private void GetRequestStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from Attendance WHERE status = 0";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    AttandanceRequest_grid.DataSource = dTable;
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

        private void ApproveLeave_btn_Click(object sender, EventArgs e)
        {
            string connetionString = Login.ConnectionStr();

            try
            {
                string sql = "update Attendance set status = 1 where student_id = '" + STD_ID + "' and id = "+request_ID+"";
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

        private void AttandanceRequest_grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow MySelectedRow = this.AttandanceRequest_grid.Rows[e.RowIndex];
                STD_ID = MySelectedRow.Cells["Student_ID"].Value.ToString();
                Int32.TryParse(MySelectedRow.Cells["ID"].Value.ToString(), out request_ID);
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
