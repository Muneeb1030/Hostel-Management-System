
namespace DataBase_Final
{
    partial class AdminViewGymRequet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ApproveGYM_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GymRequest_grid = new System.Windows.Forms.DataGridView();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GymRequest_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveGYM_btn
            // 
            this.ApproveGYM_btn.Animated = true;
            this.ApproveGYM_btn.BackColor = System.Drawing.Color.Transparent;
            this.ApproveGYM_btn.BorderColor = System.Drawing.Color.White;
            this.ApproveGYM_btn.BorderRadius = 4;
            this.ApproveGYM_btn.BorderThickness = 2;
            this.ApproveGYM_btn.CheckedState.Parent = this.ApproveGYM_btn;
            this.ApproveGYM_btn.CustomImages.Parent = this.ApproveGYM_btn;
            this.ApproveGYM_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveGYM_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveGYM_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveGYM_btn.ForeColor = System.Drawing.Color.White;
            this.ApproveGYM_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveGYM_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.ApproveGYM_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.ApproveGYM_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ApproveGYM_btn.HoverState.Parent = this.ApproveGYM_btn;
            this.ApproveGYM_btn.IndicateFocus = true;
            this.ApproveGYM_btn.Location = new System.Drawing.Point(605, 13);
            this.ApproveGYM_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveGYM_btn.Name = "ApproveGYM_btn";
            this.ApproveGYM_btn.ShadowDecoration.Parent = this.ApproveGYM_btn;
            this.ApproveGYM_btn.Size = new System.Drawing.Size(187, 55);
            this.ApproveGYM_btn.TabIndex = 134;
            this.ApproveGYM_btn.Text = "Approve";
            this.ApproveGYM_btn.UseTransparentBackground = true;
            this.ApproveGYM_btn.Click += new System.EventHandler(this.ApproveGYM_btn_Click);
            // 
            // GymRequest_grid
            // 
            this.GymRequest_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GymRequest_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GymRequest_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GymRequest_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GymRequest_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.GymRequest_grid.Location = new System.Drawing.Point(20, 87);
            this.GymRequest_grid.Margin = new System.Windows.Forms.Padding(4);
            this.GymRequest_grid.Name = "GymRequest_grid";
            this.GymRequest_grid.ReadOnly = true;
            this.GymRequest_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GymRequest_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GymRequest_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GymRequest_grid.Size = new System.Drawing.Size(772, 444);
            this.GymRequest_grid.TabIndex = 135;
            this.GymRequest_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GymRequest_grid_CellContentClick);
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
            // AdminViewGymRequet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 546);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.GymRequest_grid);
            this.Controls.Add(this.ApproveGYM_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminViewGymRequet";
            this.Text = "AdminViewGymRequet";
            ((System.ComponentModel.ISupportInitialize)(this.GymRequest_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton ApproveGYM_btn;
        private System.Windows.Forms.DataGridView GymRequest_grid;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
    }
}