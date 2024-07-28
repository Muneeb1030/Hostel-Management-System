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
    public partial class Expenseform : Form
    {
        public Expenseform()
        {
            InitializeComponent();
            GetAllexpenses();
        }
        private void GetAllexpenses()
        {
            string sql = "Select * from Expenses";
            string connetionString = Login.ConnectionStr();
            OracleConnection MyConn = new OracleConnection(connetionString);
            MyConn.Open();
            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            Expense_grid.DataSource = dTable;
            MyConn.Close();
        }
        private void SearchExpense_btn_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (this.ExpenseSearchType_combo.Text == "Hostel 1")
            {
                sql = "select * from Expenses where hostel_id = 1";
            }
            else if(this.ExpenseSearchType_combo.Text == "Hostel 2")
            {
                sql = "select * from Expenses where hostel_id = 2";
            }
            else if (this.ExpenseSearchType_combo.Text=="")
            {
                sql = "";
            }
            else
            {
                sql = "select * from Expenses where type = '" + this.ExpenseSearchType_combo.Text + "'";
            }
            if(sql!="")
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
                        Expense_grid.DataSource = dTable;
                    }
                    else
                    {
                        this.ExpenseSearchType_combo.Text = "";
                        MessageBox.Show("Data you are tring to get, Does not Exist", "Search Failure!");
                    }
                   
                    MyConn.Close();
                }
                catch
                {
                    MessageBox.Show("Data Base Connection Failure!", "Connection Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Type to Search!", "Input Error!");
            }
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
