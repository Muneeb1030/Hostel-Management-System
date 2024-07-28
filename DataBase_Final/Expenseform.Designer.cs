
namespace DataBase_Final
{
    partial class Expenseform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchExpense_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ExpenseSearchType_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Expense_grid = new System.Windows.Forms.DataGridView();
            this.Return_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchExpense_btn
            // 
            this.SearchExpense_btn.Animated = true;
            this.SearchExpense_btn.BackColor = System.Drawing.Color.Transparent;
            this.SearchExpense_btn.BorderColor = System.Drawing.Color.White;
            this.SearchExpense_btn.BorderRadius = 4;
            this.SearchExpense_btn.BorderThickness = 2;
            this.SearchExpense_btn.CheckedState.Parent = this.SearchExpense_btn;
            this.SearchExpense_btn.CustomImages.Parent = this.SearchExpense_btn;
            this.SearchExpense_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchExpense_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchExpense_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchExpense_btn.ForeColor = System.Drawing.Color.White;
            this.SearchExpense_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchExpense_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.SearchExpense_btn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.SearchExpense_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.SearchExpense_btn.HoverState.Parent = this.SearchExpense_btn;
            this.SearchExpense_btn.IndicateFocus = true;
            this.SearchExpense_btn.Location = new System.Drawing.Point(413, 44);
            this.SearchExpense_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchExpense_btn.Name = "SearchExpense_btn";
            this.SearchExpense_btn.ShadowDecoration.Parent = this.SearchExpense_btn;
            this.SearchExpense_btn.Size = new System.Drawing.Size(181, 44);
            this.SearchExpense_btn.TabIndex = 41;
            this.SearchExpense_btn.Text = "Search";
            this.SearchExpense_btn.UseTransparentBackground = true;
            this.SearchExpense_btn.Click += new System.EventHandler(this.SearchExpense_btn_Click);
            // 
            // ExpenseSearchType_combo
            // 
            this.ExpenseSearchType_combo.Animated = true;
            this.ExpenseSearchType_combo.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseSearchType_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.BorderRadius = 4;
            this.ExpenseSearchType_combo.BorderThickness = 2;
            this.ExpenseSearchType_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpenseSearchType_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExpenseSearchType_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpenseSearchType_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.FocusedState.Parent = this.ExpenseSearchType_combo;
            this.ExpenseSearchType_combo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ExpenseSearchType_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.HoverState.BorderColor = System.Drawing.Color.White;
            this.ExpenseSearchType_combo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.HoverState.ForeColor = System.Drawing.Color.White;
            this.ExpenseSearchType_combo.HoverState.Parent = this.ExpenseSearchType_combo;
            this.ExpenseSearchType_combo.ItemHeight = 30;
            this.ExpenseSearchType_combo.Items.AddRange(new object[] {
            "Utilities",
            "Mess",
            "Salary",
            "Hostel 1",
            "Hostel 2"});
            this.ExpenseSearchType_combo.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.ItemsAppearance.Parent = this.ExpenseSearchType_combo;
            this.ExpenseSearchType_combo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.ExpenseSearchType_combo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.ExpenseSearchType_combo.Location = new System.Drawing.Point(139, 44);
            this.ExpenseSearchType_combo.Margin = new System.Windows.Forms.Padding(4);
            this.ExpenseSearchType_combo.Name = "ExpenseSearchType_combo";
            this.ExpenseSearchType_combo.ShadowDecoration.Parent = this.ExpenseSearchType_combo;
            this.ExpenseSearchType_combo.Size = new System.Drawing.Size(213, 36);
            this.ExpenseSearchType_combo.TabIndex = 126;
            this.ExpenseSearchType_combo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Expense_grid
            // 
            this.Expense_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Expense_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Expense_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Expense_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Expense_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Expense_grid.Location = new System.Drawing.Point(16, 111);
            this.Expense_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Expense_grid.Name = "Expense_grid";
            this.Expense_grid.ReadOnly = true;
            this.Expense_grid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.Expense_grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Expense_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Expense_grid.Size = new System.Drawing.Size(772, 421);
            this.Expense_grid.TabIndex = 127;
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
            this.Return_btn.Location = new System.Drawing.Point(16, 13);
            this.Return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Return_btn.ShadowDecoration.Parent = this.Return_btn;
            this.Return_btn.Size = new System.Drawing.Size(40, 37);
            this.Return_btn.TabIndex = 143;
            this.Return_btn.Text = "X";
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Expenseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 546);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Expense_grid);
            this.Controls.Add(this.ExpenseSearchType_combo);
            this.Controls.Add(this.SearchExpense_btn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Expenseform";
            this.Text = "Expenseform";
            ((System.ComponentModel.ISupportInitialize)(this.Expense_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton SearchExpense_btn;
        private Guna.UI2.WinForms.Guna2ComboBox ExpenseSearchType_combo;
        private System.Windows.Forms.DataGridView Expense_grid;
        private Guna.UI2.WinForms.Guna2CircleButton Return_btn;
    }
}