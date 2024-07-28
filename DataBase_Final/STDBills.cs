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
    public partial class STDBills : Form
    {
        public STDBills()
        {
            InitializeComponent();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STDVBillsView_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from BILL_Collection where STD_ID = '" + Login.StudentLoginID + "'";
                string connetionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    STDBillsView_grid.DataSource = dTable;
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
    }
}
