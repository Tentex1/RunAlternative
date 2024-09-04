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
            this.CSTMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSTNIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProgramList = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.ProgramListPanelHider = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ProcessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPanelIcon)).BeginInit();
            this.ContextSTNIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandBox
            // 
            this.CommandBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CommandBox.ForeColor = System.Drawing.Color.White;
            this.CommandBox.Location = new System.Drawing.Point(7, 7);
            this.CommandBox.MaxLength = 45;
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(531, 32);
            this.CommandBox.TabIndex = 1;
            this.CommandBox.TextChanged += new System.EventHandler(this.CommandBox_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.ProcessPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProcessPanel.Controls.Add(this.ProcessPanelDesLabel);
            this.ProcessPanel.Controls.Add(this.ProcessPanelLabel);
            this.ProcessPanel.Controls.Add(this.ProcessPanelIcon);
            this.ProcessPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProcessPanel.Location = new System.Drawing.Point(7, 47);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(558, 46);
            this.ProcessPanel.TabIndex = 1;
            // 
            // ProcessPanelDesLabel
            // 
            this.ProcessPanelDesLabel.AutoSize = true;
            this.ProcessPanelDesLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.ProcessPanelDesLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessPanelDesLabel.Location = new System.Drawing.Point(56, 27);
            this.ProcessPanelDesLabel.Name = "ProcessPanelDesLabel";
            this.ProcessPanelDesLabel.Size = new System.Drawing.Size(321, 16);
            this.ProcessPanelDesLabel.TabIndex = 2;
            this.ProcessPanelDesLabel.Text = "RunAlternative searches \'word\' on Google for you";
            // 
            // ProcessPanelLabel
            // 
            this.ProcessPanelLabel.AutoSize = true;
            this.ProcessPanelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProcessPanelLabel.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProcessPanelLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessPanelLabel.Location = new System.Drawing.Point(56, 0);
            this.ProcessPanelLabel.Name = "ProcessPanelLabel";
            this.ProcessPanelLabel.Size = new System.Drawing.Size(195, 26);
            this.ProcessPanelLabel.TabIndex = 1;
            this.ProcessPanelLabel.Text = "Search on Google";
            // 
            // ProcessPanelIcon
            // 
            this.ProcessPanelIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProcessPanelIcon.BackgroundImage = global::RunAlternative.Properties.Resources.GoogleIcon;
            this.ProcessPanelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProcessPanelIcon.Location = new System.Drawing.Point(7, 0);
            this.ProcessPanelIcon.Name = "ProcessPanelIcon";
            this.ProcessPanelIcon.Size = new System.Drawing.Size(47, 46);
            this.ProcessPanelIcon.TabIndex = 0;
            this.ProcessPanelIcon.TabStop = false;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "Show";
            this.NotifyIcon.Visible = true;
            // 
            // CSTMenuItem1
            // 
            this.CSTMenuItem1.Name = "CSTMenuItem1";
            this.CSTMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.CSTMenuItem1.Text = "Exit";
            this.CSTMenuItem1.Click += new System.EventHandler(this.ContextSTNIcon_Click);
            // 
            // ContextSTNIcon
            // 
            this.ContextSTNIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSTMenuItem1});
            this.ContextSTNIcon.Name = "main_cmstrip_nicon";
            this.ContextSTNIcon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextSTNIcon.Size = new System.Drawing.Size(93, 26);
            // 
            // ProgramList
            // 
            this.ProgramList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ProgramList.AutoArrange = false;
            this.ProgramList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProgramList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramList.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold);
            this.ProgramList.ForeColor = System.Drawing.Color.White;
            this.ProgramList.HideSelection = false;
            this.ProgramList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProgramList.LargeImageList = this.ImageList;
            this.ProgramList.Location = new System.Drawing.Point(7, 93);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(558, 330);
            this.ProgramList.TabIndex = 3;
            this.ProgramList.UseCompatibleStateImageBehavior = false;
            this.ProgramList.View = System.Windows.Forms.View.Details;
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProgramListPanelHider
            // 
            this.ProgramListPanelHider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ProgramListPanelHider.Location = new System.Drawing.Point(547, 93);
            this.ProgramListPanelHider.Name = "ProgramListPanelHider";
            this.ProgramListPanelHider.Size = new System.Drawing.Size(18, 330);
            this.ProgramListPanelHider.TabIndex = 4;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.Image = global::RunAlternative.Properties.Resources.SearchPNG;
            this.SearchIcon.Location = new System.Drawing.Point(546, 15);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(15, 15);
            this.SearchIcon.TabIndex = 2;
            this.SearchIcon.TabStop = false;
            // 
            // RA
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(572, 442);
            this.ControlBox = false;
            this.Controls.Add(this.ProgramListPanelHider);
            this.Controls.Add(this.ProgramList);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ProcessPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CommandBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(480, 300);
            this.Name = "RA";
            this.Opacity = 0.95D;
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
        private System.Windows.Forms.Label ProcessPanelDesLabel;
        public System.Windows.Forms.Panel ProcessPanel;
        private ToolStripMenuItem CSTMenuItem1;
        private ContextMenuStrip ContextSTNIcon;
        private ListView ProgramList;
        private ImageList ImageList;
        private Panel ProgramListPanelHider;
        private PictureBox SearchIcon;
    }
}

