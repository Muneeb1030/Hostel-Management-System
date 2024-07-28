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
    public partial class MaintainanceInsertform : Form
    {
        int HostelNo = 0, PerunitPrice = 0, Extent = 0,
            total = 0, outstanding = 0, Paid = 0;
        public MaintainanceInsertform()
        {
            InitializeComponent();
        }
        private void MaintainPrice_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.MaintainPrice_txtbox.Text, out PerunitPrice);
            total = Extent * PerunitPrice;
            this.TotalMaintainExpense_txtbox.Text = total.ToString();
            outstanding = total - Paid;
            this.OutstamdingMaintainExpense_txtbox.Text = outstanding.ToString();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaidMaintainExpense_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.PaidMaintainExpense_txtbox.Text, out Paid);
            total = Extent * PerunitPrice;
            this.TotalMaintainExpense_txtbox.Text = total.ToString();
            outstanding = total - Paid;
            this.OutstamdingMaintainExpense_txtbox.Text = outstanding.ToString();
        }
        private void HostelNo_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.HostelNo_combo.Text, out HostelNo);
        }
        private void MaintainExtent_txtbox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(this.MaintainExtent_txtbox.Text, out Extent);
            total = Extent * PerunitPrice;
            this.TotalMaintainExpense_txtbox.Text = total.ToString();
            outstanding = total - Paid;
            this.OutstamdingMaintainExpense_txtbox.Text = outstanding.ToString();
        }
        private void BillInsert_btn_Click(object sender, EventArgs e)
        {
            AddMaintain();
        }
        private void AddMaintain()
        {
            string CheckInputs = this.MaintainName_txtbox.Text;
            if (CheckInputs != "")
            {

                CheckInputs = this.MaintainExtent_txtbox.Text;
                if (CheckInputs != "")
                {
                    CheckInputs = this.MaintainPrice_txtbox.Text;
                    if (CheckInputs != "")
                    {
                        CheckInputs = this.HostelNo_combo.Text;
                        if (CheckInputs != "")
                        {
                            try
                            {
                                string connetionString = Login.ConnectionStr();
                                string sql = " INSERT INTO MAINTENANCE (hostel_ID, name, perUnitPrice, Total, Quantity, maintenance_date) VALUES (" + HostelNo + ", '" + this.MaintainName_txtbox.Text + "'," + PerunitPrice + "," + total + "," + Extent + " , to_date(sysdate,'DD-MON,YY'))";
                                OracleConnection MyConn = new OracleConnection(connetionString);
                                MyConn.Open();
                                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                DataTable dTable = new DataTable();
                                MyAdapter.Fill(dTable);
                                DialogResult result = MessageBox.Show("Maintenance Record is Saved in System", "Task Successful!");
                                if (result == DialogResult.OK)
                                {
                                    this.MaintainName_txtbox.Text = "";
                                    this.MaintainExtent_txtbox.Text = "";
                                    this.MaintainPrice_txtbox.Text = "";
                                    this.TotalMaintainExpense_txtbox.Text = "";
                                    this.HostelNo_combo.StartIndex = -1;
                                    this.PaidMaintainExpense_txtbox.Text = "";
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
                            MessageBox.Show("Please Enter Hostel Number", "Input Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Per Unit Price", "Input Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Consumption Scale", "Input Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Name of Maintenance", "Input Error!");

            }
        }
    }
}
