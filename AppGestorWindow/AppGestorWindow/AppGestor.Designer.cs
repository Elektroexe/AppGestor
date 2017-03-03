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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAppSearch = new MetroFramework.Controls.MetroTextBox();
            this.tcAppCategories = new MetroFramework.Controls.MetroTabControl();
            this.tpAppInternet = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppInternet = new MetroFramework.Controls.MetroGrid();
            this.tpAppAntivirus = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppAntivirus = new MetroFramework.Controls.MetroGrid();
            this.tpAppOfimatica = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppOfimatica = new MetroFramework.Controls.MetroGrid();
            this.tpAppProgramacion = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppProgramacion = new MetroFramework.Controls.MetroGrid();
            this.tpAppJuegos = new MetroFramework.Controls.MetroTabPage();
            this.dgvAppJuegos = new MetroFramework.Controls.MetroGrid();
            this.dgvAppInstalled = new MetroFramework.Controls.MetroGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInstalled)).BeginInit();
            this.SuspendLayout();
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
            this.tcAppCategories.ItemSize = new System.Drawing.Size(60, 34);
            this.tcAppCategories.Location = new System.Drawing.Point(356, 119);
            this.tcAppCategories.Name = "tcAppCategories";
            this.tcAppCategories.SelectedIndex = 0;
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
            this.dgvAppInternet.AllowUserToResizeRows = false;
            this.dgvAppInternet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppInternet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppInternet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppInternet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppInternet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppInternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppInternet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppInternet.EnableHeadersVisualStyles = false;
            this.dgvAppInternet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppInternet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppInternet.Location = new System.Drawing.Point(0, 6);
            this.dgvAppInternet.Name = "dgvAppInternet";
            this.dgvAppInternet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppInternet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppInternet.RowHeadersVisible = false;
            this.dgvAppInternet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppInternet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppInternet.Size = new System.Drawing.Size(979, 538);
            this.dgvAppInternet.TabIndex = 2;
            this.dgvAppInternet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventCellContentDoubleClick);
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
            this.dgvAppAntivirus.AllowUserToResizeRows = false;
            this.dgvAppAntivirus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppAntivirus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppAntivirus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppAntivirus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppAntivirus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppAntivirus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppAntivirus.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppAntivirus.EnableHeadersVisualStyles = false;
            this.dgvAppAntivirus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppAntivirus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppAntivirus.Location = new System.Drawing.Point(0, 6);
            this.dgvAppAntivirus.Name = "dgvAppAntivirus";
            this.dgvAppAntivirus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppAntivirus.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppAntivirus.RowHeadersVisible = false;
            this.dgvAppAntivirus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppAntivirus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppAntivirus.Size = new System.Drawing.Size(979, 538);
            this.dgvAppAntivirus.TabIndex = 2;
            this.dgvAppAntivirus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventCellContentDoubleClick);
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
            this.dgvAppOfimatica.AllowUserToResizeRows = false;
            this.dgvAppOfimatica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppOfimatica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppOfimatica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppOfimatica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppOfimatica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAppOfimatica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppOfimatica.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAppOfimatica.EnableHeadersVisualStyles = false;
            this.dgvAppOfimatica.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppOfimatica.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppOfimatica.Location = new System.Drawing.Point(0, 6);
            this.dgvAppOfimatica.Name = "dgvAppOfimatica";
            this.dgvAppOfimatica.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppOfimatica.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAppOfimatica.RowHeadersVisible = false;
            this.dgvAppOfimatica.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppOfimatica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppOfimatica.Size = new System.Drawing.Size(979, 538);
            this.dgvAppOfimatica.TabIndex = 2;
            this.dgvAppOfimatica.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventCellContentDoubleClick);
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
            this.dgvAppProgramacion.AllowUserToResizeRows = false;
            this.dgvAppProgramacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppProgramacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppProgramacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppProgramacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAppProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppProgramacion.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAppProgramacion.EnableHeadersVisualStyles = false;
            this.dgvAppProgramacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppProgramacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppProgramacion.Location = new System.Drawing.Point(0, 6);
            this.dgvAppProgramacion.Name = "dgvAppProgramacion";
            this.dgvAppProgramacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppProgramacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAppProgramacion.RowHeadersVisible = false;
            this.dgvAppProgramacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppProgramacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppProgramacion.Size = new System.Drawing.Size(979, 538);
            this.dgvAppProgramacion.TabIndex = 2;
            this.dgvAppProgramacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventCellContentDoubleClick);
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
            this.dgvAppJuegos.AllowUserToResizeRows = false;
            this.dgvAppJuegos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppJuegos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppJuegos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAppJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppJuegos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAppJuegos.EnableHeadersVisualStyles = false;
            this.dgvAppJuegos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppJuegos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppJuegos.Location = new System.Drawing.Point(0, 6);
            this.dgvAppJuegos.Name = "dgvAppJuegos";
            this.dgvAppJuegos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppJuegos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAppJuegos.RowHeadersVisible = false;
            this.dgvAppJuegos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppJuegos.Size = new System.Drawing.Size(979, 538);
            this.dgvAppJuegos.TabIndex = 2;
            this.dgvAppJuegos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventCellContentDoubleClick);
            // 
            // dgvAppInstalled
            // 
            this.dgvAppInstalled.AllowUserToAddRows = false;
            this.dgvAppInstalled.AllowUserToResizeRows = false;
            this.dgvAppInstalled.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppInstalled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppInstalled.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppInstalled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppInstalled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAppInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppInstalled.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAppInstalled.EnableHeadersVisualStyles = false;
            this.dgvAppInstalled.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppInstalled.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppInstalled.Location = new System.Drawing.Point(36, 74);
            this.dgvAppInstalled.MultiSelect = false;
            this.dgvAppInstalled.Name = "dgvAppInstalled";
            this.dgvAppInstalled.ReadOnly = true;
            this.dgvAppInstalled.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppInstalled.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAppInstalled.RowHeadersVisible = false;
            this.dgvAppInstalled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppInstalled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppInstalled.Size = new System.Drawing.Size(281, 627);
            this.dgvAppInstalled.TabIndex = 5;
            // 
            // AppGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.dgvAppInstalled);
            this.Controls.Add(this.tcAppCategories);
            this.Controls.Add(this.tbAppSearch);
            this.Name = "AppGestor";
            this.Text = "AppGestor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppGestor_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppInstalled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroTextBox tbAppSearch;
        private MetroTabPage tpAppInternet;
        private MetroTabPage tpAppOfimatica;
        private MetroTabPage tpAppAntivirus;
        private MetroTabPage tpAppProgramacion;
        private MetroTabPage tpAppJuegos;
        private MetroTabControl tcAppCategories;
        private MetroGrid dgvAppInstalled;
        private MetroGrid dgvAppInternet;
        private MetroGrid dgvAppAntivirus;
        private MetroGrid dgvAppOfimatica;
        private MetroGrid dgvAppProgramacion;
        private MetroGrid dgvAppJuegos;
    }
}

