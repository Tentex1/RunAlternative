namespace RunAlternative
{
    partial class RA_About
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.about_btn_accept = new System.Windows.Forms.Button();
            this.about_lbl_developer = new System.Windows.Forms.Label();
            this.about_lbl_license = new System.Windows.Forms.Label();
            this.about_lbl_productname = new System.Windows.Forms.Label();
            this.about_lbl_version = new System.Windows.Forms.Label();
            this.about_tbox_description = new System.Windows.Forms.TextBox();
            this.about_lbl_description = new System.Windows.Forms.Label();
            this.about_lbl_about = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // about_btn_accept
            // 
            this.about_btn_accept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.about_btn_accept.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.about_btn_accept.FlatAppearance.BorderSize = 0;
            this.about_btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn_accept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_btn_accept.Location = new System.Drawing.Point(215, 176);
            this.about_btn_accept.Name = "about_btn_accept";
            this.about_btn_accept.Size = new System.Drawing.Size(75, 30);
            this.about_btn_accept.TabIndex = 0;
            this.about_btn_accept.Text = "Accept";
            this.about_btn_accept.UseVisualStyleBackColor = false;
            this.about_btn_accept.Click += new System.EventHandler(this.about_btn_accept_Click);
            // 
            // about_lbl_developer
            // 
            this.about_lbl_developer.AutoSize = true;
            this.about_lbl_developer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_developer.ForeColor = System.Drawing.Color.White;
            this.about_lbl_developer.Location = new System.Drawing.Point(12, 48);
            this.about_lbl_developer.Name = "about_lbl_developer";
            this.about_lbl_developer.Size = new System.Drawing.Size(117, 17);
            this.about_lbl_developer.TabIndex = 1;
            this.about_lbl_developer.Text = "Developer: Tentex";
            // 
            // about_lbl_license
            // 
            this.about_lbl_license.AutoSize = true;
            this.about_lbl_license.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_license.ForeColor = System.Drawing.Color.White;
            this.about_lbl_license.Location = new System.Drawing.Point(12, 68);
            this.about_lbl_license.Name = "about_lbl_license";
            this.about_lbl_license.Size = new System.Drawing.Size(81, 17);
            this.about_lbl_license.TabIndex = 2;
            this.about_lbl_license.Text = "License: MIT";
            // 
            // about_lbl_productname
            // 
            this.about_lbl_productname.AutoSize = true;
            this.about_lbl_productname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_productname.ForeColor = System.Drawing.Color.White;
            this.about_lbl_productname.Location = new System.Drawing.Point(12, 88);
            this.about_lbl_productname.Name = "about_lbl_productname";
            this.about_lbl_productname.Size = new System.Drawing.Size(198, 17);
            this.about_lbl_productname.TabIndex = 3;
            this.about_lbl_productname.Text = "Product Name: Run-Alternative";
            // 
            // about_lbl_version
            // 
            this.about_lbl_version.AutoSize = true;
            this.about_lbl_version.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_version.ForeColor = System.Drawing.Color.White;
            this.about_lbl_version.Location = new System.Drawing.Point(12, 108);
            this.about_lbl_version.Name = "about_lbl_version";
            this.about_lbl_version.Size = new System.Drawing.Size(77, 17);
            this.about_lbl_version.TabIndex = 4;
            this.about_lbl_version.Text = "Version: 1.0";
            // 
            // about_tbox_description
            // 
            this.about_tbox_description.Location = new System.Drawing.Point(12, 148);
            this.about_tbox_description.Multiline = true;
            this.about_tbox_description.Name = "about_tbox_description";
            this.about_tbox_description.Size = new System.Drawing.Size(195, 58);
            this.about_tbox_description.TabIndex = 5;
            this.about_tbox_description.Text = "The program was developed solely by Tentex. Help received from ChatGPT. Thanks.\r\n" +
    "                                                   -Tentex";
            // 
            // about_lbl_description
            // 
            this.about_lbl_description.AutoSize = true;
            this.about_lbl_description.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_description.ForeColor = System.Drawing.Color.White;
            this.about_lbl_description.Location = new System.Drawing.Point(12, 128);
            this.about_lbl_description.Name = "about_lbl_description";
            this.about_lbl_description.Size = new System.Drawing.Size(79, 17);
            this.about_lbl_description.TabIndex = 6;
            this.about_lbl_description.Text = "Description;";
            // 
            // about_lbl_about
            // 
            this.about_lbl_about.AutoSize = true;
            this.about_lbl_about.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_lbl_about.ForeColor = System.Drawing.Color.White;
            this.about_lbl_about.Location = new System.Drawing.Point(9, 9);
            this.about_lbl_about.Name = "about_lbl_about";
            this.about_lbl_about.Size = new System.Drawing.Size(46, 17);
            this.about_lbl_about.TabIndex = 7;
            this.about_lbl_about.Text = "About";
            // 
            // RA_About
            // 
            this.AcceptButton = this.about_btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(302, 218);
            this.Controls.Add(this.about_lbl_about);
            this.Controls.Add(this.about_lbl_description);
            this.Controls.Add(this.about_tbox_description);
            this.Controls.Add(this.about_lbl_version);
            this.Controls.Add(this.about_lbl_productname);
            this.Controls.Add(this.about_lbl_license);
            this.Controls.Add(this.about_lbl_developer);
            this.Controls.Add(this.about_btn_accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RA_About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run-Alternative About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button about_btn_accept;
        public System.Windows.Forms.Label about_lbl_developer;
        public System.Windows.Forms.Label about_lbl_license;
        public System.Windows.Forms.Label about_lbl_productname;
        public System.Windows.Forms.Label about_lbl_version;
        public System.Windows.Forms.TextBox about_tbox_description;
        public System.Windows.Forms.Label about_lbl_description;
        public System.Windows.Forms.Label about_lbl_about;
    }
}
