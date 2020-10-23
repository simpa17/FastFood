namespace FastFood.forms
{
    partial class frmTransaction
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalBill = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgvTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtpkTransactionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Total Bill: ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.lblTotalBill);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.guna2Panel1.Location = new System.Drawing.Point(301, 669);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(262, 62);
            this.guna2Panel1.TabIndex = 5;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.White;
            this.lblTotalBill.Location = new System.Drawing.Point(179, 15);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(54, 29);
            this.lblTotalBill.TabIndex = 1;
            this.lblTotalBill.Text = "Num";
            // 
            // dtgvTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dtgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTransaction.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTransaction.EnableHeadersVisualStyles = false;
            this.dtgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dtgvTransaction.Location = new System.Drawing.Point(12, 77);
            this.dtgvTransaction.Name = "dtgvTransaction";
            this.dtgvTransaction.RowHeadersVisible = false;
            this.dtgvTransaction.RowHeadersWidth = 51;
            this.dtgvTransaction.RowTemplate.Height = 24;
            this.dtgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTransaction.Size = new System.Drawing.Size(793, 571);
            this.dtgvTransaction.TabIndex = 4;
            this.dtgvTransaction.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.dtgvTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.dtgvTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTransaction.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.dtgvTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.dtgvTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvTransaction.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvTransaction.ThemeStyle.ReadOnly = false;
            this.dtgvTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.dtgvTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvTransaction.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.dtgvTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dtpkTransactionDate
            // 
            this.dtpkTransactionDate.BorderRadius = 20;
            this.dtpkTransactionDate.CheckedState.Parent = this.dtpkTransactionDate;
            this.dtpkTransactionDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkTransactionDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.dtpkTransactionDate.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.dtpkTransactionDate.ForeColor = System.Drawing.Color.White;
            this.dtpkTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTransactionDate.HoverState.Parent = this.dtpkTransactionDate;
            this.dtpkTransactionDate.Location = new System.Drawing.Point(308, 21);
            this.dtpkTransactionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkTransactionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkTransactionDate.Name = "dtpkTransactionDate";
            this.dtpkTransactionDate.ShadowDecoration.Parent = this.dtpkTransactionDate;
            this.dtpkTransactionDate.Size = new System.Drawing.Size(200, 36);
            this.dtpkTransactionDate.TabIndex = 3;
            this.dtpkTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkTransactionDate.Value = new System.DateTime(2020, 10, 23, 15, 16, 8, 416);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(817, 753);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtgvTransaction);
            this.Controls.Add(this.dtpkTransactionDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalBill;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvTransaction;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkTransactionDate;
    }
}