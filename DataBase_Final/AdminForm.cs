using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Final
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            MainMenu_pnl.FillColor = Color.FromArgb(20, 46, 67);
            MainMenu_pnl.FillColor2 = Color.FromArgb(20, 46, 67);
            HideSubMenu();

        }

  
        private void HideSubMenu()
        {
            UserControl_SubMenu_pnl.Visible = false;
            Request_subMenu_pnl.Visible = false;
            Maintainance_subMenu_pnl.Visible = false;
            Expense_subMenu_pnl.Visible = false;
        }
        private void ShowsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false ;
            }
        }
        private void UserControl_btn_Click(object sender, EventArgs e)
        {
            ShowsubMenu(UserControl_SubMenu_pnl);
        }
        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new AddUser());

            HideSubMenu();
        }
        private void UpdateUser_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateUser());
            //code


            HideSubMenu();
        }
        private void DeleteUser_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DeleteUser());
            //code


            HideSubMenu();
        }
        private void RequestControl_btn_Click(object sender, EventArgs e)
        {
            ShowsubMenu(Request_subMenu_pnl);
        }

        private void GymRequest_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new AdminViewGymRequet());

            HideSubMenu();
        }
        private void Maintainance_btn_Click(object sender, EventArgs e)
        {
            ShowsubMenu(Maintainance_subMenu_pnl);
        }
        private void Viewmaintainance_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new MaintainanceViewform());

            HideSubMenu();
        }
        private void Addmaintainance_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new MaintainanceInsertform());

            HideSubMenu();
        }

        private void RoomShiftRequest_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new AdminViewRoomShift());

            HideSubMenu();
        }

        private void AttandanceRequest_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AdminAttandancerequest());
            //code


            HideSubMenu();
        }

        private void Bill_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Bills());
            HideSubMenu();
        }
        private void Expense_btn_Click(object sender, EventArgs e)
        {
            ShowsubMenu(Expense_subMenu_pnl);
        }
        private void ViewExpense_btn_Click(object sender, EventArgs e)
        {
            //code
            openChildFormInPanel(new Expenseform());
            HideSubMenu();
        }

        private void AddExpense_btn_Click(object sender, EventArgs e)
        {
            
            openChildFormInPanel(new ExpenseInsertForm());

            HideSubMenu();
        }

        private void GYM_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GYMform());
            HideSubMenu();

        }
        private void Visitor_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddVisitor());
            HideSubMenu();
        }

     
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
          //  if (activeForm != null)
            //    activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormHolder_pnl.Controls.Add(childForm);
            ChildFormHolder_pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseAdminForm_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreen Newform = new SplashScreen();
            Newform.Show();
        }

        
    }
}
