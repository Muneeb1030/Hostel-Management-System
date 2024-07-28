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
    public partial class UpdateUser : Form
    {
        private bool admintoupdate = false;
        public UpdateUser()
        {
            InitializeComponent();
            AdminUpdate_pnl.Visible = false;
            UserUpdate_pnl.Visible = false;
            this.AdminView_pnl.Visible = false ;
        }
        private void AdminUpdate_btn_CheckedChanged(object sender, EventArgs e)
        {
            AdminUpdate_pnl.Visible = true;
            UserUpdate_pnl.Visible = false;
            admintoupdate = true;
        }
        private void UserUpdate_btn_CheckedChanged(object sender, EventArgs e)
        {
            UserUpdate_pnl.Visible = true;
            AdminUpdate_pnl.Visible = false;
            admintoupdate = false;
        } 
        private void SaveAdmin_btn_Click(object sender, EventArgs e)
        {
            if (admintoupdate)
            {
                UpdateAdmin();
            }
            else
            {
                UpdateStudent();
            }
        }
        private void GetAdminData()
        {
            string sql = "select USERNAME, ADMINPASSWORD, ADMINNAME, CONTACTNO, DESIGNATION FROM ADMIN WHERE USERNAME = '" + this.Admin_UserName_textbox.Text + "'";
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
                    this.AdminName_Txtbox.Text = dTable.Rows[0]["ADMINNAME"].ToString();
                    this.Admin_UserName_textbox.Text = dTable.Rows[0]["USERNAME"].ToString();
                    this.AdminPassword_TextBox.Text = dTable.Rows[0]["ADMINPASSWORD"].ToString();
                    this.Admin_Contact_textbox.Text = dTable.Rows[0]["CONTACTNO"].ToString();
                    this.Admin_Design_textbox.Text = dTable.Rows[0]["DESIGNATION"].ToString();

                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!", "Connection Error!");
            }
        }
        private void UpdateAdmin()
        {
           string CheckInputs = this.AdminName_Txtbox.Text;
            if (CheckInputs != "")
            {
                CheckInputs = this.Admin_Contact_textbox.Text;
                if (CheckInputs != "")
                {
                    CheckInputs = this.Admin_Design_textbox.Text;
                    if (CheckInputs != "")
                    {

                        CheckInputs = this.Admin_UserName_textbox.Text;
                        if (CheckInputs != "")
                        {
                            CheckInputs = this.AdminPassword_TextBox.Text;
                            if (CheckInputs != "")
                            {
                                try
                                {
                                    string connetionString = Login.ConnectionStr();
                                    string sql = "UPDATE ADMIN set  ADMINPASSWORD ='" + this.AdminPassword_TextBox.Text + "' , ADMINNAME = '" + this.AdminName_Txtbox.Text + "', CONTACTNO = '" + this.Admin_Contact_textbox.Text + "', DESIGNATION = '" + this.Admin_Design_textbox.Text + "' where  USERNAME = '" + this.Admin_UserName_textbox.Text + "'";
                                    OracleConnection MyConn = new OracleConnection(connetionString);
                                    MyConn.Open();
                                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                    DataTable dTable = new DataTable();
                                    MyAdapter.Fill(dTable);
                                    DialogResult result = MessageBox.Show("Admin is Updated in the System", "Task Ouput!");
                                    if (result == DialogResult.OK)
                                    {
                                        this.AdminUpdate_btn.Checked = false;
                                        this.AdminUpdate_pnl.Visible = false;
                                    }
                                    MyConn.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("Database Connection Error!","Error!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Password for Admin", "Input Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter User Name of Admin", "Input Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Designation of Admin", "Input Error!");

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Contact of Admin", "Input Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Name of Admin", "Input Error!");
            }
        }
        private void UpdateStudent()
        {
            string CheckInputs = this.U_Name_txtbox.Text;
            if (CheckInputs != "")
            {
                CheckInputs = this.U_Contact_txtbox.Text;
                if (CheckInputs != "")
                {
                    CheckInputs = this.U_CNIC_txtbox.Text;
                    if (CheckInputs != "")
                    {

                        CheckInputs = this.U_Email_txtbox.Text;
                        if (CheckInputs != "")
                        {
                            CheckInputs = this.U_Gender_txtbox.Text;
                            if (CheckInputs != "")
                            {
                                CheckInputs = this.U_Password_txtbox.Text;
                                if (CheckInputs != "")
                                {
                                    try
                                    {
                                        string connetionString = Login.ConnectionStr();
                                        string sql = "UPDATE STUDENT_DETAILS set Contact = '" + this.U_Contact_txtbox.Text + "', CNIC = '" + this.U_CNIC_txtbox.Text + "', EMAIL = '" + this.U_Email_txtbox.Text + "' WHERE STD_ID = '" + this.U_ID_txtbox.Text + "'";
                                        OracleConnection MyConn = new OracleConnection(connetionString);
                                        MyConn.Open();
                                        OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                        DataTable dTable = new DataTable();
                                        MyAdapter.Fill(dTable);
                                        sql = "UPDATE STUDENT set STDNAME = '" + this.U_Name_txtbox.Text + "', STDGENDER = '" + this.U_Gender_txtbox.Text + "', STDPASSWORD = '" + this.U_Password_txtbox.Text + "' WHERE STUDENT_ID = '" + this.U_ID_txtbox.Text + "'";
                                        MyAdapter = new OracleDataAdapter(sql, MyConn);
                                        dTable = new DataTable();
                                        MyAdapter.Fill(dTable);
                                        DialogResult result = MessageBox.Show("Student is Updated in the System", "Task Ouput!");
                                        if (result == DialogResult.OK)
                                        {
                                            this.UserUpdate_btn.Checked = false;
                                            this.UserUpdate_pnl.Visible = false;
                                        }
                                        MyConn.Close();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Database Connection Error!","Error!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter Gender of Student", "Input Error!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Gender of Student", "Input Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Email of Student", "Input Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter CNIC of Student", "Input Error!");

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Contact of Student", "Input Error!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Name of Student", "Input Error!");
            }
        }
        private void GetStudentData()
        {
            try
            {
                string sql = "select Student_ID, STDNAME, CNIC, CONTACT,EMAIL,STDGENDER, STDPASSWORD FROM Student inner join student_details on student_ID=STD_ID WHERE Student_ID = '" + this.U_ID_txtbox.Text + "'";
                string connetionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {

                    this.U_Name_txtbox.Text = dTable.Rows[0]["STDNAME"].ToString();
                    this.U_Contact_txtbox.Text = dTable.Rows[0]["CNIC"].ToString();
                    this.U_CNIC_txtbox.Text = dTable.Rows[0]["CONTACT"].ToString();
                    this.U_Email_txtbox.Text = dTable.Rows[0]["EMAIL"].ToString();
                    this.U_Gender_txtbox.Text = dTable.Rows[0]["STDGENDER"].ToString();
                    this.U_Password_txtbox.Text = dTable.Rows[0]["STDPassword"].ToString();

                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Problem!", "Connection Error!");
            }
        }
        private void Searxhupdate_btn_Click(object sender, EventArgs e)
        {
            if (admintoupdate)
            {
                GetAdminData();
            }
            else
            {
                GetStudentData();
            }
            
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = true;
        }
        string viewtablename = "";
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (this.ViewType_combo.Text != "")
            {
                if (this.ViewType_combo.Text == "Admin")
                {
                    viewtablename = "select * from Admin where username ='" + this.ID_txtbox.Text + "'";
                }
                else
                {
                    viewtablename = "SELECT S.STUDENT_ID,S.STDNAME,SD.CNIC,SD.CONTACT,sd.email,RM.ROOMNO,RM.ROOMTYPE FROM STUDENT S INNER JOIN student_details SD ON S.STUDENT_ID = SD.STD_ID INNER JOIN room RM ON s.stdroomno = RM.ROOMNO where student_id = '" + this.ID_txtbox.Text + "'";
                }
                string connetionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(viewtablename, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    View_grid.DataSource = dTable;
                }
                else
                {
                    this.U_ID_txtbox.Text = "";
                    this.ViewType_combo.Text = "";
                    MessageBox.Show("Data you are tring to get, Does not Exist", "Search Failure!");
                }
                MyConn.Close();
            }
            else
            {
                MessageBox.Show("Please Select a type to view!", "Input error!");
            }
        }

        private void ViewType_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ViewType_combo.Text != "")
            {
                if (this.ViewType_combo.Text == "Admin")
                {
                    viewtablename = "select * from Admin";
                }
                else
                {
                    viewtablename = "SELECT S.STUDENT_ID,S.STDNAME,SD.CNIC,SD.CONTACT,sd.email,RM.ROOMNO,RM.ROOMTYPE FROM STUDENT S INNER JOIN student_details SD ON S.STUDENT_ID = SD.STD_ID INNER JOIN room RM ON s.stdroomno = RM.ROOMNO";
                }
                string connetionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(viewtablename, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                View_grid.DataSource = dTable;
                MyConn.Close();
            }
            else
            {
                MessageBox.Show("Please Select a type to view!", "Input error!");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = false;
            this.ViewType_combo.StartIndex = -1;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.AdminUpdate_pnl.Visible = false;
        }

        private void U_return_btn_Click(object sender, EventArgs e)
        {
            this.UserUpdate_pnl.Visible = false;
        }
    }
}
