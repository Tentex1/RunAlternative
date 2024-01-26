using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAlternative
{
    public partial class RA_Main : Form
    {
        public RA_Main()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += Form1_KeyDown;
            main_pnl_googlesearch.Click += main_pnl_googlesearch_Click;
            main_tbox_commandbox.Focus();
            main_nicon.MouseClick += main_nicon_MouseClick;
            main_nicon.ContextMenuStrip = main_cmstrip_nicon;
            main_nicon.BalloonTipText = "The program is waiting in the background.";
            main_nicon.BalloonTipTitle = "Declaration";
            main_nicon.Icon = Properties.Resources.RA_Logo1;
            main_nicon.ShowBalloonTip(1500);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                this.Close();
            }

            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                string searchword = main_tbox_commandbox.Text;
                Process.Start("https://www.google.com/search?q=" + searchword);
            }

            if (e.Alt && e.KeyCode == Keys.F4)
            {
                this.Hide();
            }

            if (e.Shift && e.KeyCode == Keys.A)
            {
                RA_About window = new RA_About();
                window.Show();
            }
            if (e.Shift && e.KeyCode == Keys.B)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Dosya Seç";
                    openFileDialog.Filter = "Tüm Dosyalar|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        main_tbox_commandbox.Text = openFileDialog.FileName;
                    }
                }
            }

        }

        private void main_nicon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }

            if (e.Button == MouseButtons.Right)
            {
                main_cmstrip_nicon.Show(Cursor.Position);
            }
        }

        private void main_pnl_googlesearch_Click(object sender, EventArgs e)
        {
            string searchword = main_tbox_commandbox.Text.Trim();
            Process.Start("https://www.google.com/search?q=" + searchword);
        }

        private bool main_pnl_googlesearch_SearchSystem(string searchword)
        {
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_btn_enter_Click(object sender, EventArgs e)
        {
            if (main_tbox_commandbox.Text == "RA:About")
            {
                RA_About window = new RA_About();
                window.Show();
                main_tbox_commandbox.Text = "";
            }

            string searchword = main_tbox_commandbox.Text.Trim();
            string command = main_tbox_commandbox.Text;

            if (!string.IsNullOrWhiteSpace(command))
            {

                try
                {
                    Process.Start(command);
                    this.Hide();
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
            }
        }
            
        

        private void main_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_tbox_commandbox_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = main_tbox_commandbox.Text.Any(char.IsLetter);
            if (!string.IsNullOrEmpty(main_tbox_commandbox.Text))
            {
                Size = new Size(572, 146);
                main_pnl_googlesearch.Visible = true;
            }
            else
            {
                Size = new Size(572, 73);
                main_pnl_googlesearch.Visible = false;
            }
            main_btn_enter.Enabled = containsLetter;
        }
    }
}
