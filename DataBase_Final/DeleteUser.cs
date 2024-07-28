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
    public partial class DeleteUser : Form
    {
        private bool admintodelete = false;
        string viewtablename = "";
        public DeleteUser()
        {
            InitializeComponent();
            AdminDelete_pnl.Visible = false;
            UserDelete_pnl.Visible = false;
            this.AdminView_pnl.Visible = false;
        }
        private void AdminDelete_btn_CheckedChanged(object sender, EventArgs e)
        {
            AdminDelete_pnl.Visible = true;
            UserDelete_pnl.Visible = false;
            admintodelete = true;
        }
        private void UserDelete_btn_CheckedChanged(object sender, EventArgs e)
        {
            AdminDelete_pnl.Visible = false;
            UserDelete_pnl.Visible = true;
            admintodelete = false;
        } 
        private void GetStudentData()
        {
            string sql = "select Student_ID, STDNAME, CNIC, CONTACT,EMAIL,STDGENDER, STDPASSWORD FROM Student inner join student_details on student_ID=STD_ID WHERE Student_ID = '" + this.U_ID_txtbox.Text + "'";
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
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (admintodelete)
            {
                GetAdminData();
            }
            else
            {
                GetStudentData();
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
                MessageBox.Show("Database Connection Problem!", "Connection Error!");
            }
        }
        private void DeleteAdmin()
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "Delete from ADMIN WHERE USERNAME = '" + this.Admin_UserName_textbox.Text + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DialogResult result = MessageBox.Show("Admin is Removed from the System", "Task Ouput!");
                if (result == DialogResult.OK)
                {
                    this.AdminName_Txtbox.Text = "";
                    this.Admin_Contact_textbox.Text = "";
                    this.Admin_Design_textbox.Text = "";
                    this.Admin_UserName_textbox.Text = "";
                    this.AdminPassword_TextBox.Text = "";
                }
                MyConn.Close();
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
        }
        private void MaintainRoomStrength()
        {
            try
            {
                int strength = 0;
                string connetionString = Login.ConnectionStr();
                string sql = "select strength from room where roomno =  (select STDROOMNO from student where student_id ='" + this.U_ID_txtbox.Text + "')";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    Int32.TryParse(dTable.Rows[0]["STRENGTH"].ToString(), out strength);
                }
                strength--;
                sql = " update room set strength = " + strength + " where roomNo = (select STDROOMNO from student where student_id ='" + this.U_ID_txtbox.Text + "')";
                MyAdapter = new OracleDataAdapter(sql, MyConn);
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection While Maintaining Rooms Error!", "Room Strength Error!");
            }
        }
        private void DeleteStudent()
        {
            MaintainRoomStrength();
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "DELETE FROM STUDENT  WHERE Student_ID = '" + this.U_ID_txtbox.Text + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DialogResult result = MessageBox.Show("Student is Removed from the System", "Task Ouput!");
                if (result == DialogResult.OK)
                {
                    this.U_ID_txtbox.Text = "";
                    this.U_Name_txtbox.Text = "";
                    this.U_Contact_txtbox.Text = "";
                    this.U_CNIC_txtbox.Text = "";
                    this.U_Email_txtbox.Text = "";
                    this.U_Gender_txtbox.Text = "";
                    this.U_Password_txtbox.Text = "";
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
        }
        private void DeleteAdmin_btn_Click(object sender, EventArgs e)
        {
            if (admintodelete)
            {
                DeleteAdmin();
            }
            else
            {
                DeleteStudent();
            }
        }
        private void View_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = true;
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
        private void ID_txtbox_TextChanged(object sender, EventArgs e)
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
        private void AdminView_btn_Click(object sender, EventArgs e)
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

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = false;
        }

        private void U_return_btn_Click(object sender, EventArgs e)
        {
            this.UserDelete_pnl.Visible = false;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.AdminDelete_pnl.Visible = false;
        }
    }
}
