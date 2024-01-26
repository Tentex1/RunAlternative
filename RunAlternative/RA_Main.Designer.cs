namespace RunAlternative
{
    partial class RA_Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RA_Main));
            this.main_tbox_commandbox = new System.Windows.Forms.TextBox();
            this.main_btn_enter = new System.Windows.Forms.Button();
            this.main_btn_cancel = new System.Windows.Forms.Button();
            this.main_pnl_googlesearch = new System.Windows.Forms.Panel();
            this.main_lbl_googlesearchlbldescription = new System.Windows.Forms.Label();
            this.main_lbl_googlesearchlbl = new System.Windows.Forms.Label();
            this.main_pbox_googlesearchicon = new System.Windows.Forms.PictureBox();
            this.main_nicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.main_cmstrip_nicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_pnl_googlesearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pbox_googlesearchicon)).BeginInit();
            this.main_cmstrip_nicon.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tbox_commandbox
            // 
            this.main_tbox_commandbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.main_tbox_commandbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_tbox_commandbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.main_tbox_commandbox.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tbox_commandbox.ForeColor = System.Drawing.Color.White;
            this.main_tbox_commandbox.Location = new System.Drawing.Point(12, 12);
            this.main_tbox_commandbox.Name = "main_tbox_commandbox";
            this.main_tbox_commandbox.Size = new System.Drawing.Size(547, 44);
            this.main_tbox_commandbox.TabIndex = 0;
            this.main_tbox_commandbox.TextChanged += new System.EventHandler(this.main_tbox_commandbox_TextChanged);
            // 
            // main_btn_enter
            // 
            this.main_btn_enter.Location = new System.Drawing.Point(3, 100);
            this.main_btn_enter.Name = "main_btn_enter";
            this.main_btn_enter.Size = new System.Drawing.Size(75, 23);
            this.main_btn_enter.TabIndex = 0;
            this.main_btn_enter.Text = "Enter";
            this.main_btn_enter.UseVisualStyleBackColor = true;
            this.main_btn_enter.Click += new System.EventHandler(this.main_btn_enter_Click);
            // 
            // main_btn_cancel
            // 
            this.main_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.main_btn_cancel.Location = new System.Drawing.Point(3, 115);
            this.main_btn_cancel.Name = "main_btn_cancel";
            this.main_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.main_btn_cancel.TabIndex = 0;
            this.main_btn_cancel.Text = "Cancel";
            this.main_btn_cancel.UseVisualStyleBackColor = true;
            this.main_btn_cancel.Click += new System.EventHandler(this.main_btn_cancel_Click);
            // 
            // main_pnl_googlesearch
            // 
            this.main_pnl_googlesearch.Controls.Add(this.main_lbl_googlesearchlbldescription);
            this.main_pnl_googlesearch.Controls.Add(this.main_lbl_googlesearchlbl);
            this.main_pnl_googlesearch.Controls.Add(this.main_pbox_googlesearchicon);
            this.main_pnl_googlesearch.Location = new System.Drawing.Point(0, 73);
            this.main_pnl_googlesearch.Name = "main_pnl_googlesearch";
            this.main_pnl_googlesearch.Size = new System.Drawing.Size(572, 73);
            this.main_pnl_googlesearch.TabIndex = 0;
            // 
            // main_lbl_googlesearchlbldescription
            // 
            this.main_lbl_googlesearchlbldescription.AutoSize = true;
            this.main_lbl_googlesearchlbldescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.main_lbl_googlesearchlbldescription.ForeColor = System.Drawing.Color.White;
            this.main_lbl_googlesearchlbldescription.Location = new System.Drawing.Point(81, 41);
            this.main_lbl_googlesearchlbldescription.Name = "main_lbl_googlesearchlbldescription";
            this.main_lbl_googlesearchlbldescription.Size = new System.Drawing.Size(163, 19);
            this.main_lbl_googlesearchlbldescription.TabIndex = 2;
            this.main_lbl_googlesearchlbldescription.Text = "Google searches for you.";
            // 
            // main_lbl_googlesearchlbl
            // 
            this.main_lbl_googlesearchlbl.AutoSize = true;
            this.main_lbl_googlesearchlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.main_lbl_googlesearchlbl.ForeColor = System.Drawing.Color.White;
            this.main_lbl_googlesearchlbl.Location = new System.Drawing.Point(78, 4);
            this.main_lbl_googlesearchlbl.Name = "main_lbl_googlesearchlbl";
            this.main_lbl_googlesearchlbl.Size = new System.Drawing.Size(233, 37);
            this.main_lbl_googlesearchlbl.TabIndex = 1;
            this.main_lbl_googlesearchlbl.Text = "Search on Google";
            // 
            // main_pbox_googlesearchicon
            // 
            this.main_pbox_googlesearchicon.BackgroundImage = global::RunAlternative.Properties.Resources.googleicon;
            this.main_pbox_googlesearchicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_pbox_googlesearchicon.Location = new System.Drawing.Point(0, 0);
            this.main_pbox_googlesearchicon.Name = "main_pbox_googlesearchicon";
            this.main_pbox_googlesearchicon.Size = new System.Drawing.Size(78, 73);
            this.main_pbox_googlesearchicon.TabIndex = 0;
            this.main_pbox_googlesearchicon.TabStop = false;
            // 
            // main_nicon
            // 
            this.main_nicon.Text = "Show";
            this.main_nicon.Visible = true;
            // 
            // main_cmstrip_nicon
            // 
            this.main_cmstrip_nicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.main_cmstrip_nicon.Name = "main_cmstrip_nicon";
            this.main_cmstrip_nicon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.main_cmstrip_nicon.Size = new System.Drawing.Size(181, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RA_Main
            // 
            this.AcceptButton = this.main_btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.main_btn_cancel;
            this.ClientSize = new System.Drawing.Size(572, 73);
            this.ControlBox = false;
            this.Controls.Add(this.main_pnl_googlesearch);
            this.Controls.Add(this.main_btn_cancel);
            this.Controls.Add(this.main_btn_enter);
            this.Controls.Add(this.main_tbox_commandbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RA_Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunAlternative";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_pnl_googlesearch.ResumeLayout(false);
            this.main_pnl_googlesearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pbox_googlesearchicon)).EndInit();
            this.main_cmstrip_nicon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button main_btn_enter;
        private System.Windows.Forms.Button main_btn_cancel;
        public System.Windows.Forms.TextBox main_tbox_commandbox;
        private System.Windows.Forms.Panel main_pnl_googlesearch;
        private System.Windows.Forms.PictureBox main_pbox_googlesearchicon;
        public System.Windows.Forms.Label main_lbl_googlesearchlbl;
        public System.Windows.Forms.Label main_lbl_googlesearchlbldescription;
        private System.Windows.Forms.NotifyIcon main_nicon;
        private System.Windows.Forms.ContextMenuStrip main_cmstrip_nicon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

