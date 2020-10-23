namespace FastFood.forms
{
    partial class frmProduct
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
            this.dtpkProductDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalExpend = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkProductDate
            // 
            this.dtpkProductDate.BorderRadius = 20;
            this.dtpkProductDate.CheckedState.Parent = this.dtpkProductDate;
            this.dtpkProductDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkProductDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.dtpkProductDate.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.dtpkProductDate.ForeColor = System.Drawing.Color.White;
            this.dtpkProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkProductDate.HoverState.Parent = this.dtpkProductDate;
            this.dtpkProductDate.Location = new System.Drawing.Point(308, 27);
            this.dtpkProductDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkProductDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkProductDate.Name = "dtpkProductDate";
            this.dtpkProductDate.ShadowDecoration.Parent = this.dtpkProductDate;
            this.dtpkProductDate.Size = new System.Drawing.Size(200, 36);
            this.dtpkProductDate.TabIndex = 0;
            this.dtpkProductDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkProductDate.Value = new System.DateTime(2020, 10, 23, 15, 16, 8, 416);
            // 
            // dtgvProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dtgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvProduct.EnableHeadersVisualStyles = false;
            this.dtgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dtgvProduct.Location = new System.Drawing.Point(12, 83);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersVisible = false;
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 24;
            this.dtgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduct.Size = new System.Drawing.Size(793, 571);
            this.dtgvProduct.TabIndex = 1;
            this.dtgvProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.dtgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dtgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dtgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.dtgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvProduct.ThemeStyle.ReadOnly = false;
            this.dtgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.dtgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.dtgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.lblTotalExpend);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.guna2Panel1.Location = new System.Drawing.Point(239, 675);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(339, 62);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(197, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Total Expenditure: ";
            // 
            // lblTotalExpend
            // 
            this.lblTotalExpend.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExpend.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpend.ForeColor = System.Drawing.Color.White;
            this.lblTotalExpend.Location = new System.Drawing.Point(246, 15);
            this.lblTotalExpend.Name = "lblTotalExpend";
            this.lblTotalExpend.Size = new System.Drawing.Size(54, 29);
            this.lblTotalExpend.TabIndex = 1;
            this.lblTotalExpend.Text = "Num";
            // 
            // frmProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(817, 753);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.dtpkProductDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkProductDate;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalExpend;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}