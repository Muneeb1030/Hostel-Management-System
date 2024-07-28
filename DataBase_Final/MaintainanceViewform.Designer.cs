
namespace DataBase_Final
{
    partial class MaintainanceViewform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchMaintainance_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MaintainOption_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MaintainName_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Maintainance_grid = new System.Windows.Forms.DataGridView();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Maintainance_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMaintainance_btn
            // 
            this.SearchMaintainance_btn.Animated = true;
            this.SearchMaintainance_btn.BackColor = System.Drawing.Color.Transparent;
            this.SearchMaintainance_btn.BorderColor = System.Drawing.Color.White;
            this.SearchMaintainance_btn.BorderRadius = 4;
            this.SearchMaintainance_btn.BorderThickness = 2;
            this.SearchMaintainance_btn.CheckedState.Parent = this.SearchMaintainance_btn;
            this.SearchMaintainance_btn.CustomImages.Parent = this.SearchMaintainance_btn;
            this.SearchMaintainance_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchMaintainance_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchMaintainance_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMaintainance_btn.ForeColor = System.Drawing.Color.White;
            this.SearchMaintainance_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchMaintainance_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.SearchMaintainance_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.SearchMaintainance_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchMaintainance_btn.HoverState.Parent = this.SearchMaintainance_btn;
            this.SearchMaintainance_btn.IndicateFocus = true;
            this.SearchMaintainance_btn.Location = new System.Drawing.Point(316, 121);
            this.SearchMaintainance_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchMaintainance_btn.Name = "SearchMaintainance_btn";
            this.SearchMaintainance_btn.ShadowDecoration.Parent = this.SearchMaintainance_btn;
            this.SearchMaintainance_btn.Size = new System.Drawing.Size(187, 55);
            this.SearchMaintainance_btn.TabIndex = 46;
            this.SearchMaintainance_btn.Text = "Search";
            this.SearchMaintainance_btn.UseTransparentBackground = true;
            this.SearchMaintainance_btn.Click += new System.EventHandler(this.SearchMaintainance_btn_Click_1);
            // 
            // MaintainOption_combo
            // 
            this.MaintainOption_combo.Animated = true;
            this.MaintainOption_combo.BackColor = System.Drawing.Color.Transparent;
            this.MaintainOption_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.BorderRadius = 4;
            this.MaintainOption_combo.BorderThickness = 2;
            this.MaintainOption_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaintainOption_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MaintainOption_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaintainOption_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.FocusedState.Parent = this.MaintainOption_combo;
            this.MaintainOption_combo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaintainOption_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.HoverState.ForeColor = System.Drawing.Color.White;
            this.MaintainOption_combo.HoverState.Parent = this.MaintainOption_combo;
            this.MaintainOption_combo.ItemHeight = 30;
            this.MaintainOption_combo.Items.AddRange(new object[] {
            "Name",
            "Hostel"});
            this.MaintainOption_combo.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.ItemsAppearance.Parent = this.MaintainOption_combo;
            this.MaintainOption_combo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainOption_combo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.MaintainOption_combo.Location = new System.Drawing.Point(115, 59);
            this.MaintainOption_combo.Margin = new System.Windows.Forms.Padding(4);
            this.MaintainOption_combo.Name = "MaintainOption_combo";
            this.MaintainOption_combo.ShadowDecoration.Parent = this.MaintainOption_combo;
            this.MaintainOption_combo.Size = new System.Drawing.Size(200, 36);
            this.MaintainOption_combo.TabIndex = 49;
            this.MaintainOption_combo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaintainName_txtbox
            // 
            this.MaintainName_txtbox.Animated = true;
            this.MaintainName_txtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.BorderThickness = 3;
            this.MaintainName_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaintainName_txtbox.DefaultText = "";
            this.MaintainName_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaintainName_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaintainName_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaintainName_txtbox.DisabledState.Parent = this.MaintainName_txtbox;
            this.MaintainName_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaintainName_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.FocusedState.Parent = this.MaintainName_txtbox;
            this.MaintainName_txtbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MaintainName_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.HoverState.Parent = this.MaintainName_txtbox;
            this.MaintainName_txtbox.Location = new System.Drawing.Point(349, 50);
            this.MaintainName_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaintainName_txtbox.Name = "MaintainName_txtbox";
            this.MaintainName_txtbox.PasswordChar = '\0';
            this.MaintainName_txtbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.MaintainName_txtbox.PlaceholderText = "Type here to Search......";
            this.MaintainName_txtbox.SelectedText = "";
            this.MaintainName_txtbox.ShadowDecoration.Parent = this.MaintainName_txtbox;
            this.MaintainName_txtbox.Size = new System.Drawing.Size(349, 53);
            this.MaintainName_txtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MaintainName_txtbox.TabIndex = 44;
            this.MaintainName_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaintainName_txtbox.TextChanged += new System.EventHandler(this.MaintainName_txtbox_TextChanged);
            // 
            // Maintainance_grid
            // 
            this.Maintainance_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Maintainance_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Maintainance_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Maintainance_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.Maintainance_grid.Location = new System.Drawing.Point(20, 183);
            this.Maintainance_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Maintainance_grid.Name = "Maintainance_grid";
            this.Maintainance_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.Maintainance_grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Maintainance_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Maintainance_grid.Size = new System.Drawing.Size(772, 347);
            this.Maintainance_grid.TabIndex = 128;
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
            this.Return_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.Return_btn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Return_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.Return_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Return_btn.HoverState.Parent = this.Return_btn;
            this.Return_btn.Location = new System.Drawing.Point(13, 13);
            this.Return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Return_btn.ShadowDecoration.Parent = this.Return_btn;
            this.Return_btn.Size = new System.Drawing.Size(40, 37);
            this.Return_btn.TabIndex = 139;
            this.Return_btn.Text = "X";
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // MaintainanceViewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 546);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Maintainance_grid);
            this.Controls.Add(this.MaintainOption_combo);
            this.Controls.Add(this.SearchMaintainance_btn);
            this.Controls.Add(this.MaintainName_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintainanceViewform";
            this.Text = "MaintainanceViewform";
            ((System.ComponentModel.ISupportInitialize)(this.Maintainance_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton SearchMaintainance_btn;
        private Guna.UI2.WinForms.Guna2ComboBox MaintainOption_combo;
        private Guna.UI2.WinForms.Guna2TextBox MaintainName_txtbox;
        private System.Windows.Forms.DataGridView Maintainance_grid;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
    }
}