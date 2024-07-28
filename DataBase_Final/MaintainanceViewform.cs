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
    public partial class MaintainanceViewform : Form
    {
        public MaintainanceViewform()
        {
            InitializeComponent();
            GetAllRecord();
        }
        private void GetAllRecord()
        {
            string sql = "Select * from Maintenance";
            string connetionString = Login.ConnectionStr();
            OracleConnection MyConn = new OracleConnection(connetionString);
            MyConn.Open();
            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            Maintainance_grid.DataSource = dTable;
            MyConn.Close();
        }
        private void SearchMaintainance_btn_Click_1(object sender, EventArgs e)
        {
            if(this.MaintainName_txtbox.Text!="")
            {
                string sql = "";
                if (this.MaintainOption_combo.Text == "Hostel")
                {
                    int hostelno = 0;
                    Int32.TryParse(this.MaintainName_txtbox.Text, out hostelno);
                    sql = "select * from maintenance where hostel_id = " + hostelno + "";
                }
                else if (this.MaintainOption_combo.Text == "")
                {
                    sql = "";
                }
                else
                {
                    sql = "select * from maintenance where name = '" + this.MaintainName_txtbox.Text + "'";
                }
                if (sql != "")
                {
                    try
                    {
                        string connetionString = Login.ConnectionStr();
                        OracleConnection MyConn = new OracleConnection(connetionString);
                        MyConn.Open();
                        OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        if (dTable.Rows.Count > 0)
                        {
                            Maintainance_grid.DataSource = dTable;
                        }
                        else
                        {
                            this.MaintainOption_combo.Text = "";
                            this.MaintainName_txtbox.Text = "";
                            MessageBox.Show("Data you are tring to get, Does not Exist", "Search Failure!");
                        }
                        MyConn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Data BAse Connection Failure!", "Connection Failure!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Type to Search!", "Input Failure!");
                }
            }
           else
            {
                MessageBox.Show("Please Provide Name to Search!", "Input Failure!");
            }
            
        }

        private void MaintainName_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(this.MaintainName_txtbox.Text=="")
            {
                GetAllRecord();
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
