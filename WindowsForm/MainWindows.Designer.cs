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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grBxMain = new System.Windows.Forms.GroupBox();
            this.cmBxFurnizorName = new System.Windows.Forms.ComboBox();
            this.pictureBxResource = new System.Windows.Forms.PictureBox();
            this.txtBxPriceValue = new System.Windows.Forms.TextBox();
            this.lblFurnizorName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmBxResourceName = new System.Windows.Forms.ComboBox();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.cmBxUnits = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPriceCurrency = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.dateTimeCalendar = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.resourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grBxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxResource)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.grBxMain, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.toolStrip1, 0, 3);
            this.MainLayoutPanel.Controls.Add(this.tabControlMain, 0, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 4;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(934, 511);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.importToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
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
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourceToolStripMenuItem,
            this.furnizorToolStripMenuItem,
            this.uMToolStripMenuItem,
            this.uMToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.addToolStripMenuItem.Text = "Add";
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
            // grBxMain
            // 
            this.grBxMain.Controls.Add(this.lblData);
            this.grBxMain.Controls.Add(this.dateTimeCalendar);
            this.grBxMain.Controls.Add(this.btnSave);
            this.grBxMain.Controls.Add(this.lblPriceCurrency);
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
            this.grBxMain.Location = new System.Drawing.Point(2, 42);
            this.grBxMain.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grBxMain.Name = "grBxMain";
            this.grBxMain.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grBxMain.Size = new System.Drawing.Size(930, 172);
            this.grBxMain.TabIndex = 1;
            this.grBxMain.TabStop = false;
            this.grBxMain.Text = "Resource";
            // 
            // cmBxFurnizorName
            // 
            this.cmBxFurnizorName.BackColor = System.Drawing.Color.White;
            this.cmBxFurnizorName.FormattingEnabled = true;
            this.cmBxFurnizorName.Location = new System.Drawing.Point(70, 43);
            this.cmBxFurnizorName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxFurnizorName.Name = "cmBxFurnizorName";
            this.cmBxFurnizorName.Size = new System.Drawing.Size(139, 24);
            this.cmBxFurnizorName.TabIndex = 3;
            // 
            // pictureBxResource
            // 
            this.pictureBxResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBxResource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBxResource.Location = new System.Drawing.Point(771, 11);
            this.pictureBxResource.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBxResource.Name = "pictureBxResource";
            this.pictureBxResource.Size = new System.Drawing.Size(142, 159);
            this.pictureBxResource.TabIndex = 2;
            this.pictureBxResource.TabStop = false;
            // 
            // txtBxPriceValue
            // 
            this.txtBxPriceValue.BackColor = System.Drawing.Color.White;
            this.txtBxPriceValue.Location = new System.Drawing.Point(142, 134);
            this.txtBxPriceValue.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtBxPriceValue.Name = "txtBxPriceValue";
            this.txtBxPriceValue.Size = new System.Drawing.Size(195, 24);
            this.txtBxPriceValue.TabIndex = 1;
            this.txtBxPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFurnizorName
            // 
            this.lblFurnizorName.AutoSize = true;
            this.lblFurnizorName.Location = new System.Drawing.Point(65, 22);
            this.lblFurnizorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFurnizorName.Name = "lblFurnizorName";
            this.lblFurnizorName.Size = new System.Drawing.Size(57, 16);
            this.lblFurnizorName.TabIndex = 0;
            this.lblFurnizorName.Text = "Furnizor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.Location = new System.Drawing.Point(0, 481);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(2, 224);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(930, 252);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.tabPage1.Size = new System.Drawing.Size(922, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Price List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmBxResourceName
            // 
            this.cmBxResourceName.BackColor = System.Drawing.Color.White;
            this.cmBxResourceName.FormattingEnabled = true;
            this.cmBxResourceName.Location = new System.Drawing.Point(70, 95);
            this.cmBxResourceName.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxResourceName.Name = "cmBxResourceName";
            this.cmBxResourceName.Size = new System.Drawing.Size(531, 24);
            this.cmBxResourceName.TabIndex = 5;
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Location = new System.Drawing.Point(65, 75);
            this.lblResourceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(62, 16);
            this.lblResourceName.TabIndex = 4;
            this.lblResourceName.Text = "Resource";
            // 
            // cmBxUnits
            // 
            this.cmBxUnits.FormattingEnabled = true;
            this.cmBxUnits.Location = new System.Drawing.Point(611, 95);
            this.cmBxUnits.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmBxUnits.Name = "cmBxUnits";
            this.cmBxUnits.Size = new System.Drawing.Size(139, 24);
            this.cmBxUnits.TabIndex = 7;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(609, 75);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(40, 16);
            this.lblUnits.TabIndex = 6;
            this.lblUnits.Text = "Units";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(66, 139);
            this.lblPriceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(73, 16);
            this.lblPriceValue.TabIndex = 8;
            this.lblPriceValue.Text = "Price Value";
            // 
            // lblPriceCurrency
            // 
            this.lblPriceCurrency.AutoSize = true;
            this.lblPriceCurrency.Location = new System.Drawing.Point(345, 139);
            this.lblPriceCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceCurrency.Name = "lblPriceCurrency";
            this.lblPriceCurrency.Size = new System.Drawing.Size(88, 16);
            this.lblPriceCurrency.TabIndex = 9;
            this.lblPriceCurrency.Text = "Lei [fara TVA]";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(612, 133);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.dataGridViewMain.Size = new System.Drawing.Size(918, 213);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // dateTimeCalendar
            // 
            this.dateTimeCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeCalendar.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeCalendar.Location = new System.Drawing.Point(521, 11);
            this.dateTimeCalendar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dateTimeCalendar.Name = "dateTimeCalendar";
            this.dateTimeCalendar.Size = new System.Drawing.Size(230, 24);
            this.dateTimeCalendar.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(472, 15);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 16);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // resourceToolStripMenuItem
            // 
            this.resourceToolStripMenuItem.Name = "resourceToolStripMenuItem";
            this.resourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resourceToolStripMenuItem.Text = "Resource";
            // 
            // furnizorToolStripMenuItem
            // 
            this.furnizorToolStripMenuItem.Name = "furnizorToolStripMenuItem";
            this.furnizorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.furnizorToolStripMenuItem.Text = "Furnizor";
            // 
            // uMToolStripMenuItem
            // 
            this.uMToolStripMenuItem.Name = "uMToolStripMenuItem";
            this.uMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uMToolStripMenuItem.Text = "Image";
            // 
            // uMToolStripMenuItem1
            // 
            this.uMToolStripMenuItem1.Name = "uMToolStripMenuItem1";
            this.uMToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.uMToolStripMenuItem1.Text = "U.M.";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Amazing Grotesk", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price List - Windows";
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBxMain.ResumeLayout(false);
            this.grBxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxResource)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grBxMain;
        private System.Windows.Forms.ComboBox cmBxFurnizorName;
        private System.Windows.Forms.PictureBox pictureBxResource;
        private System.Windows.Forms.TextBox txtBxPriceValue;
        private System.Windows.Forms.Label lblFurnizorName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmBxUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.ComboBox cmBxResourceName;
        private System.Windows.Forms.Label lblResourceName;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimeCalendar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPriceCurrency;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uMToolStripMenuItem1;
    }
}

