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
    public partial class AddVisitor : Form
    {
        public AddVisitor()
        {
            InitializeComponent();
            RequestView_pnl.Visible = false;
        }
        private void VisitorRequests_btn_Click(object sender, EventArgs e)
        {
            RequestView_pnl.Visible = true;
        }
        private void AddVisitorFunc()
        {
            string CheckInputs = this.STDID_txtbox.Text;
            if (CheckInputs != "")
            {
                CheckInputs = this.VRelation_txtbox.Text;
                if (CheckInputs != "")
                {
                    CheckInputs = this.VName_txtbox.Text;
                    if (CheckInputs != "")
                    {

                        CheckInputs = U_CNIC_txtbox.Text;
                        if (CheckInputs != "")
                        {
                            CheckInputs = U_Contact_txtbox.Text;
                            if (CheckInputs != "")
                            {
                                CheckInputs = VMeetHour_txtbox.Text;
                                if (CheckInputs != "")
                                {
                                    try
                                    {
                                        int hours;
                                        Int32.TryParse(this.VMeetHour_txtbox.Text, out hours);
                                        string connetionString = Login.ConnectionStr();
                                        string sql = " INSERT ALL " +
                                                   " into visitor (Student_ID,enter_time,leave_time,name,relation) values ('" + this.STDID_txtbox.Text + "',to_char(sysdate,'DD-MON-YY HH:MI:SS'),to_char((sysdate+" + hours + "/24),'DD-MON-YY HH:MI:SS'),'" + this.VName_txtbox.Text + "','" + this.VRelation_txtbox.Text + "')" +
                                                    "into visitor_detail (CNIC,contact) values ('" + this.U_CNIC_txtbox.Text + "','" + this.U_Contact_txtbox.Text + "') Select * from dual";

                                        OracleConnection MyConn = new OracleConnection(connetionString);
                                        MyConn.Open();
                                        OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                        DataTable dTable = new DataTable();
                                        MyAdapter.Fill(dTable);
                                        DialogResult result = MessageBox.Show("Visitor Record is Saved", "Task Successful!");
                                        if (result == DialogResult.OK)
                                        {
                                            this.VName_txtbox.Text = "";
                                            this.U_Contact_txtbox.Text = "";
                                            this.U_CNIC_txtbox.Text = "";
                                            VMeetHour_txtbox.Text = "";
                                            this.VName_txtbox.Text = "";
                                            this.VRelation_txtbox.Text = "";
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
                                    MessageBox.Show("Please Enter Meeting Time of Visitor", "Input Error!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Contact of Visitor", "Input Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter CNIC of Visitor", "Input Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Name of Visitor", "Input Error!");

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Relation of Visitor to Student", "Input Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter ID of Student", "Input Error!");
            }
        }
        private void SearchVisitor_btn_Click(object sender, EventArgs e)
        {
            if(this.U_ID_txtbox.Text!="")
            {
                string connetionString = Login.ConnectionStr();
                try
                {
                    string sql = "select Student_ID,relation,name,CNIC,contact,enter_time,leave_time from visitor inner join visitor_detail on visitor.VID=Visitor_detail.VD_ID WHERE STUDENT_ID = '" + this.U_ID_txtbox.Text + "'";
                    OracleConnection MyConn = new OracleConnection(connetionString);
                    MyConn.Open();
                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    if (dTable.Rows.Count > 0)
                    {
                        Visitor_grid.DataSource = dTable;
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
                MessageBox.Show("Please Provide ID of Student", "Input Error!");
            }
            
        }
        private void SaveVisitor_btn_Click(object sender, EventArgs e)
        {
            AddVisitorFunc();
        }
        private void VisitorView_btn_Click(object sender, EventArgs e)
        {
            this.RequestView_pnl.Visible = true;
            this.U_ID_txtbox.Text = "";
        }

        private void U_return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.RequestView_pnl.Visible = false;
        }

     
    }
}
