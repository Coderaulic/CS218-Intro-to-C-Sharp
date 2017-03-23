namespace FuzzyDiceOrderForm
{
    partial class frmFuzzyDiceOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuzzyDiceOrderForm));
            this.lblInformation = new System.Windows.Forms.Label();
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDisplayBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTypeWhiteBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTypeRedWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTypeBlueBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mtxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBlueBlackQuantity = new System.Windows.Forms.TextBox();
            this.txtRedWhiteQuantity = new System.Windows.Forms.TextBox();
            this.txtWhiteBlackQuantity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlOrderForm = new System.Windows.Forms.Panel();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblActualOrderNumber = new System.Windows.Forms.Label();
            this.lblBlueBlackPrice = new System.Windows.Forms.Label();
            this.lblRedWhitePrice = new System.Windows.Forms.Label();
            this.lblWhiteBlackPrice = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.chkBlueBlack = new System.Windows.Forms.CheckBox();
            this.chkRedWhite = new System.Windows.Forms.CheckBox();
            this.chkWhiteBlack = new System.Windows.Forms.CheckBox();
            this.lblTypeOfDice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cboShippingType = new System.Windows.Forms.ComboBox();
            this.lblShippingType = new System.Windows.Forms.Label();
            this.btnDisplayBill = new System.Windows.Forms.Button();
            this.pfFuzzyDiceOrderForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.mnuMainMenuStrip.SuspendLayout();
            this.pnlOrderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(12, 54);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(200, 105);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Fuzzy Dice Incorporated\r\n123 Gamble Away Street\r\nEdmonds, WA 98036\r\n(425)555-555\r" +
    "\nhttp//www.FuzzyDice.com\r\n";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuType,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(679, 24);
            this.mnuMainMenuStrip.TabIndex = 1;
            this.mnuMainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewOrder,
            this.mnuFileDisplayBill,
            this.mnuFilePrintInvoice,
            this.mnuFileClear,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewOrder
            // 
            this.mnuFileNewOrder.Name = "mnuFileNewOrder";
            this.mnuFileNewOrder.Size = new System.Drawing.Size(140, 22);
            this.mnuFileNewOrder.Text = "&New Order";
            this.mnuFileNewOrder.ToolTipText = "Start a New Order Form";
            this.mnuFileNewOrder.Click += new System.EventHandler(this.mnuFileNewOrder_Click);
            // 
            // mnuFileDisplayBill
            // 
            this.mnuFileDisplayBill.Name = "mnuFileDisplayBill";
            this.mnuFileDisplayBill.Size = new System.Drawing.Size(140, 22);
            this.mnuFileDisplayBill.Text = "&Display Bill";
            this.mnuFileDisplayBill.Click += new System.EventHandler(this.mnuFileDisplayBill_Click);
            // 
            // mnuFilePrintInvoice
            // 
            this.mnuFilePrintInvoice.Name = "mnuFilePrintInvoice";
            this.mnuFilePrintInvoice.Size = new System.Drawing.Size(140, 22);
            this.mnuFilePrintInvoice.Text = "&Print Invoice";
            this.mnuFilePrintInvoice.ToolTipText = "Print Entire Invoice";
            this.mnuFilePrintInvoice.Click += new System.EventHandler(this.mnuFilePrintInvoice_Click);
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.Size = new System.Drawing.Size(140, 22);
            this.mnuFileClear.Text = "&Clear";
            this.mnuFileClear.ToolTipText = "Clear the form";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(140, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.ToolTipText = "Exit the application";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuType
            // 
            this.mnuType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTypeWhiteBlack,
            this.mnuTypeRedWhite,
            this.mnuTypeBlueBlack});
            this.mnuType.Name = "mnuType";
            this.mnuType.Size = new System.Drawing.Size(45, 20);
            this.mnuType.Text = "&Type";
            this.mnuType.ToolTipText = "Select Type of Dice Order";
            // 
            // mnuTypeWhiteBlack
            // 
            this.mnuTypeWhiteBlack.Name = "mnuTypeWhiteBlack";
            this.mnuTypeWhiteBlack.Size = new System.Drawing.Size(138, 22);
            this.mnuTypeWhiteBlack.Text = "White/Black";
            this.mnuTypeWhiteBlack.Click += new System.EventHandler(this.mnuTypeWhiteBlack_Click);
            // 
            // mnuTypeRedWhite
            // 
            this.mnuTypeRedWhite.Name = "mnuTypeRedWhite";
            this.mnuTypeRedWhite.Size = new System.Drawing.Size(138, 22);
            this.mnuTypeRedWhite.Text = "Red/White";
            this.mnuTypeRedWhite.Click += new System.EventHandler(this.mnuTypeRedWhite_Click);
            // 
            // mnuTypeBlueBlack
            // 
            this.mnuTypeBlueBlack.Name = "mnuTypeBlueBlack";
            this.mnuTypeBlueBlack.Size = new System.Drawing.Size(138, 22);
            this.mnuTypeBlueBlack.Text = "Blue/Black";
            this.mnuTypeBlueBlack.Click += new System.EventHandler(this.mnuTypeBlueBlack_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.ToolTipText = "Additional Information";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.ToolTipText = "Display About Form";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mtxtZipCode
            // 
            this.mtxtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtZipCode.Location = new System.Drawing.Point(363, 80);
            this.mtxtZipCode.Mask = "00000-0000";
            this.mtxtZipCode.Name = "mtxtZipCode";
            this.mtxtZipCode.Size = new System.Drawing.Size(87, 22);
            this.mtxtZipCode.TabIndex = 15;
            this.mtxtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.mtxtZipCode, "Enter numerical values only XXXXX-XXXX");
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(15, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.ToolTip.SetToolTip(this.btnClear, "Clear the display");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(15, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.ToolTip.SetToolTip(this.btnExit, "Exit Application");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBlueBlackQuantity
            // 
            this.txtBlueBlackQuantity.Enabled = false;
            this.txtBlueBlackQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlueBlackQuantity.Location = new System.Drawing.Point(232, 110);
            this.txtBlueBlackQuantity.MaxLength = 2;
            this.txtBlueBlackQuantity.Name = "txtBlueBlackQuantity";
            this.txtBlueBlackQuantity.Size = new System.Drawing.Size(77, 22);
            this.txtBlueBlackQuantity.TabIndex = 14;
            this.txtBlueBlackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.txtBlueBlackQuantity, "Enter 2 digit numeric values 1-99");
            this.txtBlueBlackQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBlueBlack_KeyPress);
            // 
            // txtRedWhiteQuantity
            // 
            this.txtRedWhiteQuantity.Enabled = false;
            this.txtRedWhiteQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedWhiteQuantity.Location = new System.Drawing.Point(232, 80);
            this.txtRedWhiteQuantity.MaxLength = 2;
            this.txtRedWhiteQuantity.Name = "txtRedWhiteQuantity";
            this.txtRedWhiteQuantity.Size = new System.Drawing.Size(77, 22);
            this.txtRedWhiteQuantity.TabIndex = 13;
            this.txtRedWhiteQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.txtRedWhiteQuantity, "Enter 2 digit numeric values 1-99");
            this.txtRedWhiteQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedWhite_KeyPress);
            // 
            // txtWhiteBlackQuantity
            // 
            this.txtWhiteBlackQuantity.Enabled = false;
            this.txtWhiteBlackQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhiteBlackQuantity.Location = new System.Drawing.Point(232, 50);
            this.txtWhiteBlackQuantity.MaxLength = 2;
            this.txtWhiteBlackQuantity.Name = "txtWhiteBlackQuantity";
            this.txtWhiteBlackQuantity.Size = new System.Drawing.Size(77, 22);
            this.txtWhiteBlackQuantity.TabIndex = 12;
            this.txtWhiteBlackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.txtWhiteBlackQuantity, "Enter 2 digit numeric values 1-99");
            this.txtWhiteBlackQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhiteBlack_KeyPress);
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(245, 79);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(58, 22);
            this.txtState.TabIndex = 11;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.txtState, "Enter 2 letter State Header");
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(15, 148);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(157, 35);
            this.btnPrintInvoice.TabIndex = 2;
            this.btnPrintInvoice.Text = "&Print Invoice";
            this.ToolTip.SetToolTip(this.btnPrintInvoice, "Print GUI order form");
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(15, 107);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(157, 35);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "&New Order";
            this.ToolTip.SetToolTip(this.btnNewOrder, "Clear form to begin new order");
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlOrderForm
            // 
            this.pnlOrderForm.Controls.Add(this.lblOrderNumber);
            this.pnlOrderForm.Controls.Add(this.lblActualOrderNumber);
            this.pnlOrderForm.Controls.Add(this.txtBlueBlackQuantity);
            this.pnlOrderForm.Controls.Add(this.txtRedWhiteQuantity);
            this.pnlOrderForm.Controls.Add(this.txtWhiteBlackQuantity);
            this.pnlOrderForm.Controls.Add(this.lblBlueBlackPrice);
            this.pnlOrderForm.Controls.Add(this.lblRedWhitePrice);
            this.pnlOrderForm.Controls.Add(this.lblWhiteBlackPrice);
            this.pnlOrderForm.Controls.Add(this.picLogo);
            this.pnlOrderForm.Controls.Add(this.chkBlueBlack);
            this.pnlOrderForm.Controls.Add(this.chkRedWhite);
            this.pnlOrderForm.Controls.Add(this.chkWhiteBlack);
            this.pnlOrderForm.Controls.Add(this.lblTypeOfDice);
            this.pnlOrderForm.Controls.Add(this.lblPrice);
            this.pnlOrderForm.Controls.Add(this.lblQuantity);
            this.pnlOrderForm.Controls.Add(this.lblType);
            this.pnlOrderForm.Location = new System.Drawing.Point(218, 27);
            this.pnlOrderForm.Name = "pnlOrderForm";
            this.pnlOrderForm.Size = new System.Drawing.Size(449, 152);
            this.pnlOrderForm.TabIndex = 2;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(5, 38);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(69, 23);
            this.lblOrderNumber.TabIndex = 16;
            this.lblOrderNumber.Text = "Order #:";
            this.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActualOrderNumber
            // 
            this.lblActualOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualOrderNumber.Location = new System.Drawing.Point(67, 38);
            this.lblActualOrderNumber.Name = "lblActualOrderNumber";
            this.lblActualOrderNumber.Size = new System.Drawing.Size(48, 23);
            this.lblActualOrderNumber.TabIndex = 15;
            this.lblActualOrderNumber.Text = "9999";
            this.lblActualOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueBlackPrice
            // 
            this.lblBlueBlackPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueBlackPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueBlackPrice.Location = new System.Drawing.Point(347, 110);
            this.lblBlueBlackPrice.Name = "lblBlueBlackPrice";
            this.lblBlueBlackPrice.Size = new System.Drawing.Size(47, 23);
            this.lblBlueBlackPrice.TabIndex = 11;
            this.lblBlueBlackPrice.Text = "$7.50";
            this.lblBlueBlackPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRedWhitePrice
            // 
            this.lblRedWhitePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedWhitePrice.ForeColor = System.Drawing.Color.Red;
            this.lblRedWhitePrice.Location = new System.Drawing.Point(347, 80);
            this.lblRedWhitePrice.Name = "lblRedWhitePrice";
            this.lblRedWhitePrice.Size = new System.Drawing.Size(47, 23);
            this.lblRedWhitePrice.TabIndex = 10;
            this.lblRedWhitePrice.Text = "$5.00";
            this.lblRedWhitePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhiteBlackPrice
            // 
            this.lblWhiteBlackPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteBlackPrice.Location = new System.Drawing.Point(347, 50);
            this.lblWhiteBlackPrice.Name = "lblWhiteBlackPrice";
            this.lblWhiteBlackPrice.Size = new System.Drawing.Size(47, 23);
            this.lblWhiteBlackPrice.TabIndex = 9;
            this.lblWhiteBlackPrice.Text = "$6.25";
            this.lblWhiteBlackPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(8, 64);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(87, 70);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // chkBlueBlack
            // 
            this.chkBlueBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlueBlack.ForeColor = System.Drawing.Color.Blue;
            this.chkBlueBlack.Location = new System.Drawing.Point(121, 110);
            this.chkBlueBlack.Name = "chkBlueBlack";
            this.chkBlueBlack.Size = new System.Drawing.Size(105, 24);
            this.chkBlueBlack.TabIndex = 8;
            this.chkBlueBlack.Text = "Blue/Black";
            this.chkBlueBlack.UseVisualStyleBackColor = true;
            this.chkBlueBlack.CheckedChanged += new System.EventHandler(this.chkBlueBlack_CheckedChanged);
            // 
            // chkRedWhite
            // 
            this.chkRedWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRedWhite.ForeColor = System.Drawing.Color.Red;
            this.chkRedWhite.Location = new System.Drawing.Point(121, 80);
            this.chkRedWhite.Name = "chkRedWhite";
            this.chkRedWhite.Size = new System.Drawing.Size(105, 24);
            this.chkRedWhite.TabIndex = 7;
            this.chkRedWhite.Text = "Red/White";
            this.chkRedWhite.UseVisualStyleBackColor = true;
            this.chkRedWhite.CheckedChanged += new System.EventHandler(this.chkRedWhite_CheckedChanged);
            // 
            // chkWhiteBlack
            // 
            this.chkWhiteBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhiteBlack.Location = new System.Drawing.Point(121, 50);
            this.chkWhiteBlack.Name = "chkWhiteBlack";
            this.chkWhiteBlack.Size = new System.Drawing.Size(105, 24);
            this.chkWhiteBlack.TabIndex = 6;
            this.chkWhiteBlack.Text = "White/Black";
            this.chkWhiteBlack.UseVisualStyleBackColor = true;
            this.chkWhiteBlack.CheckedChanged += new System.EventHandler(this.chkWhiteBlack_CheckedChanged);
            // 
            // lblTypeOfDice
            // 
            this.lblTypeOfDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfDice.Location = new System.Drawing.Point(5, 9);
            this.lblTypeOfDice.Name = "lblTypeOfDice";
            this.lblTypeOfDice.Size = new System.Drawing.Size(101, 23);
            this.lblTypeOfDice.TabIndex = 3;
            this.lblTypeOfDice.Text = "Type of Dice:";
            this.lblTypeOfDice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(315, 9);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(122, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price per Order:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(234, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 23);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(118, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(101, 23);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type of Dice:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThanks
            // 
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.Blue;
            this.lblThanks.Location = new System.Drawing.Point(171, 465);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(337, 23);
            this.lblThanks.TabIndex = 15;
            this.lblThanks.Text = "Thank you for being our customer!";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.Controls.Add(this.lstDisplay);
            this.pnlCustomerInfo.Controls.Add(this.mtxtZipCode);
            this.pnlCustomerInfo.Controls.Add(this.lblZipCode);
            this.pnlCustomerInfo.Controls.Add(this.txtState);
            this.pnlCustomerInfo.Controls.Add(this.lblState);
            this.pnlCustomerInfo.Controls.Add(this.txtCity);
            this.pnlCustomerInfo.Controls.Add(this.txtAddress);
            this.pnlCustomerInfo.Controls.Add(this.txtName);
            this.pnlCustomerInfo.Controls.Add(this.lblCity);
            this.pnlCustomerInfo.Controls.Add(this.lblAddress);
            this.pnlCustomerInfo.Controls.Add(this.lblName);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(16, 185);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(461, 277);
            this.pnlCustomerInfo.TabIndex = 15;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 18;
            this.lstDisplay.Location = new System.Drawing.Point(16, 107);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(434, 166);
            this.lstDisplay.TabIndex = 16;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(309, 79);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(48, 23);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zip:";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(207, 80);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 23);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(59, 79);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(142, 22);
            this.txtCity.TabIndex = 9;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(59, 47);
            this.txtAddress.MaxLength = 30;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(391, 22);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(59, 14);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 22);
            this.txtName.TabIndex = 7;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(26, 80);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 23);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 47);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cboShippingType);
            this.pnlControls.Controls.Add(this.lblShippingType);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnPrintInvoice);
            this.pnlControls.Controls.Add(this.btnNewOrder);
            this.pnlControls.Controls.Add(this.btnDisplayBill);
            this.pnlControls.Location = new System.Drawing.Point(483, 185);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(184, 277);
            this.pnlControls.TabIndex = 15;
            // 
            // cboShippingType
            // 
            this.cboShippingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShippingType.FormattingEnabled = true;
            this.cboShippingType.Items.AddRange(new object[] {
            "UPS Ground",
            "UPS 3 Days",
            "UPS Next Day"});
            this.cboShippingType.Location = new System.Drawing.Point(15, 32);
            this.cboShippingType.Name = "cboShippingType";
            this.cboShippingType.Size = new System.Drawing.Size(157, 28);
            this.cboShippingType.TabIndex = 16;
            this.cboShippingType.SelectedIndexChanged += new System.EventHandler(this.cboShippingType_SelectedIndexChanged);
            // 
            // lblShippingType
            // 
            this.lblShippingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingType.Location = new System.Drawing.Point(22, 11);
            this.lblShippingType.Name = "lblShippingType";
            this.lblShippingType.Size = new System.Drawing.Size(132, 23);
            this.lblShippingType.TabIndex = 15;
            this.lblShippingType.Text = "Type of Shipping:";
            this.lblShippingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDisplayBill
            // 
            this.btnDisplayBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplayBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayBill.Location = new System.Drawing.Point(15, 66);
            this.btnDisplayBill.Name = "btnDisplayBill";
            this.btnDisplayBill.Size = new System.Drawing.Size(157, 35);
            this.btnDisplayBill.TabIndex = 0;
            this.btnDisplayBill.Text = "&Display Bill";
            this.btnDisplayBill.UseVisualStyleBackColor = false;
            this.btnDisplayBill.Click += new System.EventHandler(this.btnDisplayBill_Click);
            // 
            // pfFuzzyDiceOrderForm
            // 
            this.pfFuzzyDiceOrderForm.DocumentName = "document";
            this.pfFuzzyDiceOrderForm.Form = this;
            this.pfFuzzyDiceOrderForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.pfFuzzyDiceOrderForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("pfFuzzyDiceOrderForm.PrinterSettings")));
            this.pfFuzzyDiceOrderForm.PrintFileName = null;
            // 
            // frmFuzzyDiceOrderForm
            // 
            this.AcceptButton = this.btnDisplayBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(679, 494);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.pnlOrderForm);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "frmFuzzyDiceOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuzzy Dice Order Form";
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            this.pnlOrderForm.ResumeLayout(false);
            this.pnlOrderForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDisplayBill;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuType;
        private System.Windows.Forms.ToolStripMenuItem mnuTypeWhiteBlack;
        private System.Windows.Forms.ToolStripMenuItem mnuTypeRedWhite;
        private System.Windows.Forms.ToolStripMenuItem mnuTypeBlueBlack;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel pnlOrderForm;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTypeOfDice;
        private System.Windows.Forms.Label lblBlueBlackPrice;
        private System.Windows.Forms.Label lblRedWhitePrice;
        private System.Windows.Forms.Label lblWhiteBlackPrice;
        private System.Windows.Forms.CheckBox chkBlueBlack;
        private System.Windows.Forms.CheckBox chkRedWhite;
        private System.Windows.Forms.CheckBox chkWhiteBlack;
        private System.Windows.Forms.TextBox txtBlueBlackQuantity;
        private System.Windows.Forms.TextBox txtRedWhiteQuantity;
        private System.Windows.Forms.TextBox txtWhiteBlackQuantity;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox mtxtZipCode;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnDisplayBill;
        private System.Windows.Forms.ComboBox cboShippingType;
        private System.Windows.Forms.Label lblShippingType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblActualOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm pfFuzzyDiceOrderForm;
    }
}

