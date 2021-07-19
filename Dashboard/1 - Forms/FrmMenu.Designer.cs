
namespace Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PanelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PanelMenuControl = new System.Windows.Forms.Panel();
            this.PanelReport = new System.Windows.Forms.Panel();
            this.BtnYearly = new System.Windows.Forms.Button();
            this.BtnMonthly = new System.Windows.Forms.Button();
            this.BtnWeekly = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelFomDashboard = new System.Windows.Forms.Panel();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.PanelControl.SuspendLayout();
            this.PanelMenuControl.SuspendLayout();
            this.PanelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelFomDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(74)))), ((int)(((byte)(200)))));
            this.PanelControl.Controls.Add(this.label1);
            this.PanelControl.Controls.Add(this.BtnMinimize);
            this.PanelControl.Controls.Add(this.BtnMaximize);
            this.PanelControl.Controls.Add(this.BtnExit);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(1075, 25);
            this.PanelControl.TabIndex = 0;
            this.PanelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseDown);
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            this.PanelControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackgroundImage = global::Dashboard.Properties.Resources.minus;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(952, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(37, 25);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackgroundImage = global::Dashboard.Properties.Resources.quadrado_com_cantos_arredondados;
            this.BtnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Location = new System.Drawing.Point(995, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(37, 25);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackgroundImage = global::Dashboard.Properties.Resources.delete;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(1038, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(37, 25);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelMenuControl
            // 
            this.PanelMenuControl.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelMenuControl.Controls.Add(this.PanelReport);
            this.PanelMenuControl.Controls.Add(this.BtnReport);
            this.PanelMenuControl.Controls.Add(this.BtnHome);
            this.PanelMenuControl.Controls.Add(this.panel1);
            this.PanelMenuControl.Controls.Add(this.pictureBox1);
            this.PanelMenuControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuControl.Location = new System.Drawing.Point(0, 25);
            this.PanelMenuControl.Name = "PanelMenuControl";
            this.PanelMenuControl.Size = new System.Drawing.Size(203, 672);
            this.PanelMenuControl.TabIndex = 1;
            // 
            // PanelReport
            // 
            this.PanelReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelReport.Controls.Add(this.BtnYearly);
            this.PanelReport.Controls.Add(this.BtnMonthly);
            this.PanelReport.Controls.Add(this.BtnWeekly);
            this.PanelReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelReport.Location = new System.Drawing.Point(0, 151);
            this.PanelReport.Name = "PanelReport";
            this.PanelReport.Size = new System.Drawing.Size(203, 154);
            this.PanelReport.TabIndex = 3;
            // 
            // BtnYearly
            // 
            this.BtnYearly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnYearly.FlatAppearance.BorderSize = 0;
            this.BtnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYearly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYearly.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnYearly.Location = new System.Drawing.Point(0, 100);
            this.BtnYearly.Name = "BtnYearly";
            this.BtnYearly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnYearly.Size = new System.Drawing.Size(203, 50);
            this.BtnYearly.TabIndex = 4;
            this.BtnYearly.Text = "Anual";
            this.BtnYearly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnYearly.UseVisualStyleBackColor = true;
            this.BtnYearly.Click += new System.EventHandler(this.BtnYearly_Click);
            // 
            // BtnMonthly
            // 
            this.BtnMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMonthly.FlatAppearance.BorderSize = 0;
            this.BtnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMonthly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonthly.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMonthly.Location = new System.Drawing.Point(0, 50);
            this.BtnMonthly.Name = "BtnMonthly";
            this.BtnMonthly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMonthly.Size = new System.Drawing.Size(203, 50);
            this.BtnMonthly.TabIndex = 3;
            this.BtnMonthly.Text = "Mensal";
            this.BtnMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMonthly.UseVisualStyleBackColor = true;
            this.BtnMonthly.Click += new System.EventHandler(this.BtnMonthly_Click);
            // 
            // BtnWeekly
            // 
            this.BtnWeekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWeekly.FlatAppearance.BorderSize = 0;
            this.BtnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWeekly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWeekly.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnWeekly.Location = new System.Drawing.Point(0, 0);
            this.BtnWeekly.Name = "BtnWeekly";
            this.BtnWeekly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnWeekly.Size = new System.Drawing.Size(203, 50);
            this.BtnWeekly.TabIndex = 5;
            this.BtnWeekly.Text = "Semanal";
            this.BtnWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnWeekly.UseVisualStyleBackColor = true;
            this.BtnWeekly.Click += new System.EventHandler(this.BtnWeekly_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnReport.Image = global::Dashboard.Properties.Resources.pie_chart;
            this.BtnReport.Location = new System.Drawing.Point(0, 101);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReport.Size = new System.Drawing.Size(203, 50);
            this.BtnReport.TabIndex = 2;
            this.BtnReport.Text = "Relatórios";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.Image = global::Dashboard.Properties.Resources.home;
            this.BtnHome.Location = new System.Drawing.Point(0, 51);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnHome.Size = new System.Drawing.Size(203, 50);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 1);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Finance;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelFomDashboard
            // 
            this.PanelFomDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFomDashboard.Controls.Add(this.PanelForms);
            this.PanelFomDashboard.Controls.Add(this.PanelMenuControl);
            this.PanelFomDashboard.Controls.Add(this.PanelControl);
            this.PanelFomDashboard.Location = new System.Drawing.Point(3, 2);
            this.PanelFomDashboard.Name = "PanelFomDashboard";
            this.PanelFomDashboard.Size = new System.Drawing.Size(1075, 697);
            this.PanelFomDashboard.TabIndex = 0;
            // 
            // PanelForms
            // 
            this.PanelForms.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForms.Location = new System.Drawing.Point(203, 25);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(872, 672);
            this.PanelForms.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.PanelFomDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            this.PanelMenuControl.ResumeLayout(false);
            this.PanelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelFomDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Panel PanelReport;
        private System.Windows.Forms.Button BtnYearly;
        private System.Windows.Forms.Button BtnMonthly;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnWeekly;
        private System.Windows.Forms.Panel PanelFomDashboard;
        private System.Windows.Forms.Panel PanelForms;
    }
}

