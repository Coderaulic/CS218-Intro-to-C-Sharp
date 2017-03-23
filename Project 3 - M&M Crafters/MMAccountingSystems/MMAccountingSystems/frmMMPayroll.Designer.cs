namespace MMAccountingSystems
{
    partial class frmMMPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMMPayroll));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ttpMMPayroll = new System.Windows.Forms.ToolTip(this.components);
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.updDependents = new System.Windows.Forms.NumericUpDown();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparatorTwo = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFunctionsAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFunctionsDisplayTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFunctionsSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDependents = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDisplayTotal = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pfMMPayroll = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.pdMMPayroll = new System.Drawing.Printing.PrintDocument();
            this.ppdMMPayroll = new System.Windows.Forms.PrintPreviewDialog();
            this.gbxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDependents)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.gbxEmployeeInfo.SuspendLayout();
            this.gbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Location = new System.Drawing.Point(447, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(64, 60);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // cboDepartments
            // 
            this.cboDepartments.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cboDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(129, 85);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDepartments.Size = new System.Drawing.Size(221, 27);
            this.cboDepartments.TabIndex = 4;
            this.ttpMMPayroll.SetToolTip(this.cboDepartments, "Select a Department that the employee works for");
            // 
            // updDependents
            // 
            this.updDependents.Location = new System.Drawing.Point(310, 52);
            this.updDependents.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updDependents.Name = "updDependents";
            this.updDependents.ReadOnly = true;
            this.updDependents.Size = new System.Drawing.Size(40, 26);
            this.updDependents.TabIndex = 3;
            this.updDependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpMMPayroll.SetToolTip(this.updDependents, "Select number of dependents: Max 10");
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(129, 19);
            this.txtEmployeeName.MaxLength = 20;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(221, 26);
            this.txtEmployeeName.TabIndex = 1;
            this.ttpMMPayroll.SetToolTip(this.txtEmployeeName, "Enter Name of employee: Minimum of 3 characters.");
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(129, 51);
            this.txtHours.MaxLength = 3;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(79, 26);
            this.txtHours.TabIndex = 2;
            this.ttpMMPayroll.SetToolTip(this.txtHours, "Enter numbers from 1 to 168. (Weekly Hours Worked)");
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(129, 128);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 26);
            this.txtSearch.TabIndex = 11;
            this.ttpMMPayroll.SetToolTip(this.txtSearch, "Enter Name of employee: Minimum of 3 characters.");
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFunctions,
            this.mnuHelp});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(527, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClear,
            this.mnuFileSeparatorOne,
            this.mnuFilePrint,
            this.mnuFilePrintForm,
            this.mnuFileSeparatorTwo,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Enabled = false;
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuFileClear.Size = new System.Drawing.Size(139, 22);
            this.mnuFileClear.Text = "&Clear";
            this.mnuFileClear.ToolTipText = "Clear the form to default state.";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // mnuFileSeparatorOne
            // 
            this.mnuFileSeparatorOne.Name = "mnuFileSeparatorOne";
            this.mnuFileSeparatorOne.Size = new System.Drawing.Size(136, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Enabled = false;
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mnuFilePrint.Size = new System.Drawing.Size(139, 22);
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.ToolTipText = "Select to print the list box";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // mnuFilePrintForm
            // 
            this.mnuFilePrintForm.Enabled = false;
            this.mnuFilePrintForm.Name = "mnuFilePrintForm";
            this.mnuFilePrintForm.Size = new System.Drawing.Size(139, 22);
            this.mnuFilePrintForm.Text = "Print &Form";
            this.mnuFilePrintForm.ToolTipText = "Select to print the form.";
            this.mnuFilePrintForm.Click += new System.EventHandler(this.mnuFilePrintForm_Click);
            // 
            // mnuFileSeparatorTwo
            // 
            this.mnuFileSeparatorTwo.Name = "mnuFileSeparatorTwo";
            this.mnuFileSeparatorTwo.Size = new System.Drawing.Size(136, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.mnuFileExit.Size = new System.Drawing.Size(139, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.ToolTipText = "Select to exit the program.";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFunctions
            // 
            this.mnuFunctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFunctionsAddEmployee,
            this.mnuFunctionsDisplayTotal,
            this.mnuFunctionsSearch});
            this.mnuFunctions.Name = "mnuFunctions";
            this.mnuFunctions.Size = new System.Drawing.Size(71, 20);
            this.mnuFunctions.Text = "F&unctions";
            // 
            // mnuFunctionsAddEmployee
            // 
            this.mnuFunctionsAddEmployee.Name = "mnuFunctionsAddEmployee";
            this.mnuFunctionsAddEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuFunctionsAddEmployee.Size = new System.Drawing.Size(189, 22);
            this.mnuFunctionsAddEmployee.Text = "&Add Employee";
            this.mnuFunctionsAddEmployee.ToolTipText = "Select to add a new employee to the list.";
            this.mnuFunctionsAddEmployee.Click += new System.EventHandler(this.mnuFunctionsAddEmployee_Click);
            // 
            // mnuFunctionsDisplayTotal
            // 
            this.mnuFunctionsDisplayTotal.Enabled = false;
            this.mnuFunctionsDisplayTotal.Name = "mnuFunctionsDisplayTotal";
            this.mnuFunctionsDisplayTotal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.mnuFunctionsDisplayTotal.Size = new System.Drawing.Size(189, 22);
            this.mnuFunctionsDisplayTotal.Text = "&Display Total";
            this.mnuFunctionsDisplayTotal.ToolTipText = "Display the Total Weekly Net Pay Amount.";
            this.mnuFunctionsDisplayTotal.Click += new System.EventHandler(this.mnuFunctionsDisplayTotal_Click);
            // 
            // mnuFunctionsSearch
            // 
            this.mnuFunctionsSearch.Enabled = false;
            this.mnuFunctionsSearch.Name = "mnuFunctionsSearch";
            this.mnuFunctionsSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuFunctionsSearch.Size = new System.Drawing.Size(189, 22);
            this.mnuFunctionsSearch.Text = "&Search";
            this.mnuFunctionsSearch.ToolTipText = "Search for an employee name on the list.";
            this.mnuFunctionsSearch.Click += new System.EventHandler(this.mnuFunctionsSearch_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuHelpAbout.Size = new System.Drawing.Size(145, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.ToolTipText = "Select to learn more about this program.";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Blue;
            this.lblLogo.Location = new System.Drawing.Point(8, 28);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(415, 46);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Welcome to M && M Payroll Accounting Systems";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 15;
            this.lstDisplay.Location = new System.Drawing.Point(12, 248);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDisplay.Size = new System.Drawing.Size(499, 154);
            this.lstDisplay.TabIndex = 12;
            // 
            // lblDepartments
            // 
            this.lblDepartments.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(23, 86);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(100, 23);
            this.lblDepartments.TabIndex = 5;
            this.lblDepartments.Text = "Department";
            this.lblDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(65, 52);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(58, 23);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(6, 20);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(124, 23);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Employee Name";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDependents
            // 
            this.lblDependents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependents.Location = new System.Drawing.Point(212, 52);
            this.lblDependents.Name = "lblDependents";
            this.lblDependents.Size = new System.Drawing.Size(92, 23);
            this.lblDependents.TabIndex = 8;
            this.lblDependents.Text = "Dependants";
            this.lblDependents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 16);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 25);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "&Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDisplayTotal
            // 
            this.btnDisplayTotal.Enabled = false;
            this.btnDisplayTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTotal.Location = new System.Drawing.Point(6, 47);
            this.btnDisplayTotal.Name = "btnDisplayTotal";
            this.btnDisplayTotal.Size = new System.Drawing.Size(120, 25);
            this.btnDisplayTotal.TabIndex = 6;
            this.btnDisplayTotal.Text = "&DisplayTotal";
            this.btnDisplayTotal.UseVisualStyleBackColor = true;
            this.btnDisplayTotal.Click += new System.EventHandler(this.btnDisplayTotal_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(6, 77);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 25);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(6, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(27, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pfMMPayroll
            // 
            this.pfMMPayroll.DocumentName = "document";
            this.pfMMPayroll.Form = this;
            this.pfMMPayroll.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.pfMMPayroll.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("pfMMPayroll.PrinterSettings")));
            this.pfMMPayroll.PrintFileName = null;
            // 
            // pdMMPayroll
            // 
            this.pdMMPayroll.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdMMPayroll_PrintPage);
            // 
            // ppdMMPayroll
            // 
            this.ppdMMPayroll.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdMMPayroll.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdMMPayroll.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdMMPayroll.Document = this.pdMMPayroll;
            this.ppdMMPayroll.Enabled = true;
            this.ppdMMPayroll.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdMMPayroll.Icon")));
            this.ppdMMPayroll.Name = "printPreviewDialog1";
            this.ppdMMPayroll.Visible = false;
            // 
            // gbxEmployeeInfo
            // 
            this.gbxEmployeeInfo.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeInfo.Controls.Add(this.txtSearch);
            this.gbxEmployeeInfo.Controls.Add(this.cboDepartments);
            this.gbxEmployeeInfo.Controls.Add(this.btnSearch);
            this.gbxEmployeeInfo.Controls.Add(this.lblDepartments);
            this.gbxEmployeeInfo.Controls.Add(this.lblHours);
            this.gbxEmployeeInfo.Controls.Add(this.lblEmployeeName);
            this.gbxEmployeeInfo.Controls.Add(this.lblDependents);
            this.gbxEmployeeInfo.Controls.Add(this.updDependents);
            this.gbxEmployeeInfo.Controls.Add(this.txtHours);
            this.gbxEmployeeInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployeeInfo.Location = new System.Drawing.Point(12, 77);
            this.gbxEmployeeInfo.Name = "gbxEmployeeInfo";
            this.gbxEmployeeInfo.Size = new System.Drawing.Size(358, 165);
            this.gbxEmployeeInfo.TabIndex = 13;
            this.gbxEmployeeInfo.TabStop = false;
            this.gbxEmployeeInfo.Text = "Enter Employee Information";
            // 
            // gbxControls
            // 
            this.gbxControls.Controls.Add(this.btnAddEmployee);
            this.gbxControls.Controls.Add(this.btnExit);
            this.gbxControls.Controls.Add(this.btnClear);
            this.gbxControls.Controls.Add(this.btnDisplayTotal);
            this.gbxControls.Controls.Add(this.btnPrint);
            this.gbxControls.Location = new System.Drawing.Point(376, 77);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(135, 165);
            this.gbxControls.TabIndex = 14;
            this.gbxControls.TabStop = false;
            // 
            // frmMMPayroll
            // 
            this.AcceptButton = this.btnAddEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(527, 415);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxEmployeeInfo);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMMPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M & M Accounting Systems";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDependents)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.gbxEmployeeInfo.ResumeLayout(false);
            this.gbxEmployeeInfo.PerformLayout();
            this.gbxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip ttpMMPayroll;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparatorOne;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintForm;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparatorTwo;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFunctions;
        private System.Windows.Forms.ToolStripMenuItem mnuFunctionsAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuFunctionsDisplayTotal;
        private System.Windows.Forms.ToolStripMenuItem mnuFunctionsSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ComboBox cboDepartments;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.NumericUpDown updDependents;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDisplayTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm pfMMPayroll;
        private System.Drawing.Printing.PrintDocument pdMMPayroll;
        private System.Windows.Forms.PrintPreviewDialog ppdMMPayroll;
        private System.Windows.Forms.GroupBox gbxEmployeeInfo;
        private System.Windows.Forms.GroupBox gbxControls;
    }
}

