using MetroFramework.Controls;

namespace AppGestorWindow
{
    partial class DownloadWindow
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
            this.downloadProgress = new MetroFramework.Controls.MetroProgressBar();
            this.downloadingLabel = new MetroFramework.Controls.MetroLabel();
            this.nextBtn = new MetroButton();
            this.CancelBtn = new MetroButton();
            this.SuspendLayout();
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(23, 172);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(453, 23);
            this.downloadProgress.TabIndex = 0;
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.Visible = false;
            this.downloadingLabel.AutoSize = true;
            this.downloadingLabel.Location = new System.Drawing.Point(24, 133);
            this.downloadingLabel.Name = "downloadingLabel";
            this.downloadingLabel.Size = new System.Drawing.Size(95, 19);
            this.downloadingLabel.TabIndex = 1;
            this.downloadingLabel.Text = "Downloading...";
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(401, 346);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(311, 346);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Text = "Cancel";
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 410);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.downloadingLabel);
            this.Controls.Add(this.downloadProgress);
            this.Name = "DownloadWindow";
            this.Text = "Downloading";
            this.Load += new System.EventHandler(this.DownloadWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroProgressBar downloadProgress;
        private MetroLabel downloadingLabel;
        private MetroButton CancelBtn;
        private MetroButton nextBtn;
    }
}