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
    public partial class Bills : Form
    {
        int MessDues = 0, RoomDues = 0, GYMDues = 0, Total = 0, outstanding = 0, Paid = 0;
        public Bills()
        {
            InitializeComponent();
            BillView_pnl.Visible = false;
        }
        private void BillsView_btn_Click(object sender, EventArgs e)
        {
            BillView_pnl.Visible = true;
        }
        private void MessExpense_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.MessExpense_txtbox.Text, out MessDues);
           Int32.TryParse(this.PaidExpense_txtbox.Text, out Paid);

            Total = MessDues + RoomDues + GYMDues;
            outstanding = (Total - Paid);
            this.TotalExpense_txtbox.Text = Total.ToString();
            this.OutstamdingExpense_txtbox.Text = outstanding.ToString();

        }
        private void RoomExpense_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.RoomExpense_txtbox.Text, out RoomDues);
           
            Total = MessDues + RoomDues + GYMDues;
            outstanding = (Total - Paid);
            this.TotalExpense_txtbox.Text = Total.ToString();
            this.OutstamdingExpense_txtbox.Text = outstanding.ToString();

        }
        private void GYMExpense_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.GYMExpense_txtbox.Text, out GYMDues);
           
            Total = MessDues + RoomDues + GYMDues;
            outstanding = (Total - Paid);
            this.TotalExpense_txtbox.Text = Total.ToString();
            this.OutstamdingExpense_txtbox.Text = outstanding.ToString();

        }

        private void BillViewColse_btn_Click(object sender, EventArgs e)
        {
            this.BillView_pnl.Visible = false;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBILL()
        {
            string CheckInputs = STDID_txtbox.Text;
            if (CheckInputs != "")
            {
                CheckInputs = this.PaidExpense_txtbox.Text;
                if (CheckInputs != "")
                {
                    try
                    {
                        string sql = "INSERT INTO BILL_COLLECTION ( STD_ID, currentBillingMonth, billPaidDate, mess_dues, room_dues, gym_dues, Total, outstanding, paid) VALUES ('" + this.STDID_txtbox.Text + "','" + DateTime.Now.ToString("MMMM") + "',to_date(sysdate,'DD-MON-YY')," + MessDues + "," + RoomDues + "," + GYMDues + "," + Total + "," + outstanding + "," + Paid + ")";
                        string connetionString = Login.ConnectionStr();
                        OracleConnection MyConn = new OracleConnection(connetionString);
                        MyConn.Open();
                        OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        DialogResult result = MessageBox.Show("STudent Bill is Saved", "Task Successful!");
                        if (result == DialogResult.OK)
                        {
                            this.STDID_txtbox.Text = "";
                            this.PaidExpense_txtbox.Text = "";
                            this.MessExpense_txtbox.Text = "";
                            this.RoomExpense_txtbox.Text = "";
                            this.GYMExpense_txtbox.Text = "";
                        }
                        MyConn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Database Connection Failure!","Connection Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Amount Paid by Student", "Input Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter ID of Student", "Input Error!");
            }
        }
        private void BillInsert_btn_Click(object sender, EventArgs e)
        {
            AddBILL();
        }

        private void BillViewOption_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(BillViewOption_combo.Text=="")
            {
                this.SearchBill_btn.Enabled = false;
            }
            else
            {
                this.SearchBill_btn.Enabled = true;
            }
        }

        private void SearchBill_btn_Click(object sender, EventArgs e)
        {
            if (BillViewtype_txtbox.Text != "")
            {
                string sql = "";
                if (BillViewOption_combo.Text == "Student ID")
                {
                    sql = "select * from BILL_Collection where STD_ID = '" + this.BillViewtype_txtbox.Text + "'";
                }
                else if (this.BillViewOption_combo.Text == "")
                {
                    sql = "";
                }
                else
                {
                    sql = "select * from BILL_Collection where CURRENTBILLINGMONTH = '" + this.BillViewtype_txtbox.Text + "'";
                }
                string connetionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if(dTable.Rows.Count>0)
                {
                    Bills_grid.DataSource = dTable;
                }
                else
                {
                    this.BillViewOption_combo.Text = "";
                    this.BillViewtype_txtbox.Text = "";
                    MessageBox.Show("Data you are tring to get, Does not Exist", "Search Failure!");
                }
                MyConn.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Value in Text Box", "Input Failure!");
            }
        }

        private void PaidExpense_txtbox_TextChanged(object sender, EventArgs e)
        {
           
            Int32.TryParse(this.MessExpense_txtbox.Text, out MessDues);
            Int32.TryParse(this.RoomExpense_txtbox.Text, out RoomDues);
            Int32.TryParse(this.GYMExpense_txtbox.Text, out GYMDues);
            Int32.TryParse(this.PaidExpense_txtbox.Text, out Paid);

            Total = MessDues + RoomDues + GYMDues;
            outstanding = (Total - Paid);
            this.TotalExpense_txtbox.Text = Total.ToString();
            this.OutstamdingExpense_txtbox.Text = outstanding.ToString();

        }
    }
}
