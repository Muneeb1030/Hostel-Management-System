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
    public partial class GYMform : Form
    {
        public GYMform()
        {
            InitializeComponent();
            ShowAllGymRecord();
        }
        private void ShowAllGymRecord()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select * from GyM where membership_status = 1";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                GYM_grid.DataSource = dTable;
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
        }
        private void SearchGYM_btn_Click(object sender, EventArgs e)
        {
            if(this.U_ID_txtbox.Text!="")
            {
                string connetionString = Login.ConnectionStr();
                try
                {
                    string sql = "select * from GyM WHERE STUDENT_ID = '" + this.U_ID_txtbox.Text + "' and membership_status = 1";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    if(dTable.Rows.Count>0)
                    {
                        GYM_grid.DataSource = dTable;
                    }
                    else
                    {
                        this.U_ID_txtbox.Text = "";
                        MessageBox.Show("Data you are tring to get, Does not Exist", "Search Failure!");
                    }
                    MyConn.Close();
                }
                catch
                {
                    MessageBox.Show("Database Connection Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter ID to Searh!", "Input Error!");
            }
        }
        private void U_ID_txtbox_TextChanged(object sender, EventArgs e)
        {
            ShowAllGymRecord();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
