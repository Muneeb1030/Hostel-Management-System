
namespace DataBase_Final
{
    partial class StudentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.StudentFormEllipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RequestControl_btn = new Guna.UI2.WinForms.Guna2Button();
            this.AttandanceRequest_btn = new Guna.UI2.WinForms.Guna2Button();
            this.RoomShiftRequest_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Dues_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Request_subMenu_pnl = new System.Windows.Forms.Panel();
            this.CloseAdminForm = new Guna.UI2.WinForms.Guna2CircleButton();
            this.VisitorView_btn = new Guna.UI2.WinForms.Guna2Button();
            this.GYMRecord_btn = new Guna.UI2.WinForms.Guna2Button();
            this.MainMenu_pnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Logout = new Guna.UI2.WinForms.Guna2Button();
            this.STDPersonalInfo_btn = new Guna.UI2.WinForms.Guna2Button();
            this.TopAdminBar_pnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ChildFormHolder_pnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PersonalInfo_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HostelNo_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Email_label = new System.Windows.Forms.Label();
            this.SEmail_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CNIC_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.SCNIC_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SPhone_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomType_label = new System.Windows.Forms.Label();
            this.SRoomType_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomNo_label = new System.Windows.Forms.Label();
            this.SRoom_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.U_ID_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.SID_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SName_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Request_subMenu_pnl.SuspendLayout();
            this.MainMenu_pnl.SuspendLayout();
            this.TopAdminBar_pnl.SuspendLayout();
            this.ChildFormHolder_pnl.SuspendLayout();
            this.PersonalInfo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentFormEllipse
            // 
            this.StudentFormEllipse.BorderRadius = 10;
            this.StudentFormEllipse.TargetControl = this;
            // 
            // RequestControl_btn
            // 
            this.RequestControl_btn.Animated = true;
            this.RequestControl_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RequestControl_btn.BorderColor = System.Drawing.Color.White;
            this.RequestControl_btn.CheckedState.Parent = this.RequestControl_btn;
            this.RequestControl_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestControl_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.RequestControl_btn.CustomImages.Parent = this.RequestControl_btn;
            this.RequestControl_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestControl_btn.FillColor = System.Drawing.Color.Empty;
            this.RequestControl_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestControl_btn.ForeColor = System.Drawing.Color.White;
            this.RequestControl_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RequestControl_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.RequestControl_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RequestControl_btn.HoverState.Parent = this.RequestControl_btn;
            this.RequestControl_btn.Image = ((System.Drawing.Image)(resources.GetObject("RequestControl_btn.Image")));
            this.RequestControl_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RequestControl_btn.Location = new System.Drawing.Point(0, 55);
            this.RequestControl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.RequestControl_btn.Name = "RequestControl_btn";
            this.RequestControl_btn.ShadowDecoration.Parent = this.RequestControl_btn;
            this.RequestControl_btn.Size = new System.Drawing.Size(300, 55);
            this.RequestControl_btn.TabIndex = 3;
            this.RequestControl_btn.Text = "Requests";
            this.RequestControl_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RequestControl_btn.Click += new System.EventHandler(this.RequestControl_btn_Click);
            // 
            // AttandanceRequest_btn
            // 
            this.AttandanceRequest_btn.Animated = true;
            this.AttandanceRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.AttandanceRequest_btn.BorderColor = System.Drawing.Color.White;
            this.AttandanceRequest_btn.CheckedState.Parent = this.AttandanceRequest_btn;
            this.AttandanceRequest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttandanceRequest_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.AttandanceRequest_btn.CustomImages.Parent = this.AttandanceRequest_btn;
            this.AttandanceRequest_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttandanceRequest_btn.FillColor = System.Drawing.Color.Empty;
            this.AttandanceRequest_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttandanceRequest_btn.ForeColor = System.Drawing.Color.White;
            this.AttandanceRequest_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.AttandanceRequest_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.AttandanceRequest_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.AttandanceRequest_btn.HoverState.Parent = this.AttandanceRequest_btn;
            this.AttandanceRequest_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AttandanceRequest_btn.Location = new System.Drawing.Point(0, 55);
            this.AttandanceRequest_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AttandanceRequest_btn.Name = "AttandanceRequest_btn";
            this.AttandanceRequest_btn.ShadowDecoration.Parent = this.AttandanceRequest_btn;
            this.AttandanceRequest_btn.Size = new System.Drawing.Size(300, 55);
            this.AttandanceRequest_btn.TabIndex = 3;
            this.AttandanceRequest_btn.Text = "Attandance";
            this.AttandanceRequest_btn.Click += new System.EventHandler(this.AttandanceRequest_btn_Click);
            // 
            // RoomShiftRequest_btn
            // 
            this.RoomShiftRequest_btn.Animated = true;
            this.RoomShiftRequest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RoomShiftRequest_btn.BorderColor = System.Drawing.Color.White;
            this.RoomShiftRequest_btn.CheckedState.Parent = this.RoomShiftRequest_btn;
            this.RoomShiftRequest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomShiftRequest_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.RoomShiftRequest_btn.CustomImages.Parent = this.RoomShiftRequest_btn;
            this.RoomShiftRequest_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomShiftRequest_btn.FillColor = System.Drawing.Color.Empty;
            this.RoomShiftRequest_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomShiftRequest_btn.ForeColor = System.Drawing.Color.White;
            this.RoomShiftRequest_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RoomShiftRequest_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.RoomShiftRequest_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RoomShiftRequest_btn.HoverState.Parent = this.RoomShiftRequest_btn;
            this.RoomShiftRequest_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RoomShiftRequest_btn.Location = new System.Drawing.Point(0, 0);
            this.RoomShiftRequest_btn.Margin = new System.Windows.Forms.Padding(4);
            this.RoomShiftRequest_btn.Name = "RoomShiftRequest_btn";
            this.RoomShiftRequest_btn.ShadowDecoration.Parent = this.RoomShiftRequest_btn;
            this.RoomShiftRequest_btn.Size = new System.Drawing.Size(300, 55);
            this.RoomShiftRequest_btn.TabIndex = 2;
            this.RoomShiftRequest_btn.Text = "Room Shift";
            this.RoomShiftRequest_btn.Click += new System.EventHandler(this.RoomShiftRequest_btn_Click);
            // 
            // Dues_btn
            // 
            this.Dues_btn.Animated = true;
            this.Dues_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Dues_btn.BorderColor = System.Drawing.Color.White;
            this.Dues_btn.CheckedState.Parent = this.Dues_btn;
            this.Dues_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dues_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Dues_btn.CustomImages.Parent = this.Dues_btn;
            this.Dues_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dues_btn.FillColor = System.Drawing.Color.Empty;
            this.Dues_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dues_btn.ForeColor = System.Drawing.Color.White;
            this.Dues_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Dues_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.Dues_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Dues_btn.HoverState.Parent = this.Dues_btn;
            this.Dues_btn.Image = ((System.Drawing.Image)(resources.GetObject("Dues_btn.Image")));
            this.Dues_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dues_btn.Location = new System.Drawing.Point(0, 220);
            this.Dues_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Dues_btn.Name = "Dues_btn";
            this.Dues_btn.ShadowDecoration.Parent = this.Dues_btn;
            this.Dues_btn.Size = new System.Drawing.Size(300, 55);
            this.Dues_btn.TabIndex = 5;
            this.Dues_btn.Text = "Bills";
            this.Dues_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dues_btn.Click += new System.EventHandler(this.Dues_btn_Click);
            // 
            // Request_subMenu_pnl
            // 
            this.Request_subMenu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Request_subMenu_pnl.Controls.Add(this.AttandanceRequest_btn);
            this.Request_subMenu_pnl.Controls.Add(this.RoomShiftRequest_btn);
            this.Request_subMenu_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Request_subMenu_pnl.Location = new System.Drawing.Point(0, 110);
            this.Request_subMenu_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.Request_subMenu_pnl.Name = "Request_subMenu_pnl";
            this.Request_subMenu_pnl.Size = new System.Drawing.Size(300, 110);
            this.Request_subMenu_pnl.TabIndex = 4;
            // 
            // CloseAdminForm
            // 
            this.CloseAdminForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAdminForm.Animated = true;
            this.CloseAdminForm.BorderColor = System.Drawing.Color.Empty;
            this.CloseAdminForm.BorderThickness = 1;
            this.CloseAdminForm.CheckedState.Parent = this.CloseAdminForm;
            this.CloseAdminForm.CustomImages.Parent = this.CloseAdminForm;
            this.CloseAdminForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.CloseAdminForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CloseAdminForm.ForeColor = System.Drawing.Color.White;
            this.CloseAdminForm.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseAdminForm.HoverState.ForeColor = System.Drawing.Color.White;
            this.CloseAdminForm.HoverState.Parent = this.CloseAdminForm;
            this.CloseAdminForm.IndicateFocus = true;
            this.CloseAdminForm.Location = new System.Drawing.Point(1077, 6);
            this.CloseAdminForm.Margin = new System.Windows.Forms.Padding(4);
            this.CloseAdminForm.Name = "CloseAdminForm";
            this.CloseAdminForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseAdminForm.ShadowDecoration.Parent = this.CloseAdminForm;
            this.CloseAdminForm.Size = new System.Drawing.Size(27, 25);
            this.CloseAdminForm.TabIndex = 3;
            this.CloseAdminForm.Text = "x";
            this.CloseAdminForm.Click += new System.EventHandler(this.CloseAdminForm_Click);
            // 
            // VisitorView_btn
            // 
            this.VisitorView_btn.Animated = true;
            this.VisitorView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.VisitorView_btn.BorderColor = System.Drawing.Color.White;
            this.VisitorView_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.VisitorView_btn.CheckedState.Parent = this.VisitorView_btn;
            this.VisitorView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitorView_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.VisitorView_btn.CustomImages.Parent = this.VisitorView_btn;
            this.VisitorView_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VisitorView_btn.FillColor = System.Drawing.Color.Empty;
            this.VisitorView_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorView_btn.ForeColor = System.Drawing.Color.White;
            this.VisitorView_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.VisitorView_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.VisitorView_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.VisitorView_btn.HoverState.Parent = this.VisitorView_btn;
            this.VisitorView_btn.Image = ((System.Drawing.Image)(resources.GetObject("VisitorView_btn.Image")));
            this.VisitorView_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VisitorView_btn.Location = new System.Drawing.Point(0, 330);
            this.VisitorView_btn.Margin = new System.Windows.Forms.Padding(4);
            this.VisitorView_btn.Name = "VisitorView_btn";
            this.VisitorView_btn.ShadowDecoration.Parent = this.VisitorView_btn;
            this.VisitorView_btn.Size = new System.Drawing.Size(300, 55);
            this.VisitorView_btn.TabIndex = 13;
            this.VisitorView_btn.Text = "Visitor";
            this.VisitorView_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VisitorView_btn.Click += new System.EventHandler(this.VisitorView_btn_Click);
            // 
            // GYMRecord_btn
            // 
            this.GYMRecord_btn.Animated = true;
            this.GYMRecord_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.GYMRecord_btn.BorderColor = System.Drawing.Color.White;
            this.GYMRecord_btn.CheckedState.Parent = this.GYMRecord_btn;
            this.GYMRecord_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GYMRecord_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.GYMRecord_btn.CustomImages.Parent = this.GYMRecord_btn;
            this.GYMRecord_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GYMRecord_btn.FillColor = System.Drawing.Color.Empty;
            this.GYMRecord_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GYMRecord_btn.ForeColor = System.Drawing.Color.White;
            this.GYMRecord_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.GYMRecord_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.GYMRecord_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.GYMRecord_btn.HoverState.Parent = this.GYMRecord_btn;
            this.GYMRecord_btn.Image = ((System.Drawing.Image)(resources.GetObject("GYMRecord_btn.Image")));
            this.GYMRecord_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GYMRecord_btn.Location = new System.Drawing.Point(0, 275);
            this.GYMRecord_btn.Margin = new System.Windows.Forms.Padding(4);
            this.GYMRecord_btn.Name = "GYMRecord_btn";
            this.GYMRecord_btn.ShadowDecoration.Parent = this.GYMRecord_btn;
            this.GYMRecord_btn.Size = new System.Drawing.Size(300, 55);
            this.GYMRecord_btn.TabIndex = 11;
            this.GYMRecord_btn.Text = "GYM";
            this.GYMRecord_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GYMRecord_btn.Click += new System.EventHandler(this.GYMRecord_btn_Click);
            // 
            // MainMenu_pnl
            // 
            this.MainMenu_pnl.AutoScroll = true;
            this.MainMenu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.MainMenu_pnl.BorderColor = System.Drawing.Color.White;
            this.MainMenu_pnl.Controls.Add(this.Logout);
            this.MainMenu_pnl.Controls.Add(this.VisitorView_btn);
            this.MainMenu_pnl.Controls.Add(this.GYMRecord_btn);
            this.MainMenu_pnl.Controls.Add(this.Dues_btn);
            this.MainMenu_pnl.Controls.Add(this.Request_subMenu_pnl);
            this.MainMenu_pnl.Controls.Add(this.RequestControl_btn);
            this.MainMenu_pnl.Controls.Add(this.STDPersonalInfo_btn);
            this.MainMenu_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenu_pnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.MainMenu_pnl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.MainMenu_pnl.ForeColor = System.Drawing.Color.White;
            this.MainMenu_pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.MainMenu_pnl.Location = new System.Drawing.Point(0, 53);
            this.MainMenu_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.MainMenu_pnl.Name = "MainMenu_pnl";
            this.MainMenu_pnl.ShadowDecoration.Parent = this.MainMenu_pnl;
            this.MainMenu_pnl.Size = new System.Drawing.Size(300, 576);
            this.MainMenu_pnl.TabIndex = 5;
            // 
            // Logout
            // 
            this.Logout.Animated = true;
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Logout.BorderColor = System.Drawing.Color.White;
            this.Logout.CheckedState.FillColor = System.Drawing.Color.White;
            this.Logout.CheckedState.Parent = this.Logout;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Logout.CustomImages.Parent = this.Logout;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.FillColor = System.Drawing.Color.Empty;
            this.Logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.HoverState.FillColor = System.Drawing.Color.White;
            this.Logout.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Logout.HoverState.Parent = this.Logout;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Logout.Location = new System.Drawing.Point(0, 521);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.ShadowDecoration.Parent = this.Logout;
            this.Logout.Size = new System.Drawing.Size(300, 55);
            this.Logout.TabIndex = 14;
            this.Logout.Text = "Log out";
            this.Logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // STDPersonalInfo_btn
            // 
            this.STDPersonalInfo_btn.Animated = true;
            this.STDPersonalInfo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.STDPersonalInfo_btn.BorderColor = System.Drawing.Color.White;
            this.STDPersonalInfo_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.STDPersonalInfo_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.STDPersonalInfo_btn.CheckedState.Parent = this.STDPersonalInfo_btn;
            this.STDPersonalInfo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STDPersonalInfo_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.STDPersonalInfo_btn.CustomImages.Parent = this.STDPersonalInfo_btn;
            this.STDPersonalInfo_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.STDPersonalInfo_btn.FillColor = System.Drawing.Color.Empty;
            this.STDPersonalInfo_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STDPersonalInfo_btn.ForeColor = System.Drawing.Color.White;
            this.STDPersonalInfo_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.STDPersonalInfo_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.STDPersonalInfo_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.STDPersonalInfo_btn.HoverState.Parent = this.STDPersonalInfo_btn;
            this.STDPersonalInfo_btn.Image = ((System.Drawing.Image)(resources.GetObject("STDPersonalInfo_btn.Image")));
            this.STDPersonalInfo_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.STDPersonalInfo_btn.Location = new System.Drawing.Point(0, 0);
            this.STDPersonalInfo_btn.Margin = new System.Windows.Forms.Padding(4);
            this.STDPersonalInfo_btn.Name = "STDPersonalInfo_btn";
            this.STDPersonalInfo_btn.ShadowDecoration.Parent = this.STDPersonalInfo_btn;
            this.STDPersonalInfo_btn.Size = new System.Drawing.Size(300, 55);
            this.STDPersonalInfo_btn.TabIndex = 1;
            this.STDPersonalInfo_btn.Text = "Home";
            this.STDPersonalInfo_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.STDPersonalInfo_btn.Click += new System.EventHandler(this.STDPersonalInfo_btn_Click);
            // 
            // TopAdminBar_pnl
            // 
            this.TopAdminBar_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.TopAdminBar_pnl.Controls.Add(this.CloseAdminForm);
            this.TopAdminBar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopAdminBar_pnl.Location = new System.Drawing.Point(0, 0);
            this.TopAdminBar_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.TopAdminBar_pnl.Name = "TopAdminBar_pnl";
            this.TopAdminBar_pnl.ShadowDecoration.Parent = this.TopAdminBar_pnl;
            this.TopAdminBar_pnl.Size = new System.Drawing.Size(1112, 53);
            this.TopAdminBar_pnl.TabIndex = 6;
            // 
            // ChildFormHolder_pnl
            // 
            this.ChildFormHolder_pnl.BackColor = System.Drawing.Color.White;
            this.ChildFormHolder_pnl.Controls.Add(this.PersonalInfo_pnl);
            this.ChildFormHolder_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormHolder_pnl.Location = new System.Drawing.Point(300, 53);
            this.ChildFormHolder_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.ChildFormHolder_pnl.Name = "ChildFormHolder_pnl";
            this.ChildFormHolder_pnl.ShadowDecoration.Parent = this.ChildFormHolder_pnl;
            this.ChildFormHolder_pnl.Size = new System.Drawing.Size(812, 576);
            this.ChildFormHolder_pnl.TabIndex = 7;
            // 
            // PersonalInfo_pnl
            // 
            this.PersonalInfo_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.PersonalInfo_pnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PersonalInfo_pnl.BorderRadius = 7;
            this.PersonalInfo_pnl.BorderThickness = 4;
            this.PersonalInfo_pnl.Controls.Add(this.label2);
            this.PersonalInfo_pnl.Controls.Add(this.HostelNo_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.guna2VSeparator2);
            this.PersonalInfo_pnl.Controls.Add(this.guna2VSeparator1);
            this.PersonalInfo_pnl.Controls.Add(this.Return_btn);
            this.PersonalInfo_pnl.Controls.Add(this.Email_label);
            this.PersonalInfo_pnl.Controls.Add(this.SEmail_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.CNIC_label);
            this.PersonalInfo_pnl.Controls.Add(this.Phone_label);
            this.PersonalInfo_pnl.Controls.Add(this.SCNIC_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.SPhone_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.RoomType_label);
            this.PersonalInfo_pnl.Controls.Add(this.SRoomType_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.RoomNo_label);
            this.PersonalInfo_pnl.Controls.Add(this.SRoom_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.U_ID_label);
            this.PersonalInfo_pnl.Controls.Add(this.Name_label);
            this.PersonalInfo_pnl.Controls.Add(this.SID_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.SName_txtbox);
            this.PersonalInfo_pnl.Location = new System.Drawing.Point(4, 4);
            this.PersonalInfo_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalInfo_pnl.Name = "PersonalInfo_pnl";
            this.PersonalInfo_pnl.ShadowDecoration.Parent = this.PersonalInfo_pnl;
            this.PersonalInfo_pnl.Size = new System.Drawing.Size(796, 565);
            this.PersonalInfo_pnl.TabIndex = 1;
            this.PersonalInfo_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.PersonalInfo_pnl_Paint_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(556, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 117;
            this.label2.Text = "Hostel ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HostelNo_txtbox
            // 
            this.HostelNo_txtbox.Animated = true;
            this.HostelNo_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.HostelNo_txtbox.BorderThickness = 3;
            this.HostelNo_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HostelNo_txtbox.DefaultText = "";
            this.HostelNo_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.HostelNo_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.HostelNo_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.HostelNo_txtbox.DisabledState.Parent = this.HostelNo_txtbox;
            this.HostelNo_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.HostelNo_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.HostelNo_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.HostelNo_txtbox.FocusedState.Parent = this.HostelNo_txtbox;
            this.HostelNo_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.HostelNo_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.HostelNo_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.HostelNo_txtbox.HoverState.Parent = this.HostelNo_txtbox;
            this.HostelNo_txtbox.Location = new System.Drawing.Point(560, 256);
            this.HostelNo_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelNo_txtbox.Name = "HostelNo_txtbox";
            this.HostelNo_txtbox.PasswordChar = '\0';
            this.HostelNo_txtbox.PlaceholderForeColor = System.Drawing.Color.Purple;
            this.HostelNo_txtbox.PlaceholderText = "";
            this.HostelNo_txtbox.ReadOnly = true;
            this.HostelNo_txtbox.SelectedText = "";
            this.HostelNo_txtbox.ShadowDecoration.Parent = this.HostelNo_txtbox;
            this.HostelNo_txtbox.Size = new System.Drawing.Size(201, 52);
            this.HostelNo_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.HostelNo_txtbox.TabIndex = 116;
            this.HostelNo_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.guna2VSeparator2.FillThickness = 7;
            this.guna2VSeparator2.Location = new System.Drawing.Point(259, 343);
            this.guna2VSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(13, 199);
            this.guna2VSeparator2.TabIndex = 113;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.guna2VSeparator1.FillThickness = 7;
            this.guna2VSeparator1.Location = new System.Drawing.Point(527, 31);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(13, 308);
            this.guna2VSeparator1.TabIndex = 112;
            // 
            // Return_btn
            // 
            this.Return_btn.Animated = true;
            this.Return_btn.BackColor = System.Drawing.Color.Transparent;
            this.Return_btn.CheckedState.Parent = this.Return_btn;
            this.Return_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_btn.CustomImages.Parent = this.Return_btn;
            this.Return_btn.FillColor = System.Drawing.Color.Empty;
            this.Return_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Return_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Return_btn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Return_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.Return_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Return_btn.HoverState.Parent = this.Return_btn;
            this.Return_btn.Location = new System.Drawing.Point(13, 12);
            this.Return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Return_btn.ShadowDecoration.Parent = this.Return_btn;
            this.Return_btn.Size = new System.Drawing.Size(40, 37);
            this.Return_btn.TabIndex = 109;
            this.Return_btn.Text = "X";
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click_1);
            // 
            // Email_label
            // 
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Email_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Email_label.Location = new System.Drawing.Point(275, 367);
            this.Email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(164, 28);
            this.Email_label.TabIndex = 105;
            this.Email_label.Text = "Email";
            this.Email_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SEmail_txtbox
            // 
            this.SEmail_txtbox.Animated = true;
            this.SEmail_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.BorderThickness = 3;
            this.SEmail_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SEmail_txtbox.DefaultText = "";
            this.SEmail_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SEmail_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SEmail_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SEmail_txtbox.DisabledState.Parent = this.SEmail_txtbox;
            this.SEmail_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SEmail_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.FocusedState.Parent = this.SEmail_txtbox;
            this.SEmail_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SEmail_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.HoverState.Parent = this.SEmail_txtbox;
            this.SEmail_txtbox.Location = new System.Drawing.Point(451, 356);
            this.SEmail_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SEmail_txtbox.Name = "SEmail_txtbox";
            this.SEmail_txtbox.PasswordChar = '\0';
            this.SEmail_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SEmail_txtbox.PlaceholderText = "";
            this.SEmail_txtbox.ReadOnly = true;
            this.SEmail_txtbox.SelectedText = "";
            this.SEmail_txtbox.ShadowDecoration.Parent = this.SEmail_txtbox;
            this.SEmail_txtbox.Size = new System.Drawing.Size(311, 50);
            this.SEmail_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SEmail_txtbox.TabIndex = 104;
            this.SEmail_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CNIC_label
            // 
            this.CNIC_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.CNIC_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CNIC_label.Location = new System.Drawing.Point(15, 203);
            this.CNIC_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CNIC_label.Name = "CNIC_label";
            this.CNIC_label.Size = new System.Drawing.Size(141, 28);
            this.CNIC_label.TabIndex = 102;
            this.CNIC_label.Text = "CNIC";
            this.CNIC_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Phone_label
            // 
            this.Phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Phone_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phone_label.Location = new System.Drawing.Point(15, 279);
            this.Phone_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(141, 28);
            this.Phone_label.TabIndex = 103;
            this.Phone_label.Text = "Phone";
            this.Phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SCNIC_txtbox
            // 
            this.SCNIC_txtbox.Animated = true;
            this.SCNIC_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.BorderThickness = 3;
            this.SCNIC_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SCNIC_txtbox.DefaultText = "";
            this.SCNIC_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SCNIC_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SCNIC_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SCNIC_txtbox.DisabledState.Parent = this.SCNIC_txtbox;
            this.SCNIC_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SCNIC_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.FocusedState.Parent = this.SCNIC_txtbox;
            this.SCNIC_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SCNIC_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.HoverState.Parent = this.SCNIC_txtbox;
            this.SCNIC_txtbox.Location = new System.Drawing.Point(168, 196);
            this.SCNIC_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SCNIC_txtbox.Name = "SCNIC_txtbox";
            this.SCNIC_txtbox.PasswordChar = '\0';
            this.SCNIC_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SCNIC_txtbox.PlaceholderText = "";
            this.SCNIC_txtbox.ReadOnly = true;
            this.SCNIC_txtbox.SelectedText = "";
            this.SCNIC_txtbox.ShadowDecoration.Parent = this.SCNIC_txtbox;
            this.SCNIC_txtbox.Size = new System.Drawing.Size(311, 50);
            this.SCNIC_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SCNIC_txtbox.TabIndex = 100;
            this.SCNIC_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPhone_txtbox
            // 
            this.SPhone_txtbox.Animated = true;
            this.SPhone_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.BorderThickness = 3;
            this.SPhone_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SPhone_txtbox.DefaultText = "";
            this.SPhone_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SPhone_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SPhone_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SPhone_txtbox.DisabledState.Parent = this.SPhone_txtbox;
            this.SPhone_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SPhone_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.FocusedState.Parent = this.SPhone_txtbox;
            this.SPhone_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SPhone_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.HoverState.Parent = this.SPhone_txtbox;
            this.SPhone_txtbox.Location = new System.Drawing.Point(168, 268);
            this.SPhone_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SPhone_txtbox.Name = "SPhone_txtbox";
            this.SPhone_txtbox.PasswordChar = '\0';
            this.SPhone_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SPhone_txtbox.PlaceholderText = "";
            this.SPhone_txtbox.ReadOnly = true;
            this.SPhone_txtbox.SelectedText = "";
            this.SPhone_txtbox.ShadowDecoration.Parent = this.SPhone_txtbox;
            this.SPhone_txtbox.Size = new System.Drawing.Size(311, 49);
            this.SPhone_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SPhone_txtbox.TabIndex = 101;
            this.SPhone_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomType_label
            // 
            this.RoomType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RoomType_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomType_label.Location = new System.Drawing.Point(280, 508);
            this.RoomType_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomType_label.Name = "RoomType_label";
            this.RoomType_label.Size = new System.Drawing.Size(159, 28);
            this.RoomType_label.TabIndex = 99;
            this.RoomType_label.Text = "Room Type";
            this.RoomType_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SRoomType_txtbox
            // 
            this.SRoomType_txtbox.Animated = true;
            this.SRoomType_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.BorderThickness = 3;
            this.SRoomType_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SRoomType_txtbox.DefaultText = "";
            this.SRoomType_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SRoomType_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SRoomType_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SRoomType_txtbox.DisabledState.Parent = this.SRoomType_txtbox;
            this.SRoomType_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SRoomType_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.FocusedState.Parent = this.SRoomType_txtbox;
            this.SRoomType_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SRoomType_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.HoverState.Parent = this.SRoomType_txtbox;
            this.SRoomType_txtbox.Location = new System.Drawing.Point(451, 490);
            this.SRoomType_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SRoomType_txtbox.Name = "SRoomType_txtbox";
            this.SRoomType_txtbox.PasswordChar = '\0';
            this.SRoomType_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoomType_txtbox.PlaceholderText = "";
            this.SRoomType_txtbox.ReadOnly = true;
            this.SRoomType_txtbox.SelectedText = "";
            this.SRoomType_txtbox.ShadowDecoration.Parent = this.SRoomType_txtbox;
            this.SRoomType_txtbox.Size = new System.Drawing.Size(311, 53);
            this.SRoomType_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SRoomType_txtbox.TabIndex = 98;
            this.SRoomType_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomNo_label
            // 
            this.RoomNo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RoomNo_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomNo_label.Location = new System.Drawing.Point(263, 432);
            this.RoomNo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomNo_label.Name = "RoomNo_label";
            this.RoomNo_label.Size = new System.Drawing.Size(176, 28);
            this.RoomNo_label.TabIndex = 97;
            this.RoomNo_label.Text = "Room No";
            this.RoomNo_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SRoom_txtbox
            // 
            this.SRoom_txtbox.Animated = true;
            this.SRoom_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.BorderThickness = 3;
            this.SRoom_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SRoom_txtbox.DefaultText = "";
            this.SRoom_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SRoom_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SRoom_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SRoom_txtbox.DisabledState.Parent = this.SRoom_txtbox;
            this.SRoom_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SRoom_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.FocusedState.Parent = this.SRoom_txtbox;
            this.SRoom_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SRoom_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.HoverState.Parent = this.SRoom_txtbox;
            this.SRoom_txtbox.Location = new System.Drawing.Point(451, 416);
            this.SRoom_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SRoom_txtbox.Name = "SRoom_txtbox";
            this.SRoom_txtbox.PasswordChar = '\0';
            this.SRoom_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SRoom_txtbox.PlaceholderText = "";
            this.SRoom_txtbox.ReadOnly = true;
            this.SRoom_txtbox.SelectedText = "";
            this.SRoom_txtbox.ShadowDecoration.Parent = this.SRoom_txtbox;
            this.SRoom_txtbox.Size = new System.Drawing.Size(311, 52);
            this.SRoom_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SRoom_txtbox.TabIndex = 96;
            this.SRoom_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // U_ID_label
            // 
            this.U_ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_ID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_ID_label.Location = new System.Drawing.Point(15, 64);
            this.U_ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.U_ID_label.Name = "U_ID_label";
            this.U_ID_label.Size = new System.Drawing.Size(141, 28);
            this.U_ID_label.TabIndex = 95;
            this.U_ID_label.Text = "ID";
            this.U_ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.U_ID_label.Click += new System.EventHandler(this.U_ID_label_Click);
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Name_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Name_label.Location = new System.Drawing.Point(15, 127);
            this.Name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(141, 28);
            this.Name_label.TabIndex = 94;
            this.Name_label.Text = "Name";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SID_txtbox
            // 
            this.SID_txtbox.Animated = true;
            this.SID_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.BorderThickness = 3;
            this.SID_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SID_txtbox.DefaultText = "";
            this.SID_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SID_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SID_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SID_txtbox.DisabledState.Parent = this.SID_txtbox;
            this.SID_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SID_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.FocusedState.Parent = this.SID_txtbox;
            this.SID_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SID_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.HoverState.Parent = this.SID_txtbox;
            this.SID_txtbox.Location = new System.Drawing.Point(168, 46);
            this.SID_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SID_txtbox.Name = "SID_txtbox";
            this.SID_txtbox.PasswordChar = '\0';
            this.SID_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SID_txtbox.PlaceholderText = "";
            this.SID_txtbox.ReadOnly = true;
            this.SID_txtbox.SelectedText = "";
            this.SID_txtbox.ShadowDecoration.Parent = this.SID_txtbox;
            this.SID_txtbox.Size = new System.Drawing.Size(311, 53);
            this.SID_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SID_txtbox.TabIndex = 92;
            this.SID_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SName_txtbox
            // 
            this.SName_txtbox.Animated = true;
            this.SName_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.BorderThickness = 3;
            this.SName_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SName_txtbox.DefaultText = "";
            this.SName_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.SName_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.SName_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.SName_txtbox.DisabledState.Parent = this.SName_txtbox;
            this.SName_txtbox.FillColor = System.Drawing.SystemColors.Control;
            this.SName_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.FocusedState.Parent = this.SName_txtbox;
            this.SName_txtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.SName_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.HoverState.Parent = this.SName_txtbox;
            this.SName_txtbox.Location = new System.Drawing.Point(168, 121);
            this.SName_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SName_txtbox.Name = "SName_txtbox";
            this.SName_txtbox.PasswordChar = '\0';
            this.SName_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.SName_txtbox.PlaceholderText = "";
            this.SName_txtbox.ReadOnly = true;
            this.SName_txtbox.SelectedText = "";
            this.SName_txtbox.ShadowDecoration.Parent = this.SName_txtbox;
            this.SName_txtbox.Size = new System.Drawing.Size(311, 53);
            this.SName_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SName_txtbox.TabIndex = 93;
            this.SName_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.ChildFormHolder_pnl);
            this.Controls.Add(this.MainMenu_pnl);
            this.Controls.Add(this.TopAdminBar_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainForm";
            this.Request_subMenu_pnl.ResumeLayout(false);
            this.MainMenu_pnl.ResumeLayout(false);
            this.TopAdminBar_pnl.ResumeLayout(false);
            this.ChildFormHolder_pnl.ResumeLayout(false);
            this.PersonalInfo_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse StudentFormEllipse;
        private Guna.UI2.WinForms.Guna2Button RequestControl_btn;
        private Guna.UI2.WinForms.Guna2Button AttandanceRequest_btn;
        private Guna.UI2.WinForms.Guna2Button RoomShiftRequest_btn;
        private Guna.UI2.WinForms.Guna2Button Dues_btn;
        private System.Windows.Forms.Panel Request_subMenu_pnl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseAdminForm;
        private Guna.UI2.WinForms.Guna2Button VisitorView_btn;
        private Guna.UI2.WinForms.Guna2Button GYMRecord_btn;
        private Guna.UI2.WinForms.Guna2GradientPanel MainMenu_pnl;
        private Guna.UI2.WinForms.Guna2Button STDPersonalInfo_btn;
        private Guna.UI2.WinForms.Guna2GradientPanel TopAdminBar_pnl;
        private Guna.UI2.WinForms.Guna2GradientPanel ChildFormHolder_pnl;
        private Guna.UI2.WinForms.Guna2Panel PersonalInfo_pnl;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
        private System.Windows.Forms.Label Email_label;
        private Guna.UI2.WinForms.Guna2TextBox SEmail_txtbox;
        private System.Windows.Forms.Label CNIC_label;
        private System.Windows.Forms.Label Phone_label;
        private Guna.UI2.WinForms.Guna2TextBox SCNIC_txtbox;
        private Guna.UI2.WinForms.Guna2TextBox SPhone_txtbox;
        private System.Windows.Forms.Label RoomType_label;
        private Guna.UI2.WinForms.Guna2TextBox SRoomType_txtbox;
        private System.Windows.Forms.Label RoomNo_label;
        private Guna.UI2.WinForms.Guna2TextBox SRoom_txtbox;
        private System.Windows.Forms.Label U_ID_label;
        private System.Windows.Forms.Label Name_label;
        private Guna.UI2.WinForms.Guna2TextBox SID_txtbox;
        private Guna.UI2.WinForms.Guna2TextBox SName_txtbox;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button Logout;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox HostelNo_txtbox;
    }
}