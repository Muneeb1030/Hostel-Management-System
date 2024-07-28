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
    public partial class AdminViewGymRequet : Form
    {
        string STD_ID = "";
        public AdminViewGymRequet()
        {
            InitializeComponent();
            GetMemberStatus();
        }

        private void GetMemberStatus()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from Gym WHERE membership_status = 0";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                GymRequest_grid.DataSource = dTable;
                if (dTable.Rows.Count <= 0)
                {
                    MessageBox.Show("No Requests are Pending","Task Requirement!");
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure","Connection Failure!");
            }
        }
        private void ApproveGYM_btn_Click(object sender, EventArgs e)
        {
            string connetionString = Login.ConnectionStr();
            
            try
            {
                string sql = "update gym set membership_status = 1 where student_id = '" + STD_ID+"'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn.Close();
                GetMemberStatus();
            }
            catch
            {
                MessageBox.Show("Database Connection Failure", "Connection Failure!");
            }
        }

        private void GymRequest_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow MySelectedRow = this.GymRequest_grid.Rows[e.RowIndex];
                STD_ID = MySelectedRow.Cells["Student_ID"].Value.ToString();
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
