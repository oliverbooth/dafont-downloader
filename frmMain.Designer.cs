namespace dafont
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cliDownload = new System.Net.WebClient();
            this.pbrStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.icoNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(15, 63);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 28);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Font:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 2;
            // 
            // cliDownload
            // 
            this.cliDownload.BaseAddress = "";
            this.cliDownload.CachePolicy = null;
            this.cliDownload.Credentials = null;
            this.cliDownload.Encoding = ((System.Text.Encoding)(resources.GetObject("cliDownload.Encoding")));
            this.cliDownload.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("cliDownload.Headers")));
            this.cliDownload.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("cliDownload.QueryString")));
            this.cliDownload.UseDefaultCredentials = false;
            this.cliDownload.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.cliDownload_DownloadFileCompleted);
            this.cliDownload.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.cliDownload_DownloadProgressChanged);
            // 
            // pbrStatus
            // 
            this.pbrStatus.Location = new System.Drawing.Point(15, 98);
            this.pbrStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbrStatus.Name = "pbrStatus";
            this.pbrStatus.Size = new System.Drawing.Size(257, 27);
            this.pbrStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(172, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 28);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "0%";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // icoNotify
            // 
            this.icoNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icoNotify.BalloonTipText = "This application is still in Beta.\r\n\r\nClick this balloon to restore the window.";
            this.icoNotify.BalloonTipTitle = "dafont downloader";
            this.icoNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("icoNotify.Icon")));
            this.icoNotify.Text = "dafont downloader";
            this.icoNotify.BalloonTipClicked += new System.EventHandler(this.icoNotify_BalloonTipClicked);
            this.icoNotify.Click += new System.EventHandler(this.icoNotify_MouseMove);
            this.icoNotify.DoubleClick += new System.EventHandler(this.icoNotify_DoubleClick);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbrStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 171);
            this.MinimumSize = new System.Drawing.Size(300, 133);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dafont downloader";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Net.WebClient cliDownload;
        private System.Windows.Forms.ProgressBar pbrStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NotifyIcon icoNotify;
    }
}

