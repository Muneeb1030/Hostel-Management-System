
namespace DataBase_Final
{
    partial class AdminAttandancerequest
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
            this.ApproveLeave_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AttandanceRequest_grid = new System.Windows.Forms.DataGridView();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.AttandanceRequest_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveLeave_btn
            // 
            this.ApproveLeave_btn.Animated = true;
            this.ApproveLeave_btn.BackColor = System.Drawing.Color.Transparent;
            this.ApproveLeave_btn.BorderColor = System.Drawing.Color.White;
            this.ApproveLeave_btn.BorderRadius = 4;
            this.ApproveLeave_btn.BorderThickness = 2;
            this.ApproveLeave_btn.CheckedState.Parent = this.ApproveLeave_btn;
            this.ApproveLeave_btn.CustomImages.Parent = this.ApproveLeave_btn;
            this.ApproveLeave_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveLeave_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveLeave_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveLeave_btn.ForeColor = System.Drawing.Color.White;
            this.ApproveLeave_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveLeave_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.ApproveLeave_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.ApproveLeave_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveLeave_btn.HoverState.Parent = this.ApproveLeave_btn;
            this.ApproveLeave_btn.IndicateFocus = true;
            this.ApproveLeave_btn.Location = new System.Drawing.Point(605, 19);
            this.ApproveLeave_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveLeave_btn.Name = "ApproveLeave_btn";
            this.ApproveLeave_btn.ShadowDecoration.Parent = this.ApproveLeave_btn;
            this.ApproveLeave_btn.Size = new System.Drawing.Size(187, 55);
            this.ApproveLeave_btn.TabIndex = 134;
            this.ApproveLeave_btn.Text = "Approve";
            this.ApproveLeave_btn.UseTransparentBackground = true;
            this.ApproveLeave_btn.Click += new System.EventHandler(this.ApproveLeave_btn_Click);
            // 
            // AttandanceRequest_grid
            // 
            this.AttandanceRequest_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttandanceRequest_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.AttandanceRequest_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttandanceRequest_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttandanceRequest_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.AttandanceRequest_grid.Location = new System.Drawing.Point(20, 82);
            this.AttandanceRequest_grid.Margin = new System.Windows.Forms.Padding(4);
            this.AttandanceRequest_grid.Name = "AttandanceRequest_grid";
            this.AttandanceRequest_grid.ReadOnly = true;
            this.AttandanceRequest_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.AttandanceRequest_grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.AttandanceRequest_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttandanceRequest_grid.Size = new System.Drawing.Size(772, 444);
            this.AttandanceRequest_grid.TabIndex = 136;
            this.AttandanceRequest_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttandanceRequest_grid_CellContentClick_1);
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
            this.Return_btn.TabIndex = 143;
            this.Return_btn.Text = "X";
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // AdminAttandancerequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 546);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.AttandanceRequest_grid);
            this.Controls.Add(this.ApproveLeave_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminAttandancerequest";
            this.Text = "AdminAttandancerequest";
            ((System.ComponentModel.ISupportInitialize)(this.AttandanceRequest_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton ApproveLeave_btn;
        private System.Windows.Forms.DataGridView AttandanceRequest_grid;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
    }
}