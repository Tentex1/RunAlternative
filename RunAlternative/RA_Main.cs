using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
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

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // Formun handle'ını almak için
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        // ShowWindow için sabitler
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;


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
            
        }
        // Controls applied as soon as the form opens ↓
        private void RA_Load(object sender, EventArgs e)
        {            
            this.KeyDown += RA_KeyDown;
            Activated += RA_Activated;
            Deactivate += RA_Deactivated;
            Size = new Size(572, 46);
            ProgramList.View = View.Tile;            
            ProgramList.LargeImageList = ImageList;
            ProgramList.MouseDoubleClick += ProgramList_DoubleClick;
            ProcessPanel.MouseEnter += ProcessPanel_MouseEnter;
            ProcessPanel.MouseLeave += ProcessPanel_MouseLeave;
            ProcessPanel.Click += ProcessPanel_Click;
            NotifyIcon.MouseClick += NotifyIcon_MouseClick;
            NotifyIcon.ContextMenuStrip = ContextSTNIcon;
            NotifyIcon.BalloonTipText = "The program is waiting in the background.";
            NotifyIcon.BalloonTipTitle = "Declaration";
            NotifyIcon.Icon = Properties.Resources.SearchIcon;                
            NotifyIcon.ShowBalloonTip(1500);
            for (int i = 1; i <= 10; i++)
            {
                ProgramList.Items.Add("Item " + i);
            }

        }
        // Controls applied as soon as the form opens ↑
        private void RA_Deactivated(object sender, EventArgs e)
        {
            ShowWindow(this.Handle, SW_HIDE); // Formu gizle
        }
        // Activate Code ↓
        private void RA_Activated(object sender, EventArgs e)
        {
            ShowWindow(this.Handle, SW_SHOW); // Formu göster
            CommandBox.Focus();            
        }
        // Activate code ↑
        // KeyDown Control's ↓
        private void RA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CancelButton_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F4)
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
        // Accept (Enter) & Cancel/Hide Button Control's ↓
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string command = CommandBox.Text;
            string commandText = CommandBox.Text.ToLower();
            if (CommandBox.Text.Contains(@":\"))
            {
                try
                {
                    Process.Start(CommandBox.Text);
                    CommandBox.Clear();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    DialogResult error = MessageBox.Show("Directory Not found.", "Error: 37737", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (CommandBox.Text.StartsWith("cmd"))
            {
                try
                {
                    Process.Start(CommandBox.Text.Substring(4));
                    CommandBox.Clear();
                    this.Hide();
                }
                catch
                {
                    DialogResult error = MessageBox.Show("Command Not found.", "Error: 37737", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CommandBox.Text.StartsWith("calc"))
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
            else if (CommandBox.Text.Contains(".com"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
                this.Hide();
            }
            else if (CommandBox.Text.Contains(".net"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
                this.Hide();
            }
            else if (CommandBox.Text.Contains(".org"))
            {
                Process.Start("https://" + commandText);
                CommandBox.Clear();
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
            this.Hide();        

        }        
        // Accept (Enter) & Cancel/Hide Button Control's ↑
        // CommandBox Control's ↓
        private void CommandBox_TextChanged(object sender, EventArgs e)
        {
            string query = CommandBox.Text;
            UpdateProgramList(query);
            if (!string.IsNullOrWhiteSpace(query))
            {
                var suggestions = GetSuggestions(query);
                ProgramList.Items.Clear();
                ImageList.Images.Clear();

                foreach (var suggestion in suggestions)
                {
                    var icon = GetIcon(suggestion);
                    ImageList.Images.Add(icon);

                    var item = new ListViewItem
                    {
                        Text = Path.GetFileName(suggestion),
                        ImageIndex = ImageList.Images.Count - 1,
                        Tag = suggestion
                    };
                    ProgramList.Items.Add(item);
                }
            }
            else
            {
                ProgramList.Items.Clear();
                ImageList.Images.Clear();
            }
            bool containsLetter = CommandBox.Text.Any(char.IsLetter);            
            if (CommandBox.Text.StartsWith("calc"))
            {
                ProcessPanelLabel.Text = "Calculation Process...";
                ProcessPanelIcon.BackgroundImageLayout = ImageLayout.Zoom;
                ProcessPanelDesLabel.Text = "Process:" + CommandBox.Text.Substring(4);
            }
            else if (CommandBox.Text.StartsWith("cmd"))
            {
            }
            else if (CommandBox.Text.Contains(@":\"))
            {
                ProcessPanelLabel.Text = "Directory Search...";
                ProcessPanelDesLabel.Text = "Directory: " + CommandBox.Text;
                ProcessPanelIcon.BackgroundImage = Properties.Resources.DirectorySearchIcon;
                ProcessPanelIcon.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                ProcessPanelDesLabel.Text = "RunAlternative searches '" + CommandBox.Text + "' on Google for you";
                ProcessPanelLabel.Text = CommandBox.Text;
                ProcessPanelIcon.BackgroundImage = Properties.Resources.GoogleIcon;
                ProcessPanelIcon.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (!string.IsNullOrEmpty(CommandBox.Text))
            {
                Size = new Size(572, 450);
            }
            else
            {
                Size = new Size(572, 46);
            }
            EnterButton.Enabled = containsLetter;
        }
        // CommandBox Control's ↑ 
        private List<string> GetSuggestions(string query)
        {
            List<string> results = new List<string>();
            string[] allDirectories, programFiles, programFiles86, windowsFiles, programData, userFiles;

            void AddDirectoriesAndExeFiles(string path)
            {
                try
                {
                    var directories = Directory.GetDirectories(path);
                    results.AddRange(directories.Where(dir => Path.GetFileName(dir).StartsWith(query, StringComparison.OrdinalIgnoreCase)));

                    var exeFiles = Directory.GetFiles(path, "*.exe");
                    results.AddRange(exeFiles.Where(file => Path.GetFileName(file).StartsWith(query, StringComparison.OrdinalIgnoreCase)));
                }
                catch (UnauthorizedAccessException) { }
            }

            AddDirectoriesAndExeFiles(@"C:\");
            AddDirectoriesAndExeFiles(@"C:\Program Files");
            AddDirectoriesAndExeFiles(@"C:\Program Files (x86)");
            AddDirectoriesAndExeFiles(@"C:\Windows");
            AddDirectoriesAndExeFiles(@"C:\ProgramData");
            AddDirectoriesAndExeFiles(@"C:\Users\" + Environment.UserName);

            return results;
        }

        private void UpdateProgramList(string query)
        {
            var suggestions = GetSuggestions(query);
            ProgramList.Items.Clear();

            // Icon'ları tutmak için ImageList oluştur
            ImageList imageList = new ImageList();
            ProgramList.LargeImageList = imageList;

            foreach (var suggestion in suggestions)
            {
                var item = new ListViewItem(Path.GetFileName(suggestion))
                {
                    Tag = suggestion
                };

                // İkonu ekle
                Icon icon;
                try
                {
                    if (Directory.Exists(suggestion))
                    {
                        icon = Properties.Resources.Folder; // Klasör ikonu
                    }
                    else
                    {
                        icon = Icon.ExtractAssociatedIcon(suggestion); // Dosya ikonu
                    }

                    imageList.Images.Add(icon);
                    item.ImageIndex = imageList.Images.Count - 1;
                }
                catch
                {
                    // İkon eklenemezse hata yakala ve devam et
                }

                ProgramList.Items.Add(item);
            }
        }


        private void ProgramList_DoubleClick(object sender, EventArgs e)
        {
            if (ProgramList.SelectedItems.Count > 0)
            {
                string selectedPath = ProgramList.SelectedItems[0].Tag.ToString();
                try
                {
                    if (Directory.Exists(selectedPath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "explorer.exe",
                            Arguments = selectedPath,
                            UseShellExecute = true
                        });
                        this.Hide();
                    }
                    else if (File.Exists(selectedPath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = selectedPath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("Folder not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Folder not responding: " + ex.Message);
                }
            }
        }
        private void ProgramList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Arka plan rengini ayarla
            e.DrawBackground();

            // Metni çiz
            string text = ProgramList.Items[e.Index].ToString();
            using (Brush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }

            // Odağı çizin
            e.DrawFocusRectangle();
        }

        private Icon GetIcon(string path)
        {
            if (Directory.Exists(path))
            {
                return Properties.Resources.Folder; // Klasör için bir ikon
            }
            else if (File.Exists(path))
            {
                return Icon.ExtractAssociatedIcon(path); // Dosya için ilgili ikon
            }
            else
            {
                return SystemIcons.Error; // Geçersiz yol için bir ikon
            }
        }
        // Calculate Control's ↓
        private string CalculateExpression(string expression)
        {
            try
            {
                string formattedExpression = expression.Replace(" ", "");

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
            string cleanedExpression = Regex.Replace(expression, @"\s", "");

            return cleanedExpression;
        }
        // Calculate Control's ↑         
        // Alt+Space Hotkey ↓
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (id == HOTKEY_ID)
                {
                    this.Show();
                    CommandBox.Clear();
                }
            }

            base.WndProc(ref m);
        }
        //Alt+Space Hotkey ↑
        // Google Search Panel Control's ↓
        private void ProcessPanel_Click(object sender, EventArgs e)
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

        private bool ProcessPanel_SearchSystem(string searchword)
        {
            return false;
        }

        private void ProcessPanel_MouseEnter(object sender, EventArgs e)
        {
            ProcessPanel.BackColor = SystemColors.ScrollBar;
            ProcessPanelDesLabel.ForeColor = Color.Black;
            ProcessPanelDesLabel.BackColor = ProcessPanel.BackColor;
            ProcessPanelLabel.BackColor = ProcessPanel.BackColor;
            ProcessPanelLabel.ForeColor = Color.Black;
            ProcessPanelIcon.BackColor = ProcessPanel.BackColor;
            ProcessPanelIcon.BackgroundImage = Properties.Resources.GoogleIconBlack;
        }

        private void ProcessPanel_MouseLeave(object sender, EventArgs e)
        {
            ProcessPanel.BackColor = Color.FromArgb(51,51,51);
            ProcessPanelDesLabel.ForeColor = Color.White;
            ProcessPanelDesLabel.BackColor = ProcessPanel.BackColor;
            ProcessPanelLabel.ForeColor = Color.White;                   
            ProcessPanelLabel.BackColor = ProcessPanel.BackColor;
            ProcessPanelIcon.BackColor = ProcessPanel.BackColor;
            ProcessPanelIcon.BackgroundImage = Properties.Resources.GoogleIcon;           
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

