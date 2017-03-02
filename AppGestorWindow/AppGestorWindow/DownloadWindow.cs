using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using ModelAppGestor.Data;

namespace AppGestorWindow
{
    public partial class DownloadWindow : MetroForm
    {

        private string _tempPath;
        private string _downloadPath;

        public DownloadWindow(ProgramaDTO program)
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void InitPaths(ProgramaDTO program)
        {
            _tempPath = System.IO.Path.GetTempPath() + "\\tempProgram.exe";
            _downloadPath = program.HOST;
            downloadingLabel.Text = "Downloading " + program.NOMBRE + "...";
        }

        private void DownloadWindow_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            StartDownload();
        }

        private void StartDownload()
        {
            downloadingLabel.Visible = true;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadCompleted;
                wc.DownloadFileAsync(new System.Uri(_downloadPath),
                _tempPath);
            }
        }

        
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }

        void wc_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(_tempPath);
        }
    }
}
