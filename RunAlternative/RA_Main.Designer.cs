using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RunAlternative
{
    partial class RA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RA));
            this.CommandBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProcessPanel = new System.Windows.Forms.Panel();
            this.ProcessPanelDesLabel = new System.Windows.Forms.Label();
            this.ProcessPanelLabel = new System.Windows.Forms.Label();
            this.ProcessPanelIcon = new System.Windows.Forms.PictureBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextSTNIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CSTMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ProcessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPanelIcon)).BeginInit();
            this.ContextSTNIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandBox
            // 
            this.CommandBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandBox.Font = new System.Drawing.Font("Arial", 20F);
            this.CommandBox.ForeColor = System.Drawing.Color.White;
            this.CommandBox.Location = new System.Drawing.Point(12, 8);
            this.CommandBox.MaxLength = 45;
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(508, 31);
            this.CommandBox.TabIndex = 1;
            this.CommandBox.TextChanged += new System.EventHandler(this.CommandBox_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(603, 24);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(603, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProcessPanel
            // 
            this.ProcessPanel.Controls.Add(this.ProcessPanelDesLabel);
            this.ProcessPanel.Controls.Add(this.ProcessPanelLabel);
            this.ProcessPanel.Controls.Add(this.ProcessPanelIcon);
            this.ProcessPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProcessPanel.Location = new System.Drawing.Point(0, 47);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(572, 46);
            this.ProcessPanel.TabIndex = 1;
            // 
            // ProcessPanelDesLabel
            // 
            this.ProcessPanelDesLabel.AutoSize = true;
            this.ProcessPanelDesLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.ProcessPanelDesLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessPanelDesLabel.Location = new System.Drawing.Point(54, 25);
            this.ProcessPanelDesLabel.Name = "ProcessPanelDesLabel";
            this.ProcessPanelDesLabel.Size = new System.Drawing.Size(321, 16);
            this.ProcessPanelDesLabel.TabIndex = 2;
            this.ProcessPanelDesLabel.Text = "RunAlternative searches \'word\' on Google for you";
            // 
            // ProcessPanelLabel
            // 
            this.ProcessPanelLabel.AutoSize = true;
            this.ProcessPanelLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ProcessPanelLabel.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProcessPanelLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessPanelLabel.Location = new System.Drawing.Point(52, 0);
            this.ProcessPanelLabel.Name = "ProcessPanelLabel";
            this.ProcessPanelLabel.Size = new System.Drawing.Size(195, 26);
            this.ProcessPanelLabel.TabIndex = 1;
            this.ProcessPanelLabel.Text = "Search on Google";
            // 
            // ProcessPanelIcon
            // 
            this.ProcessPanelIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProcessPanelIcon.BackgroundImage")));
            this.ProcessPanelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProcessPanelIcon.Location = new System.Drawing.Point(12, 6);
            this.ProcessPanelIcon.Name = "ProcessPanelIcon";
            this.ProcessPanelIcon.Size = new System.Drawing.Size(35, 35);
            this.ProcessPanelIcon.TabIndex = 0;
            this.ProcessPanelIcon.TabStop = false;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "Show";
            this.NotifyIcon.Visible = true;
            // 
            // ContextSTNIcon
            // 
            this.ContextSTNIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSTMenuItem1});
            this.ContextSTNIcon.Name = "main_cmstrip_nicon";
            this.ContextSTNIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextSTNIcon.Size = new System.Drawing.Size(93, 26);
            // 
            // CSTMenuItem1
            // 
            this.CSTMenuItem1.Name = "CSTMenuItem1";
            this.CSTMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.CSTMenuItem1.Text = "Exit";
            this.CSTMenuItem1.Click += new System.EventHandler(this.ContextSTNIcon_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::RunAlternative.Properties.Resources.SearchPNG;
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.Location = new System.Drawing.Point(529, 4);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(35, 35);
            this.SearchIcon.TabIndex = 2;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            // 
            // RA
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(572, 46);
            this.ControlBox = false;
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ProcessPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CommandBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RA";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunAlternative";
            this.Activated += new System.EventHandler(this.RA_Activated);
            this.Load += new System.EventHandler(this.RA_Load);
            this.ProcessPanel.ResumeLayout(false);
            this.ProcessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPanelIcon)).EndInit();
            this.ContextSTNIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox CommandBox;
        private System.Windows.Forms.PictureBox ProcessPanelIcon;
        public System.Windows.Forms.Label ProcessPanelLabel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextSTNIcon;
        private System.Windows.Forms.ToolStripMenuItem CSTMenuItem1;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Label ProcessPanelDesLabel;
        public System.Windows.Forms.Panel ProcessPanel;
    }
}

