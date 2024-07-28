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
    public partial class StudentMainForm : Form
    {
       
        public StudentMainForm()
        {
            InitializeComponent();
            Request_subMenu_pnl.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormHolder_pnl.Controls.Add(childForm);
            ChildFormHolder_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void STDPersonalInfo_btn_Click(object sender, EventArgs e)
        {
            PersonalInfo_pnl.Visible = true;
            PersonalInfo_pnl.BringToFront();
            HideSubMenu();
        }

        private void CloseAdminForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideSubMenu()
        {
            Request_subMenu_pnl.Visible = false;
        }
        private void ShowsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void RequestControl_btn_Click(object sender, EventArgs e)
        {
            ShowsubMenu(Request_subMenu_pnl);

        }

        private void RoomShiftRequest_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new STDShiftRequestform());
            HideSubMenu();
        }

        private void AttandanceRequest_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new LeaveRequestForm());
            HideSubMenu();
        }

        private void Dues_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new STDBills());
            HideSubMenu();
        }

        private void GYMRecord_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new STDGYMViewform());
            HideSubMenu();
        }

        private void VisitorView_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new STDVisitorView());
            HideSubMenu();
        }


        private void Return_btn_Click(object sender, EventArgs e)
        {
            PersonalInfo_pnl.Visible = false;
        }
   

        private void Return_btn_Click_1(object sender, EventArgs e)
        {
            PersonalInfo_pnl.Visible = false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreen Newform = new SplashScreen();
            Newform.Show();
        }
        private void PersonalInfo_pnl_Paint_1(object sender, PaintEventArgs e)
        {
            string MyConnectionStr = Login.ConnectionStr();
            string Query = "SELECT STUDENT_ID,STDNAME,CNIC,CONTACT,email,STDROOMNO,ROOMTYPE,Hostel_ID FROM student  inner join student_details on student_id=STD_id inner join room on STDroomno = roomno WHERE  student_ID = '"+Login.StudentLoginID+"'";
            OracleConnection OracleCon = new OracleConnection(MyConnectionStr);
            OracleCon.Open();
            OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, OracleCon);
            DataTable dataTable = new DataTable();
            MyAdapter.Fill(dataTable);
            SID_txtbox.Text = dataTable.Rows[0]["STUDENT_ID"].ToString();
            SName_txtbox.Text = dataTable.Rows[0]["STDNAME"].ToString();
            SCNIC_txtbox.Text = dataTable.Rows[0]["CNIC"].ToString();
            SPhone_txtbox.Text = dataTable.Rows[0]["CONTACT"].ToString();
            SEmail_txtbox.Text = dataTable.Rows[0]["email"].ToString();
            SRoom_txtbox.Text = dataTable.Rows[0]["STDROOMNO"].ToString();
            SRoomType_txtbox.Text = dataTable.Rows[0]["ROOMTYPE"].ToString();
            HostelNo_txtbox.Text= dataTable.Rows[0]["Hostel_ID"].ToString();

        }
    }
}
