
namespace DataBase_Final
{
    partial class LeaveRequestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonalInfo_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.LeaveRequest_grid = new System.Windows.Forms.DataGridView();
            this.PassedRequestHistory_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.VHours_label = new System.Windows.Forms.Label();
            this.UReturnHour_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UReturn_label = new System.Windows.Forms.Label();
            this.LeaveRequest_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.LeaverID_label = new System.Windows.Forms.Label();
            this.U_ID_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RequestView_pnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.History_grid = new System.Windows.Forms.DataGridView();
            this.Back_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PersonalInfo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveRequest_grid)).BeginInit();
            this.RequestView_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalInfo_pnl
            // 
            this.PersonalInfo_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.PersonalInfo_pnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PersonalInfo_pnl.BorderRadius = 7;
            this.PersonalInfo_pnl.BorderThickness = 4;
            this.PersonalInfo_pnl.Controls.Add(this.LeaveRequest_grid);
            this.PersonalInfo_pnl.Controls.Add(this.PassedRequestHistory_btn);
            this.PersonalInfo_pnl.Controls.Add(this.VHours_label);
            this.PersonalInfo_pnl.Controls.Add(this.UReturnHour_txtbox);
            this.PersonalInfo_pnl.Controls.Add(this.UReturn_label);
            this.PersonalInfo_pnl.Controls.Add(this.LeaveRequest_btn);
            this.PersonalInfo_pnl.Controls.Add(this.Return_btn);
            this.PersonalInfo_pnl.Controls.Add(this.LeaverID_label);
            this.PersonalInfo_pnl.Controls.Add(this.U_ID_txtbox);
            this.PersonalInfo_pnl.Location = new System.Drawing.Point(8, 6);
            this.PersonalInfo_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalInfo_pnl.Name = "PersonalInfo_pnl";
            this.PersonalInfo_pnl.ShadowDecoration.Parent = this.PersonalInfo_pnl;
            this.PersonalInfo_pnl.Size = new System.Drawing.Size(796, 565);
            this.PersonalInfo_pnl.TabIndex = 3;
            // 
            // LeaveRequest_grid
            // 
            this.LeaveRequest_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeaveRequest_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.LeaveRequest_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaveRequest_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.LeaveRequest_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaveRequest_grid.DefaultCellStyle = dataGridViewCellStyle7;
            this.LeaveRequest_grid.Location = new System.Drawing.Point(12, 331);
            this.LeaveRequest_grid.Margin = new System.Windows.Forms.Padding(4);
            this.LeaveRequest_grid.Name = "LeaveRequest_grid";
            this.LeaveRequest_grid.ReadOnly = true;
            this.LeaveRequest_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.LeaveRequest_grid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.LeaveRequest_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LeaveRequest_grid.Size = new System.Drawing.Size(772, 222);
            this.LeaveRequest_grid.TabIndex = 141;
            // 
            // PassedRequestHistory_btn
            // 
            this.PassedRequestHistory_btn.Animated = true;
            this.PassedRequestHistory_btn.BackColor = System.Drawing.Color.Transparent;
            this.PassedRequestHistory_btn.BorderColor = System.Drawing.Color.White;
            this.PassedRequestHistory_btn.BorderRadius = 4;
            this.PassedRequestHistory_btn.BorderThickness = 2;
            this.PassedRequestHistory_btn.CheckedState.Parent = this.PassedRequestHistory_btn;
            this.PassedRequestHistory_btn.CustomImages.Parent = this.PassedRequestHistory_btn;
            this.PassedRequestHistory_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PassedRequestHistory_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PassedRequestHistory_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedRequestHistory_btn.ForeColor = System.Drawing.Color.White;
            this.PassedRequestHistory_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PassedRequestHistory_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.PassedRequestHistory_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.PassedRequestHistory_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.PassedRequestHistory_btn.HoverState.Parent = this.PassedRequestHistory_btn;
            this.PassedRequestHistory_btn.IndicateFocus = true;
            this.PassedRequestHistory_btn.Location = new System.Drawing.Point(557, 268);
            this.PassedRequestHistory_btn.Margin = new System.Windows.Forms.Padding(4);
            this.PassedRequestHistory_btn.Name = "PassedRequestHistory_btn";
            this.PassedRequestHistory_btn.ShadowDecoration.Parent = this.PassedRequestHistory_btn;
            this.PassedRequestHistory_btn.Size = new System.Drawing.Size(187, 55);
            this.PassedRequestHistory_btn.TabIndex = 138;
            this.PassedRequestHistory_btn.Text = "History";
            this.PassedRequestHistory_btn.UseTransparentBackground = true;
            this.PassedRequestHistory_btn.Click += new System.EventHandler(this.PassedRequestHistory_btn_Click);
            // 
            // VHours_label
            // 
            this.VHours_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VHours_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.VHours_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VHours_label.Location = new System.Drawing.Point(421, 201);
            this.VHours_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VHours_label.Name = "VHours_label";
            this.VHours_label.Size = new System.Drawing.Size(80, 28);
            this.VHours_label.TabIndex = 137;
            this.VHours_label.Text = "Hours";
            this.VHours_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UReturnHour_txtbox
            // 
            this.UReturnHour_txtbox.Animated = true;
            this.UReturnHour_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.BorderThickness = 3;
            this.UReturnHour_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UReturnHour_txtbox.DefaultText = "";
            this.UReturnHour_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UReturnHour_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UReturnHour_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UReturnHour_txtbox.DisabledState.Parent = this.UReturnHour_txtbox;
            this.UReturnHour_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UReturnHour_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.FocusedState.Parent = this.UReturnHour_txtbox;
            this.UReturnHour_txtbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UReturnHour_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.HoverState.Parent = this.UReturnHour_txtbox;
            this.UReturnHour_txtbox.Location = new System.Drawing.Point(251, 178);
            this.UReturnHour_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UReturnHour_txtbox.Name = "UReturnHour_txtbox";
            this.UReturnHour_txtbox.PasswordChar = '\0';
            this.UReturnHour_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturnHour_txtbox.PlaceholderText = "Hours";
            this.UReturnHour_txtbox.SelectedText = "";
            this.UReturnHour_txtbox.ShadowDecoration.Parent = this.UReturnHour_txtbox;
            this.UReturnHour_txtbox.Size = new System.Drawing.Size(144, 50);
            this.UReturnHour_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UReturnHour_txtbox.TabIndex = 136;
            this.UReturnHour_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UReturn_label
            // 
            this.UReturn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UReturn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.UReturn_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UReturn_label.Location = new System.Drawing.Point(77, 201);
            this.UReturn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UReturn_label.Name = "UReturn_label";
            this.UReturn_label.Size = new System.Drawing.Size(164, 28);
            this.UReturn_label.TabIndex = 135;
            this.UReturn_label.Text = "Return After";
            this.UReturn_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LeaveRequest_btn
            // 
            this.LeaveRequest_btn.Animated = true;
            this.LeaveRequest_btn.BackColor = System.Drawing.Color.Transparent;
            this.LeaveRequest_btn.BorderColor = System.Drawing.Color.White;
            this.LeaveRequest_btn.BorderRadius = 4;
            this.LeaveRequest_btn.BorderThickness = 2;
            this.LeaveRequest_btn.CheckedState.Parent = this.LeaveRequest_btn;
            this.LeaveRequest_btn.CustomImages.Parent = this.LeaveRequest_btn;
            this.LeaveRequest_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.LeaveRequest_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.LeaveRequest_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveRequest_btn.ForeColor = System.Drawing.Color.White;
            this.LeaveRequest_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.LeaveRequest_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.LeaveRequest_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.LeaveRequest_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.LeaveRequest_btn.HoverState.Parent = this.LeaveRequest_btn;
            this.LeaveRequest_btn.IndicateFocus = true;
            this.LeaveRequest_btn.Location = new System.Drawing.Point(73, 268);
            this.LeaveRequest_btn.Margin = new System.Windows.Forms.Padding(4);
            this.LeaveRequest_btn.Name = "LeaveRequest_btn";
            this.LeaveRequest_btn.ShadowDecoration.Parent = this.LeaveRequest_btn;
            this.LeaveRequest_btn.Size = new System.Drawing.Size(187, 55);
            this.LeaveRequest_btn.TabIndex = 113;
            this.LeaveRequest_btn.Text = "Send";
            this.LeaveRequest_btn.UseTransparentBackground = true;
            this.LeaveRequest_btn.Click += new System.EventHandler(this.LeaveRequest_btn_Click);
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
            this.Return_btn.Location = new System.Drawing.Point(11, 14);
            this.Return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Return_btn.ShadowDecoration.Parent = this.Return_btn;
            this.Return_btn.Size = new System.Drawing.Size(40, 37);
            this.Return_btn.TabIndex = 109;
            this.Return_btn.Text = "X";
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // LeaverID_label
            // 
            this.LeaverID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaverID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.LeaverID_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeaverID_label.Location = new System.Drawing.Point(68, 121);
            this.LeaverID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeaverID_label.Name = "LeaverID_label";
            this.LeaverID_label.Size = new System.Drawing.Size(88, 28);
            this.LeaverID_label.TabIndex = 95;
            this.LeaverID_label.Text = "ID";
            this.LeaverID_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // U_ID_txtbox
            // 
            this.U_ID_txtbox.Animated = true;
            this.U_ID_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.BorderThickness = 3;
            this.U_ID_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.U_ID_txtbox.DefaultText = "";
            this.U_ID_txtbox.DisabledState.BorderColor = System.Drawing.Color.Purple;
            this.U_ID_txtbox.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.U_ID_txtbox.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.U_ID_txtbox.DisabledState.Parent = this.U_ID_txtbox;
            this.U_ID_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.FocusedState.Parent = this.U_ID_txtbox;
            this.U_ID_txtbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.U_ID_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.U_ID_txtbox.HoverState.Parent = this.U_ID_txtbox;
            this.U_ID_txtbox.Location = new System.Drawing.Point(188, 96);
            this.U_ID_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.U_ID_txtbox.Name = "U_ID_txtbox";
            this.U_ID_txtbox.PasswordChar = '\0';
            this.U_ID_txtbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.U_ID_txtbox.PlaceholderText = "ID";
            this.U_ID_txtbox.ReadOnly = true;
            this.U_ID_txtbox.SelectedText = "";
            this.U_ID_txtbox.ShadowDecoration.Parent = this.U_ID_txtbox;
            this.U_ID_txtbox.Size = new System.Drawing.Size(311, 53);
            this.U_ID_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.U_ID_txtbox.TabIndex = 92;
            this.U_ID_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RequestView_pnl
            // 
            this.RequestView_pnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.RequestView_pnl.BorderRadius = 5;
            this.RequestView_pnl.BorderThickness = 4;
            this.RequestView_pnl.Controls.Add(this.History_grid);
            this.RequestView_pnl.Controls.Add(this.Back_btn);
            this.RequestView_pnl.Location = new System.Drawing.Point(8, 6);
            this.RequestView_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.RequestView_pnl.Name = "RequestView_pnl";
            this.RequestView_pnl.ShadowDecoration.Parent = this.RequestView_pnl;
            this.RequestView_pnl.Size = new System.Drawing.Size(796, 561);
            this.RequestView_pnl.TabIndex = 139;
            // 
            // History_grid
            // 
            this.History_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.History_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.History_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.History_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.History_grid.DefaultCellStyle = dataGridViewCellStyle9;
            this.History_grid.Location = new System.Drawing.Point(12, 68);
            this.History_grid.Margin = new System.Windows.Forms.Padding(4);
            this.History_grid.Name = "History_grid";
            this.History_grid.ReadOnly = true;
            this.History_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.History_grid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.History_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.History_grid.Size = new System.Drawing.Size(772, 480);
            this.History_grid.TabIndex = 141;
            // 
            // Back_btn
            // 
            this.Back_btn.Animated = true;
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.CheckedState.Parent = this.Back_btn;
            this.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_btn.CustomImages.Parent = this.Back_btn;
            this.Back_btn.FillColor = System.Drawing.Color.Empty;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.Back_btn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Back_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.Back_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Back_btn.HoverState.Parent = this.Back_btn;
            this.Back_btn.Location = new System.Drawing.Point(9, 16);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Back_btn.ShadowDecoration.Parent = this.Back_btn;
            this.Back_btn.Size = new System.Drawing.Size(40, 37);
            this.Back_btn.TabIndex = 110;
            this.Back_btn.Text = "X";
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // LeaveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 576);
            this.Controls.Add(this.RequestView_pnl);
            this.Controls.Add(this.PersonalInfo_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeaveRequestForm";
            this.Text = "LeaveRequestForm";
            this.PersonalInfo_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeaveRequest_grid)).EndInit();
            this.RequestView_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.History_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PersonalInfo_pnl;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
        private System.Windows.Forms.Label LeaverID_label;
        private Guna.UI2.WinForms.Guna2TextBox U_ID_txtbox;
        private Guna.UI2.WinForms.Guna2GradientButton LeaveRequest_btn;
        private System.Windows.Forms.Label VHours_label;
        private Guna.UI2.WinForms.Guna2TextBox UReturnHour_txtbox;
        private System.Windows.Forms.Label UReturn_label;
        private Guna.UI2.WinForms.Guna2GradientButton PassedRequestHistory_btn;
        private Guna.UI2.WinForms.Guna2GradientPanel RequestView_pnl;
        private Guna.UI2.WinForms.Guna2CircleButton Back_btn;
        private System.Windows.Forms.DataGridView History_grid;
        private System.Windows.Forms.DataGridView LeaveRequest_grid;
    }
}