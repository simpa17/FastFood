namespace FastFood.forms
{
    partial class frmDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPickedTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartRevenue = new LiveCharts.WinForms.CartesianChart();
            this.panelVistor = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbVisitors = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelVistor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue by";
            // 
            // cbPickedTime
            // 
            this.cbPickedTime.BackColor = System.Drawing.Color.Transparent;
            this.cbPickedTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbPickedTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPickedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPickedTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPickedTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPickedTime.FocusedState.Parent = this.cbPickedTime;
            this.cbPickedTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPickedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPickedTime.HoverState.Parent = this.cbPickedTime;
            this.cbPickedTime.ItemHeight = 30;
            this.cbPickedTime.Items.AddRange(new object[] {
            "day",
            "month",
            "year"});
            this.cbPickedTime.ItemsAppearance.Parent = this.cbPickedTime;
            this.cbPickedTime.Location = new System.Drawing.Point(120, 0);
            this.cbPickedTime.Name = "cbPickedTime";
            this.cbPickedTime.ShadowDecoration.Parent = this.cbPickedTime;
            this.cbPickedTime.Size = new System.Drawing.Size(112, 36);
            this.cbPickedTime.TabIndex = 1;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Font = new System.Drawing.Font("Ubuntu Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartRevenue.Location = new System.Drawing.Point(69, 55);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(694, 340);
            this.chartRevenue.TabIndex = 2;
            this.chartRevenue.Text = "cartesianChart1";
            // 
            // panelVistor
            // 
            this.panelVistor.BackColor = System.Drawing.Color.Transparent;
            this.panelVistor.BorderColor = System.Drawing.Color.Firebrick;
            this.panelVistor.BorderRadius = 10;
            this.panelVistor.BorderThickness = 3;
            this.panelVistor.Controls.Add(this.lbVisitors);
            this.panelVistor.Controls.Add(this.guna2HtmlLabel1);
            this.panelVistor.CustomBorderColor = System.Drawing.Color.Gray;
            this.panelVistor.Location = new System.Drawing.Point(12, 401);
            this.panelVistor.Name = "panelVistor";
            this.panelVistor.ShadowDecoration.Parent = this.panelVistor;
            this.panelVistor.Size = new System.Drawing.Size(224, 117);
            this.panelVistor.TabIndex = 3;
            // 
            // lbVisitors
            // 
            this.lbVisitors.AutoSize = true;
            this.lbVisitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVisitors.Font = new System.Drawing.Font("Ubuntu Mono", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitors.Location = new System.Drawing.Point(0, 45);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbVisitors.Size = new System.Drawing.Size(124, 50);
            this.lbVisitors.TabIndex = 1;
            this.lbVisitors.Text = "250";
            this.lbVisitors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Ubuntu Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(224, 45);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Visitors\r\n";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 652);
            this.Controls.Add(this.panelVistor);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.cbPickedTime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.panelVistor.ResumeLayout(false);
            this.panelVistor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbPickedTime;
        private LiveCharts.WinForms.CartesianChart chartRevenue;
        private Guna.UI2.WinForms.Guna2GradientPanel panelVistor;
        private System.Windows.Forms.Label lbVisitors;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}