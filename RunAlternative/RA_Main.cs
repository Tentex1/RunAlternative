using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace RunAlternative
{
    public partial class RA : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOD_NONE = 0x0000;
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;

        private const int WM_HOTKEY = 0x0312;

        private const int HOTKEY_ID = 1;
        private bool alt = false;

        public RA()
        {
            InitializeComponent();
            KeyPreview = true;
            FormClosing += (s, e) => { UnregisterHotKey(Handle, HOTKEY_ID); };
            RegisterHotKey(Handle, HOTKEY_ID, MOD_ALT, (int)Keys.Space);
            this.Hide();
        }
        // Controls applied as soon as the form opens ↓
        private void RA_Load(object sender, EventArgs e)
        {            
            this.KeyDown += RA_KeyDown;
            this.Hide();
            Size = new Size(572, 46);
            ProcessPanel.MouseEnter += GoogleSearchPanel_MouseEnter;
            ProcessPanel.MouseLeave += GoogleSearchPanel_MouseLeave;
            ProcessPanel.Click += GoogleSearchPanel_Click;            
            NotifyIcon.MouseClick += NotifyIcon_MouseClick;
            NotifyIcon.ContextMenuStrip = ContextSTNIcon;
            NotifyIcon.BalloonTipText = "The program is waiting in the background.";
            NotifyIcon.BalloonTipTitle = "Declaration";
            NotifyIcon.Icon = Properties.Resources.SearchIcon;
            NotifyIcon.ShowBalloonTip(1500);
        }
        // Controls applied as soon as the form opens ↑
        // TextBox Focus Code ↓
        private void RA_Activated(object sender, EventArgs e)
        {
            CommandBox.Focus();
        }
        // TextBox Focus code ↑
        // KeyDown Control's ↓
        private void RA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                this.Close();
            }

            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                string searchword = CommandBox.Text;
                Process.Start("https://www.google.com/search?q=" + searchword);
                this.Hide();
                CommandBox.Clear();
            }

            if (e.Alt && e.KeyCode == Keys.F4)
            {
                this.Hide();
            }

            if (e.Shift && e.KeyCode == Keys.B)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "File Select";
                    openFileDialog.Filter = "All Files|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        CommandBox.Text = openFileDialog.FileName;
                    }
                }
            }
        }
        // KeyDown Control's ↑
        // Accept (Enter) & Cancel Button Control's ↓
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string command = CommandBox.Text;
            string commandText = CommandBox.Text.ToLower();            
            if (CommandBox.Text == "exit")
            {
                this.Close();
            }
            if (CommandBox.Text.StartsWith("calc"))
            {
                string expression = commandText.Substring(5).Trim();

                string formattedExpression = FormatExpression(expression);

                try
                {
                    MessageBox.Show("Output: " + CalculateExpression(formattedExpression),"Calculation Output",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Calculation Error: " + ex.Message);
                }

                CommandBox.Clear();
            }            
            else if (CommandBox.Text.EndsWith(".com"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
                this.Hide();
            }
            else if (CommandBox.Text.EndsWith(".net"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
                this.Hide();
            }
            else if (CommandBox.Text.EndsWith(".org"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
                this.Hide();
            }
            else if (CommandBox.Text == "deepl")
            {
                Process.Start("https://deepl.com/translator");
                this.Hide();
            }
            else
            {
                try
                {
                    Process.Start(commandText);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    DialogResult error = MessageBox.Show("'" + CommandBox.Text + "'" + " Not found.", "Error: 37737", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // Accept (Enter) & Cancel Button Control's ↑
        // CommandBox Control's ↓
        private void CommandBox_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = CommandBox.Text.Any(char.IsLetter);
            if (CommandBox.Text.Length > 4)
            {
                // TextBox'tan alınan metnin 4. harften sonrasını alıp Label kontrolünde göster
                ProcessPanelDesLabel.Text = "Process: " + CommandBox.Text.Substring(4);
            }
            else
            {
                // TextBox'ta 4'ten az karakter varsa Label kontrolünde metni temizle
                ProcessPanelDesLabel.Text = "";
            }
            if (CommandBox.Text.Contains("calc"))
            {
                ProcessPanelLabel.Text = "Calculation Process";
                ProcessPanelIcon.BackgroundImage = Properties.Resources.CalculatorIcon;                
            }

            else if (CommandBox.Text.Contains(@"C:\"))
            {
                ProcessPanelLabel.Text = "Search for Google";
                ProcessPanelDesLabel.Visible = false;
            }
            else
            {
                ProcessPanelDesLabel.Text = "RunAlternative searches '" + CommandBox.Text + "' on Google for you";
                ProcessPanelLabel.Text = CommandBox.Text;
                ProcessPanelIcon.BackgroundImage = Properties.Resources.GoogleIcon;
            }

            if (!string.IsNullOrEmpty(CommandBox.Text))
            {
                Size = new Size(572, 100);
            }
            else
            {
                Size = new Size(572, 46);
            }
            EnterButton.Enabled = containsLetter;
        }
        // CommandBox Control's ↑
        // Calculate Control's ↓
        private string CalculateExpression(string expression)
        {
            try
            {
                // İfadeyi uygun bir formata getir
                string formattedExpression = expression.Replace(" ", ""); // Boşlukları kaldır

                DataTable table = new DataTable();
                var result = table.Compute(formattedExpression, "");
                return result.ToString();
            }
            catch (Exception ex)
            {
                return "Calculation Error: " + ex.Message;
            }
        }

        private string FormatExpression(string expression)
        {
            // Boşlukları ve geçersiz karakterleri temizle
            string cleanedExpression = Regex.Replace(expression, @"\s", "");

            return cleanedExpression;
        }
        // Calculate Control's ↑
        // Search Button Control's ↓
        private void SearchIcon_Click(object sender, EventArgs e)
        {
            EnterButton_Click(sender, e);
        }
        //Search Button Control's ↑
        // Alt+Space Hotkey ↓
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (id == HOTKEY_ID)
                {
                    this.Show();
                }
            }

            base.WndProc(ref m);
        }
        //Alt+Space Hotkey ↑
        // Google Search Panel Control's ↓
        private void GoogleSearchPanel_Click(object sender, EventArgs e)
        {
            if (CommandBox.Text.StartsWith("calc"))
            {
                string commandText = CommandBox.Text.ToLower();
                string expression = commandText.Substring(5).Trim();

                string formattedExpression = FormatExpression(expression);

                try
                {
                    MessageBox.Show("Output: " + CalculateExpression(formattedExpression), "Calculation Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Calculation Error: " + ex.Message);
                }

                CommandBox.Clear();
            }
            else
            {
                string searchword = CommandBox.Text.Trim();
                Process.Start("https://www.google.com/search?q=" + searchword);
            }            
        }

        private bool GoogleSearchPanel_SearchSystem(string searchword)
        {
            return false;
        }

        private void GoogleSearchPanel_MouseEnter(object sender, EventArgs e)
        {
            ProcessPanel.BackColor = SystemColors.ButtonShadow;
            ProcessPanelLabel.BackColor = SystemColors.ButtonShadow;
            ProcessPanelLabel.ForeColor = Color.White;
        }

        private void GoogleSearchPanel_MouseLeave(object sender, EventArgs e)
        {
            ProcessPanel.BackColor = SystemColors.WindowFrame;
            ProcessPanelLabel.ForeColor = Color.White;
            ProcessPanelLabel.BackColor = SystemColors.WindowFrame;
        }
        // Google Search Panel Control's ↑
        // Notify Icon Control's ↓
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextSTNIcon.Show(Cursor.Position);
            }
        }

        private void ContextSTNIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Notify Icon Control's ↑ 
    }
}

