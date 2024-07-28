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
using System.Runtime.InteropServices;

namespace DataBase_Final
{
    public partial class Login : Form
    {
        public static string ConnectionStr()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User Id = system; Password = 123;";
        }
     
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        bool Admin_Login_Status = false;
        bool StudentLoginStatus = false;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void AdminLogin()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnectionStr = ConnectionStr();
                string Query = "SELECT * FROM ADMIN WHERE username = '" + this.UserNameText.Text + "' AND Adminpassword = '" + this.PasswordText.Text + "'";
                OracleConnection OracleCon = new OracleConnection(MyConnectionStr);
                OracleCon.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, OracleCon);
                DataTable dataTable = new DataTable();
                MyAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    AdminForm adminform = new AdminForm();
                    this.Hide();
                    adminform.Show();

                }
                else
                {
                    this.UserNameText.Clear();
                    this.PasswordText.Clear();
                    MessageBox.Show("Please Provide Correct \"UserName\" or \"Password\"","Input Error!");
                }
                OracleCon.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StudentLogin()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnectionStr = ConnectionStr();
                string Query = "SELECT * FROM student WHERE student_ID = '" + this.UserNameText.Text + "' AND STDpassword = '" + this.PasswordText.Text + "'";
                OracleConnection OracleCon = new OracleConnection(MyConnectionStr);
                OracleCon.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, OracleCon);
                DataTable dataTable = new DataTable();
                MyAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    StudentMainForm newForm = new StudentMainForm();
                    this.Hide();
                    newForm.Show();
                }
                else
                {
                    this.UserNameText.Clear();
                    this.PasswordText.Clear();
                    MessageBox.Show("Please Provide Correct \"UserName\" or \"Password\"", "Input Error!");
                }
                OracleCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(Admin_Login_Status)
            {
                AdminLogin();
            }
            else if(StudentLoginStatus)
            {
                StudentLogin();
            }
        }
        public static string StudentLoginID = "";
        private void AdminRadio_CheckedChanged(object sender, EventArgs e)
        {
            Admin_Login_Status = true;
            StudentLoginID = "";
        }

        private void StudentRadio_CheckedChanged(object sender, EventArgs e)
        {
            StudentLoginStatus = true;
            StudentLoginID = this.UserNameText.Text;
        }

        private void CloseLoginForm_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(this.PasswordShowCheck.Checked==true)
            {
                this.PasswordText.UseSystemPasswordChar = false;
            }
            else
            {
                this.PasswordText.UseSystemPasswordChar = true;
            }
        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            StudentLoginID = UserNameText.Text;
        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

      
    }
}
