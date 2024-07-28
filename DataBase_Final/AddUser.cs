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
    public partial class AddUser : Form
    {
        string viewtablename = "";
        bool AdmintoAdd = false;
        private string ID = "";
        public AddUser()
        {
            InitializeComponent();
            RoomType_combo.Enabled = false;
            this.AdminView_pnl.Visible = false;
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            UserAdd_pnl.Visible = false;
            AdminAdd_pnl.Visible = false;
        }
        private void AdminAdd_btn_CheckedChanged(object sender, EventArgs e)
        {
            AdminAdd_pnl.Visible = true;
            UserAdd_pnl.Visible = false;
            AdmintoAdd = true;
        }
        private void UserAdd_btn_CheckedChanged(object sender, EventArgs e)
        {
            UserAdd_pnl.Visible = true;
            AdminAdd_pnl.Visible = false;
            AdmintoAdd = false;
            Insert_id();
            this.IDGenerated_label.Text = ID;
            this.RoomNo_combo.Enabled = false;
           
        }
        private void RoomCombo()
        {
            if(this.RoomType_combo.Text!="")
            {
                string Query;
                int hostelnumber;
                Int32.TryParse(this.HostelNo_combo.Text, out hostelnumber);

                if (this.RoomType_combo.Text == "SINGLE")
                {
                    Query = "select RoomNo from Room where roomtype = '" + this.RoomType_combo.Text + "' AND strength < 1 AND Hostel_ID = " + hostelnumber + " ";

                }
                else if (this.RoomType_combo.Text == "DOUBLE")
                {
                    Query = "select RoomNo from Room where roomtype = '" + this.RoomType_combo.Text + "' AND strength < 2 AND Hostel_ID = " + hostelnumber + " ";

                }
                else
                {
                    Query = "select RoomNo from Room where roomtype = '" + this.RoomType_combo.Text + "' AND strength < 6 AND Hostel_ID = " + hostelnumber + " ";

                }
                RoomNo_combo.Enabled = true;
                string connectionString = Login.ConnectionStr();
                OracleConnection MyConn = new OracleConnection(connectionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    RoomNo_combo.Items.Add(dTable.Rows[i][0].ToString());
                }
                MyConn.Close();
            }
        }
        private void generate_SID()
        {
            Random randvalue = new Random();
            int IDvalue = randvalue.Next(1000, 9999);
            ID = "20F-" + IDvalue.ToString();
        }
        private void Insert_id()
        {
            generate_SID();
            bool idready = false;
            string connectionString = Login.ConnectionStr();
            OracleConnection MyConn = new OracleConnection(connectionString);
            MyConn.Open();
            do
            {
                string Query = "select student_ID from Student where Student_Id = '" + ID + "'";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    generate_SID();
                    idready = true;
                }
            } while (idready == true);
            MyConn.Close();
        }
        private void MaintainRoomStrength()
        {
            try
            {
                int strength = 0;
                string connetionString = Login.ConnectionStr();
                string sql = "select strength from room where roomno = '" + this.RoomNo_combo.Text + "'";

                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    Int32.TryParse(dTable.Rows[0]["STRENGTH"].ToString(), out strength);
                }
                strength++;
                sql = " update room set strength = " + strength + " where roomNo = '" + this.RoomNo_combo.Text + "'";
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
        private void AddStudent()
        {
            string CheckInputs = U_Name_txtbox.Text;
            if (CheckInputs != "")
            {
                CheckInputs = U_Contact_txtbox.Text;
                if (CheckInputs != "")
                {
                    CheckInputs = U_CNIC_txtbox.Text;
                    if (CheckInputs != "")
                    {

                        CheckInputs = U_Email_txtbox.Text;
                        if (CheckInputs != "")
                        {
                            CheckInputs = STDGender_Combo.Text;
                            if (CheckInputs != "")
                            {
                                CheckInputs = U_Password_txtbox.Text;
                                if (CheckInputs != "")
                                {
                                    CheckInputs = RoomNo_combo.Text;
                                    if(CheckInputs!="")
                                    {
                                        string connetionString = Login.ConnectionStr();
                                        try
                                        {
                                            string sql = " INSERT ALL " +
                                                    "INTO STUDENT(STUDENT_ID, STDNAME , STDGENDER, STDPASSWORD,STDROOMNO) VALUES('" + ID + "','" +
                                                    this.U_Name_txtbox.Text + "','" + this.STDGender_Combo.Text + "','" + this.U_Password_txtbox.Text + "','"+this.RoomNo_combo.Text+"') " +
                                                    "INTO STUDENT_DETAILS(STD_ID, CONTACT , CNIC , EMAIL) VALUES('" + ID + "','" + this.U_Contact_txtbox.Text + "','" + this.U_CNIC_txtbox.Text + "','" + this.U_Email_txtbox.Text + "') Select * from dual";

                                            OracleConnection MyConn = new OracleConnection(connetionString);
                                            MyConn.Open();
                                            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                            DataTable dTable = new DataTable();
                                            MyAdapter.Fill(dTable);
                                            DialogResult result = MessageBox.Show("Student is Added in the System", "Task Ouput!");
                                            if (result == DialogResult.OK)
                                            {
                                                this.U_Name_txtbox.Text = "";
                                                this.U_Contact_txtbox.Text = "";
                                                this.U_CNIC_txtbox.Text = "";
                                                this.U_Email_txtbox.Text = "";
                                                this.STDGender_Combo.StartIndex = -1;
                                                this.U_Password_txtbox.Text = "";
                                                this.RoomNo_combo.StartIndex = -1;
                                            }
                                            MyConn.Close();
                                            MaintainRoomStrength();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Database Connection Error!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter Room No of Student", "Input Error!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter Password of Student", "Input Error!");
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
        private void AddAdmin()
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
                                string connetionString = Login.ConnectionStr();
                                try
                                {
                                    string sql = "INSERT INTO ADMIN(USERNAME, ADMINPASSWORD, ADMINNAME, CONTACTNO, DESIGNATION) VALUES('" + this.Admin_UserName_textbox.Text + "','" + this.AdminPassword_TextBox.Text + "','" + this.AdminName_Txtbox.Text + "','" + this.Admin_Contact_textbox.Text + "','" + this.Admin_Design_textbox.Text + "')";
                                    OracleConnection MyConn = new OracleConnection(connetionString);
                                    MyConn.Open();
                                    OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                                    DataTable dTable = new DataTable();
                                    MyAdapter.Fill(dTable);
                                    DialogResult result = MessageBox.Show("Admin is Added in the System","Task Ouput!");
                                    if(result==DialogResult.OK)
                                    {
                                        this.AdminName_Txtbox.Text = "";
                                        this.Admin_Contact_textbox.Text="";
                                        this.Admin_Design_textbox.Text="";
                                        this.Admin_UserName_textbox.Text="";
                                        this.AdminPassword_TextBox.Text="";
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
        private void SaveAdmin_btn_Click(object sender, EventArgs e)
        {
            if(AdmintoAdd)
            {
                AddAdmin();
            }
            else
            {
                AddStudent();
            }
        }
        private void HostelNo_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.RoomType_combo.Enabled = true;
            this.RoomNo_combo.Items.Clear();
            RoomCombo();
        }
        private void RoomType_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.RoomNo_combo.Items.Clear();
            RoomCombo();
        }
        private void ViewType_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.ViewType_combo.Text!="")
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
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (this.ViewType_combo.Text != "")
            {
                if (this.ViewType_combo.Text == "Admin")
                {
                    viewtablename = "select * from Admin where username ='"+this.U_ID_txtbox.Text+"'";
                }
                else
                {
                    viewtablename = "SELECT S.STUDENT_ID,S.STDNAME,SD.CNIC,SD.CONTACT,sd.email,RM.ROOMNO,RM.ROOMTYPE FROM STUDENT S INNER JOIN student_details SD ON S.STUDENT_ID = SD.STD_ID INNER JOIN room RM ON s.stdroomno = RM.ROOMNO where student_id = '"+this.U_ID_txtbox.Text+"'";
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
        private void View_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = true;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.AdminView_pnl.Visible = false;
        }

        private void U_return_btn_Click(object sender, EventArgs e)
        {
            this.UserAdd_pnl.Visible = false;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.AdminAdd_pnl.Visible = false;
        }
    }
}
