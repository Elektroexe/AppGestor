using MetroFramework.Controls;

namespace AppGestorWindow
{
    partial class AppGestor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAppInstalled = new System.Windows.Forms.DataGridView();
            this.tbAppSearch = new MetroFramework.Controls.MetroTextBox();
            this.tcAppCategories = new MetroFramework.Controls.MetroTabControl();
            this.tpAppInternet = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppInternet = new System.Windows.Forms.DataGridView();
            this.tpAppAntivirus = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppAntivirus = new System.Windows.Forms.DataGridView();
            this.tpAppOfimatica = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppOfimatica = new System.Windows.Forms.DataGridView();
            this.tpAppProgramacion = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppProgramacion = new System.Windows.Forms.DataGridView();
            this.tpAppJuegos = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppJuegos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInstalled)).BeginInit();
            this.tcAppCategories.SuspendLayout();
            this.tpAppInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInternet)).BeginInit();
            this.tpAppAntivirus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppAntivirus)).BeginInit();
            this.tpAppOfimatica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppOfimatica)).BeginInit();
            this.tpAppProgramacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppProgramacion)).BeginInit();
            this.tpAppJuegos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppInstalled
            // 
            this.dgvAppInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppInstalled.Location = new System.Drawing.Point(23, 63);
            this.dgvAppInstalled.Name = "dgvAppInstalled";
            this.dgvAppInstalled.Size = new System.Drawing.Size(300, 642);
            this.dgvAppInstalled.TabIndex = 0;
            // 
            // tbAppSearch
            // 
            // 
            // 
            // 
            this.tbAppSearch.CustomButton.Image = null;
            this.tbAppSearch.CustomButton.Location = new System.Drawing.Point(959, 1);
            this.tbAppSearch.CustomButton.Name = "";
            this.tbAppSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbAppSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAppSearch.CustomButton.TabIndex = 1;
            this.tbAppSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAppSearch.CustomButton.UseSelectable = true;
            this.tbAppSearch.CustomButton.Visible = false;
            this.tbAppSearch.Lines = new string[0];
            this.tbAppSearch.Location = new System.Drawing.Point(356, 74);
            this.tbAppSearch.MaxLength = 32767;
            this.tbAppSearch.Name = "tbAppSearch";
            this.tbAppSearch.PasswordChar = '\0';
            this.tbAppSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAppSearch.SelectedText = "";
            this.tbAppSearch.SelectionLength = 0;
            this.tbAppSearch.SelectionStart = 0;
            this.tbAppSearch.ShortcutsEnabled = true;
            this.tbAppSearch.Size = new System.Drawing.Size(987, 29);
            this.tbAppSearch.TabIndex = 1;
            this.tbAppSearch.UseSelectable = true;
            this.tbAppSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAppSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tcAppCategories
            // 
            this.tcAppCategories.Controls.Add(this.tpAppInternet);
            this.tcAppCategories.Controls.Add(this.tpAppAntivirus);
            this.tcAppCategories.Controls.Add(this.tpAppOfimatica);
            this.tcAppCategories.Controls.Add(this.tpAppProgramacion);
            this.tcAppCategories.Controls.Add(this.tpAppJuegos);
            this.tcAppCategories.Location = new System.Drawing.Point(356, 119);
            this.tcAppCategories.Name = "tcAppCategories";
            this.tcAppCategories.SelectedIndex = 4;
            this.tcAppCategories.Size = new System.Drawing.Size(987, 586);
            this.tcAppCategories.TabIndex = 4;
            this.tcAppCategories.UseSelectable = true;
            // 
            // tpAppInternet
            // 
            this.tpAppInternet.Controls.Add(this.dgvAppInternet);
            this.tpAppInternet.HorizontalScrollbarBarColor = true;
            this.tpAppInternet.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppInternet.HorizontalScrollbarSize = 10;
            this.tpAppInternet.Location = new System.Drawing.Point(4, 38);
            this.tpAppInternet.Name = "tpAppInternet";
            this.tpAppInternet.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppInternet.Size = new System.Drawing.Size(979, 544);
            this.tpAppInternet.TabIndex = 0;
            this.tpAppInternet.Text = "Internet";
            this.tpAppInternet.UseVisualStyleBackColor = true;
            this.tpAppInternet.VerticalScrollbarBarColor = true;
            this.tpAppInternet.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppInternet.VerticalScrollbarSize = 10;
            // 
            // dgvAppInternet
            // 
            this.dgvAppInternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppInternet.Location = new System.Drawing.Point(0, 6);
            this.dgvAppInternet.Name = "dgvAppInternet";
            this.dgvAppInternet.Size = new System.Drawing.Size(979, 538);
            this.dgvAppInternet.TabIndex = 3;
            // 
            // tpAppAntivirus
            // 
            this.tpAppAntivirus.Controls.Add(this.dgvAppAntivirus);
            this.tpAppAntivirus.HorizontalScrollbarBarColor = true;
            this.tpAppAntivirus.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppAntivirus.HorizontalScrollbarSize = 10;
            this.tpAppAntivirus.Location = new System.Drawing.Point(4, 38);
            this.tpAppAntivirus.Name = "tpAppAntivirus";
            this.tpAppAntivirus.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppAntivirus.Size = new System.Drawing.Size(979, 544);
            this.tpAppAntivirus.TabIndex = 2;
            this.tpAppAntivirus.Text = "Antivirus";
            this.tpAppAntivirus.UseVisualStyleBackColor = true;
            this.tpAppAntivirus.VerticalScrollbarBarColor = true;
            this.tpAppAntivirus.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppAntivirus.VerticalScrollbarSize = 10;
            // 
            // dgvAppAntivirus
            // 
            this.dgvAppAntivirus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppAntivirus.Location = new System.Drawing.Point(0, 6);
            this.dgvAppAntivirus.Name = "dgvAppAntivirus";
            this.dgvAppAntivirus.Size = new System.Drawing.Size(979, 538);
            this.dgvAppAntivirus.TabIndex = 2;
            // 
            // tpAppOfimatica
            // 
            this.tpAppOfimatica.Controls.Add(this.dgvAppOfimatica);
            this.tpAppOfimatica.HorizontalScrollbarBarColor = true;
            this.tpAppOfimatica.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppOfimatica.HorizontalScrollbarSize = 10;
            this.tpAppOfimatica.Location = new System.Drawing.Point(4, 38);
            this.tpAppOfimatica.Name = "tpAppOfimatica";
            this.tpAppOfimatica.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppOfimatica.Size = new System.Drawing.Size(979, 544);
            this.tpAppOfimatica.TabIndex = 1;
            this.tpAppOfimatica.Text = "Ofimatica";
            this.tpAppOfimatica.UseVisualStyleBackColor = true;
            this.tpAppOfimatica.VerticalScrollbarBarColor = true;
            this.tpAppOfimatica.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppOfimatica.VerticalScrollbarSize = 10;
            // 
            // dgvAppOfimatica
            // 
            this.dgvAppOfimatica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppOfimatica.Location = new System.Drawing.Point(0, 6);
            this.dgvAppOfimatica.Name = "dgvAppOfimatica";
            this.dgvAppOfimatica.Size = new System.Drawing.Size(979, 538);
            this.dgvAppOfimatica.TabIndex = 2;
            // 
            // tpAppProgramacion
            // 
            this.tpAppProgramacion.Controls.Add(this.dgvAppProgramacion);
            this.tpAppProgramacion.HorizontalScrollbarBarColor = true;
            this.tpAppProgramacion.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppProgramacion.HorizontalScrollbarSize = 10;
            this.tpAppProgramacion.Location = new System.Drawing.Point(4, 38);
            this.tpAppProgramacion.Name = "tpAppProgramacion";
            this.tpAppProgramacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppProgramacion.Size = new System.Drawing.Size(979, 544);
            this.tpAppProgramacion.TabIndex = 3;
            this.tpAppProgramacion.Text = "Programacion";
            this.tpAppProgramacion.UseVisualStyleBackColor = true;
            this.tpAppProgramacion.VerticalScrollbarBarColor = true;
            this.tpAppProgramacion.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppProgramacion.VerticalScrollbarSize = 10;
            // 
            // dgvAppProgramacion
            // 
            this.dgvAppProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppProgramacion.Location = new System.Drawing.Point(0, 6);
            this.dgvAppProgramacion.Name = "dgvAppProgramacion";
            this.dgvAppProgramacion.Size = new System.Drawing.Size(979, 538);
            this.dgvAppProgramacion.TabIndex = 2;
            // 
            // tpAppJuegos
            // 
            this.tpAppJuegos.Controls.Add(this.dgvAppJuegos);
            this.tpAppJuegos.HorizontalScrollbarBarColor = true;
            this.tpAppJuegos.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppJuegos.HorizontalScrollbarSize = 10;
            this.tpAppJuegos.Location = new System.Drawing.Point(4, 38);
            this.tpAppJuegos.Name = "tpAppJuegos";
            this.tpAppJuegos.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppJuegos.Size = new System.Drawing.Size(979, 544);
            this.tpAppJuegos.TabIndex = 4;
            this.tpAppJuegos.Text = "Juegos";
            this.tpAppJuegos.UseVisualStyleBackColor = true;
            this.tpAppJuegos.VerticalScrollbarBarColor = true;
            this.tpAppJuegos.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppJuegos.VerticalScrollbarSize = 10;
            // 
            // dgvAppJuegos
            // 
            this.dgvAppJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppJuegos.Location = new System.Drawing.Point(0, 6);
            this.dgvAppJuegos.Name = "dgvAppJuegos";
            this.dgvAppJuegos.Size = new System.Drawing.Size(979, 538);
            this.dgvAppJuegos.TabIndex = 2;
            // 
            // AppGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.tcAppCategories);
            this.Controls.Add(this.tbAppSearch);
            this.Controls.Add(this.dgvAppInstalled);
            this.Name = "AppGestor";
            this.Text = "AppGestor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInstalled)).EndInit();
            this.tcAppCategories.ResumeLayout(false);
            this.tpAppInternet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInternet)).EndInit();
            this.tpAppAntivirus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppAntivirus)).EndInit();
            this.tpAppOfimatica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppOfimatica)).EndInit();
            this.tpAppProgramacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppProgramacion)).EndInit();
            this.tpAppJuegos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppInstalled;
        private MetroTextBox tbAppSearch;
        private MetroTabPage tpAppInternet;
        private MetroTabPage tpAppOfimatica;
        private MetroTabPage tpAppAntivirus;
        private MetroTabPage tpAppProgramacion;
        private MetroTabPage tpAppJuegos;
        private MetroTabControl tcAppCategories;
        private System.Windows.Forms.DataGridView dgvAppInternet;
        private System.Windows.Forms.DataGridView dgvAppAntivirus;
        private System.Windows.Forms.DataGridView dgvAppOfimatica;
        private System.Windows.Forms.DataGridView dgvAppProgramacion;
        private System.Windows.Forms.DataGridView dgvAppJuegos;
    }
}

