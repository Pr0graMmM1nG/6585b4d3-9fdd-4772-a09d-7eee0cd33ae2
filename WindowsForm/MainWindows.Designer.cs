namespace WindowsForm
{
    partial class MainWindows
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.grBxMain = new System.Windows.Forms.GroupBox();
            this.lblFurnizorName = new System.Windows.Forms.Label();
            this.txtBxPriceValue = new System.Windows.Forms.TextBox();
            this.pictureBxResource = new System.Windows.Forms.PictureBox();
            this.cmBxFurnizorName = new System.Windows.Forms.ComboBox();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.cmBxResourceName = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.cmBxUnits = new System.Windows.Forms.ComboBox();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimeCalendar = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.grBxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxResource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFind);
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 29);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(694, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(46, 2);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(642, 24);
            this.txtBxSearch.TabIndex = 1;
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(8, 7);
            this.lblFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(33, 16);
            this.lblFind.TabIndex = 13;
            this.lblFind.Text = "Find";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(2, 225);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(780, 246);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabPage1.Size = new System.Drawing.Size(772, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Price List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(768, 207);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // grBxMain
            // 
            this.grBxMain.Controls.Add(this.lblData);
            this.grBxMain.Controls.Add(this.dateTimeCalendar);
            this.grBxMain.Controls.Add(this.btnSave);
            this.grBxMain.Controls.Add(this.lblPriceValue);
            this.grBxMain.Controls.Add(this.cmBxUnits);
            this.grBxMain.Controls.Add(this.lblUnits);
            this.grBxMain.Controls.Add(this.cmBxResourceName);
            this.grBxMain.Controls.Add(this.lblResourceName);
            this.grBxMain.Controls.Add(this.cmBxFurnizorName);
            this.grBxMain.Controls.Add(this.pictureBxResource);
            this.grBxMain.Controls.Add(this.txtBxPriceValue);
            this.grBxMain.Controls.Add(this.lblFurnizorName);
            this.grBxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxMain.Location = new System.Drawing.Point(2, 35);
            this.grBxMain.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grBxMain.Name = "grBxMain";
            this.grBxMain.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grBxMain.Size = new System.Drawing.Size(780, 180);
            this.grBxMain.TabIndex = 1;
            this.grBxMain.TabStop = false;
            this.grBxMain.Text = "Resource";
            // 
            // lblFurnizorName
            // 
            this.lblFurnizorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFurnizorName.AutoSize = true;
            this.lblFurnizorName.Location = new System.Drawing.Point(73, 25);
            this.lblFurnizorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFurnizorName.Name = "lblFurnizorName";
            this.lblFurnizorName.Size = new System.Drawing.Size(57, 16);
            this.lblFurnizorName.TabIndex = 0;
            this.lblFurnizorName.Text = "Furnizor";
            // 
            // txtBxPriceValue
            // 
            this.txtBxPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBxPriceValue.BackColor = System.Drawing.Color.White;
            this.txtBxPriceValue.Location = new System.Drawing.Point(204, 138);
            this.txtBxPriceValue.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtBxPriceValue.Name = "txtBxPriceValue";
            this.txtBxPriceValue.Size = new System.Drawing.Size(195, 24);
            this.txtBxPriceValue.TabIndex = 1;
            this.txtBxPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxPriceValue.Click += new System.EventHandler(this.txtBxPriceValue_Click);
            // 
            // pictureBxResource
            // 
            this.pictureBxResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBxResource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBxResource.Location = new System.Drawing.Point(622, 26);
            this.pictureBxResource.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBxResource.Name = "pictureBxResource";
            this.pictureBxResource.Size = new System.Drawing.Size(149, 141);
            this.pictureBxResource.TabIndex = 2;
            this.pictureBxResource.TabStop = false;
            // 
            // cmBxFurnizorName
            // 
            this.cmBxFurnizorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmBxFurnizorName.BackColor = System.Drawing.Color.White;
            this.cmBxFurnizorName.FormattingEnabled = true;
            this.cmBxFurnizorName.Location = new System.Drawing.Point(70, 43);
            this.cmBxFurnizorName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxFurnizorName.Name = "cmBxFurnizorName";
            this.cmBxFurnizorName.Size = new System.Drawing.Size(200, 24);
            this.cmBxFurnizorName.TabIndex = 3;
            // 
            // lblResourceName
            // 
            this.lblResourceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Location = new System.Drawing.Point(73, 73);
            this.lblResourceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(62, 16);
            this.lblResourceName.TabIndex = 4;
            this.lblResourceName.Text = "Resource";
            // 
            // cmBxResourceName
            // 
            this.cmBxResourceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmBxResourceName.BackColor = System.Drawing.Color.White;
            this.cmBxResourceName.FormattingEnabled = true;
            this.cmBxResourceName.Location = new System.Drawing.Point(70, 91);
            this.cmBxResourceName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxResourceName.Name = "cmBxResourceName";
            this.cmBxResourceName.Size = new System.Drawing.Size(531, 24);
            this.cmBxResourceName.TabIndex = 5;
            // 
            // lblUnits
            // 
            this.lblUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(73, 120);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(40, 16);
            this.lblUnits.TabIndex = 6;
            this.lblUnits.Text = "Units";
            // 
            // cmBxUnits
            // 
            this.cmBxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmBxUnits.FormattingEnabled = true;
            this.cmBxUnits.Location = new System.Drawing.Point(69, 138);
            this.cmBxUnits.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxUnits.Name = "cmBxUnits";
            this.cmBxUnits.Size = new System.Drawing.Size(108, 24);
            this.cmBxUnits.TabIndex = 7;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(207, 119);
            this.lblPriceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(73, 16);
            this.lblPriceValue.TabIndex = 8;
            this.lblPriceValue.Text = "Price Value";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave.Location = new System.Drawing.Point(426, 134);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimeCalendar
            // 
            this.dateTimeCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimeCalendar.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeCalendar.Location = new System.Drawing.Point(427, 43);
            this.dateTimeCalendar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dateTimeCalendar.Name = "dateTimeCalendar";
            this.dateTimeCalendar.Size = new System.Drawing.Size(174, 24);
            this.dateTimeCalendar.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(390, 47);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 16);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.importToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.grBxMain, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.tabControlMain, 0, 2);
            this.MainLayoutPanel.Controls.Add(this.panel1, 0, 3);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 4;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(784, 511);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Amazing Grotesk", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price List - Windows";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.grBxMain.ResumeLayout(false);
            this.grBxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxResource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.GroupBox grBxMain;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimeCalendar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.ComboBox cmBxUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.ComboBox cmBxResourceName;
        private System.Windows.Forms.Label lblResourceName;
        private System.Windows.Forms.ComboBox cmBxFurnizorName;
        private System.Windows.Forms.PictureBox pictureBxResource;
        private System.Windows.Forms.TextBox txtBxPriceValue;
        private System.Windows.Forms.Label lblFurnizorName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
    }
}

