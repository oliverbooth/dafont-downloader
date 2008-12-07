using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace dafont
{
    public partial class frmMain : Form
    {
        [DllImport("gdi32.dll",CharSet=CharSet.Unicode,ExactSpelling=true)]
        public static extern int AddFontResourceW(string lpszFilename);
        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern bool RemoveFontResourceW(string lpszFilename);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int WriteProfileString(string lpszSection, string lpszKeyName, string lpszString);
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, // handle to destination window
        uint Msg, // message
        int wParam, // first message parameter
        int lParam // second message parameter
        );
        bool dlc = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            btnDownload.Enabled = false;
            bool d = true;
            try { Directory.CreateDirectory(Application.StartupPath + "\\temp"); }
            catch { }
            try { cliDownload.DownloadFile("http://img.dafont.com/dl/?f=" + txtName.Text.Replace(" ", "_").Replace("-", "_").ToLower(), Application.StartupPath + "\\temp\\font.zip"); }
            catch { cliDownload.DownloadFile("http://img.dafont.com/dl/?f=" + txtName.Text.Replace(" ", "").Replace("-", "").ToLower(), Application.StartupPath + "\\temp\\font.zip"); }
            this.Text = "dafont downloader";
            this.UseWaitCursor = false;
            pbrStatus.Value = 0;
            lblStatus.Text = pbrStatus.Value + "% Installing";
            FastZip fz = new FastZip();
        gohere:
            this.UseWaitCursor = true;
            try { fz.ExtractZip(Application.StartupPath + "\\temp\\font.zip", Application.StartupPath + "\\temp", ""); }
            catch { goto gohere; }
            this.UseWaitCursor = false;
            this.Show();
            File.Delete(Application.StartupPath + "\\temp\\font.zip");
            string[] files = Directory.GetFiles(Application.StartupPath + "\\temp");
            pbrStatus.Value = 33;
            lblStatus.Text = pbrStatus.Value + "% Installing";
            foreach (string file in files)
            {
                string ext = file.Substring(file.Length - 4);
                if (ext == ".ttf" || ext == ".ttc")
                {
                    string[] filespl = file.Split("\\".ToCharArray());
                    if (!AddFont(file)) d = false;
                }
            }
            pbrStatus.Value = 66;
            lblStatus.Text = pbrStatus.Value + "% Installing";
            foreach (string file in files)
            {
                File.Delete(file);
            }
            try { Directory.Delete(Application.StartupPath + "\\temp"); }
            catch { }
            pbrStatus.Value = 100;
            lblStatus.Text = pbrStatus.Value + "% Installed";
            if (!d) { lblStatus.Text = "Install failed"; pbrStatus.Value = 0; }
            dlc = false;
            this.BringToFront();
            MessageBox.Show("\"" + txtName.Text + "\" successfully installed", "dafont downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Enabled = true;
            btnDownload.Enabled = true;
            pbrStatus.Value = 0;
            lblStatus.Text = pbrStatus.Value + "%";
            txtName.Focus();
            txtName.Text = "";
        }

        private void cliDownload_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            lblStatus.Text = e.ProgressPercentage + "% Downloading";
            pbrStatus.Value = e.ProgressPercentage;
        }


        public static bool AddFont(string filename)
        {
            if (System.IO.File.Exists(filename))
            {
                // returns true if (>=1) font is installed
                string[] folders = filename.Split("\\".ToCharArray());
                try { File.Copy(filename, "C:\\Windows\\Fonts\\" + folders[folders.Length - 1]); }
                catch { }
                return (AddFontResourceW("C:\\Windows\\Fonts\\" + folders[folders.Length - 1]) != 0);
            }
            return false;
        }

        private void icoNotify_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            icoNotify.Visible = false;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.Size.Height < this.MinimumSize.Height && this.Size.Width < this.MinimumSize.Width)
            {
                this.Hide();
                icoNotify.Visible = true;
            }
        }

        private void icoNotify_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            icoNotify.Visible = false;
        }

        private void icoNotify_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void icoNotify_MouseMove(object sender, EventArgs e)
        {
            icoNotify.ShowBalloonTip(5000);
        }

        private void cliDownload_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            dlc = true;
        }
    }
}
