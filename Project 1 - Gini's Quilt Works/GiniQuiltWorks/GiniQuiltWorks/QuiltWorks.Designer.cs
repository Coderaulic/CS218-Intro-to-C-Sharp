namespace GiniQuiltWorks
{
    partial class frmQuiltWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiltWorks));
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblQuilts = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picQuiltOne = new System.Windows.Forms.PictureBox();
            this.picQuiltTwo = new System.Windows.Forms.PictureBox();
            this.picQuiltThree = new System.Windows.Forms.PictureBox();
            this.updQuiltOne = new System.Windows.Forms.NumericUpDown();
            this.updQuiltTwo = new System.Windows.Forms.NumericUpDown();
            this.updQuiltThree = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPriceQuiltOne = new System.Windows.Forms.Label();
            this.lblPriceQuiltTwo = new System.Windows.Forms.Label();
            this.lblPriceQuiltThree = new System.Windows.Forms.Label();
            this.lblQuiltOneSubTotal = new System.Windows.Forms.Label();
            this.lblQuiltTwoSubTotal = new System.Windows.Forms.Label();
            this.lblQuiltThreeSubTotal = new System.Windows.Forms.Label();
            this.lblQuiltSubTotal = new System.Windows.Forms.Label();
            this.lblQuiltTax = new System.Windows.Forms.Label();
            this.mtxtInvoiceID = new System.Windows.Forms.MaskedTextBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltThree)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuGenerate,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(502, 24);
            this.mnuMainMenuStrip.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClear,
            this.mnuFilePrint,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.Size = new System.Drawing.Size(101, 22);
            this.mnuFileClear.Text = "&Clear";
            this.mnuFileClear.ToolTipText = "Clear the form";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Enabled = false;
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(101, 22);
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.ToolTipText = "Currently unavailable";
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(101, 22);
            this.mnuFileQuit.Text = "&Quit";
            this.mnuFileQuit.ToolTipText = "Exit application";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuGenerate
            // 
            this.mnuGenerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateCalculate});
            this.mnuGenerate.Name = "mnuGenerate";
            this.mnuGenerate.Size = new System.Drawing.Size(66, 20);
            this.mnuGenerate.Text = "&Generate";
            this.mnuGenerate.ToolTipText = "Calculate total bill";
            // 
            // mnuGenerateCalculate
            // 
            this.mnuGenerateCalculate.Name = "mnuGenerateCalculate";
            this.mnuGenerateCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuGenerateCalculate.Text = "&Calculate";
            this.mnuGenerateCalculate.ToolTipText = "Calculate total bill";
            this.mnuGenerateCalculate.Click += new System.EventHandler(this.mnuGenerateCalculate_Click);
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
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.ToolTipText = "Additional Information";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMainTitle.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMainTitle.Location = new System.Drawing.Point(122, 61);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(369, 70);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Gini\'s Quilt Works Invoice";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(12, 49);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 91);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(8, 163);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(131, 23);
            this.lblInvoice.TabIndex = 3;
            this.lblInvoice.Text = "Invoice Number:";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(275, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuilts
            // 
            this.lblQuilts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilts.Location = new System.Drawing.Point(30, 202);
            this.lblQuilts.Name = "lblQuilts";
            this.lblQuilts.Size = new System.Drawing.Size(68, 23);
            this.lblQuilts.TabIndex = 5;
            this.lblQuilts.Text = "Quilts";
            this.lblQuilts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(152, 202);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 23);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(280, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Extended Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picQuiltOne
            // 
            this.picQuiltOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQuiltOne.BackgroundImage")));
            this.picQuiltOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuiltOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQuiltOne.Location = new System.Drawing.Point(12, 228);
            this.picQuiltOne.Name = "picQuiltOne";
            this.picQuiltOne.Size = new System.Drawing.Size(100, 91);
            this.picQuiltOne.TabIndex = 9;
            this.picQuiltOne.TabStop = false;
            this.ToolTip.SetToolTip(this.picQuiltOne, "Shining Star");
            // 
            // picQuiltTwo
            // 
            this.picQuiltTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQuiltTwo.BackgroundImage")));
            this.picQuiltTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuiltTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQuiltTwo.Location = new System.Drawing.Point(12, 325);
            this.picQuiltTwo.Name = "picQuiltTwo";
            this.picQuiltTwo.Size = new System.Drawing.Size(100, 91);
            this.picQuiltTwo.TabIndex = 10;
            this.picQuiltTwo.TabStop = false;
            this.ToolTip.SetToolTip(this.picQuiltTwo, "Kat Soup");
            // 
            // picQuiltThree
            // 
            this.picQuiltThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picQuiltThree.BackgroundImage")));
            this.picQuiltThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuiltThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQuiltThree.Location = new System.Drawing.Point(12, 422);
            this.picQuiltThree.Name = "picQuiltThree";
            this.picQuiltThree.Size = new System.Drawing.Size(100, 91);
            this.picQuiltThree.TabIndex = 11;
            this.picQuiltThree.TabStop = false;
            this.ToolTip.SetToolTip(this.picQuiltThree, "Birch Trees");
            // 
            // updQuiltOne
            // 
            this.updQuiltOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updQuiltOne.Location = new System.Drawing.Point(156, 259);
            this.updQuiltOne.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.updQuiltOne.Name = "updQuiltOne";
            this.updQuiltOne.ReadOnly = true;
            this.updQuiltOne.Size = new System.Drawing.Size(58, 26);
            this.updQuiltOne.TabIndex = 2;
            this.updQuiltOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.updQuiltOne, "6 available");
            this.updQuiltOne.ValueChanged += new System.EventHandler(this.updQuiltOne_ValueChanged);
            // 
            // updQuiltTwo
            // 
            this.updQuiltTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updQuiltTwo.Location = new System.Drawing.Point(156, 354);
            this.updQuiltTwo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updQuiltTwo.Name = "updQuiltTwo";
            this.updQuiltTwo.ReadOnly = true;
            this.updQuiltTwo.Size = new System.Drawing.Size(58, 26);
            this.updQuiltTwo.TabIndex = 3;
            this.updQuiltTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.updQuiltTwo, "10 available");
            this.updQuiltTwo.ValueChanged += new System.EventHandler(this.updQuiltTwo_ValueChanged);
            // 
            // updQuiltThree
            // 
            this.updQuiltThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updQuiltThree.Location = new System.Drawing.Point(156, 450);
            this.updQuiltThree.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updQuiltThree.Name = "updQuiltThree";
            this.updQuiltThree.ReadOnly = true;
            this.updQuiltThree.Size = new System.Drawing.Size(58, 26);
            this.updQuiltThree.TabIndex = 4;
            this.updQuiltThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.updQuiltThree, "3 available");
            this.updQuiltThree.ValueChanged += new System.EventHandler(this.updQuiltThree_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Turquoise;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(16, 529);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 33);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.ToolTip.SetToolTip(this.btnCalculate, "Calculate total bill");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 568);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Cl&ear";
            this.ToolTip.SetToolTip(this.btnClear, "Clear the form");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(16, 607);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(198, 33);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "&Quit";
            this.ToolTip.SetToolTip(this.btnQuit, "Exit Application");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(265, 534);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(82, 23);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "Sub Total";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(297, 573);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(50, 23);
            this.lblTax.TabIndex = 19;
            this.lblTax.Text = "Tax";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(292, 612);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 23);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceQuiltOne
            // 
            this.lblPriceQuiltOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceQuiltOne.Location = new System.Drawing.Point(270, 260);
            this.lblPriceQuiltOne.Name = "lblPriceQuiltOne";
            this.lblPriceQuiltOne.Size = new System.Drawing.Size(77, 23);
            this.lblPriceQuiltOne.TabIndex = 21;
            this.lblPriceQuiltOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceQuiltTwo
            // 
            this.lblPriceQuiltTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceQuiltTwo.Location = new System.Drawing.Point(270, 355);
            this.lblPriceQuiltTwo.Name = "lblPriceQuiltTwo";
            this.lblPriceQuiltTwo.Size = new System.Drawing.Size(77, 23);
            this.lblPriceQuiltTwo.TabIndex = 22;
            this.lblPriceQuiltTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceQuiltThree
            // 
            this.lblPriceQuiltThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceQuiltThree.Location = new System.Drawing.Point(270, 451);
            this.lblPriceQuiltThree.Name = "lblPriceQuiltThree";
            this.lblPriceQuiltThree.Size = new System.Drawing.Size(77, 23);
            this.lblPriceQuiltThree.TabIndex = 23;
            this.lblPriceQuiltThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuiltOneSubTotal
            // 
            this.lblQuiltOneSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiltOneSubTotal.Location = new System.Drawing.Point(364, 260);
            this.lblQuiltOneSubTotal.Name = "lblQuiltOneSubTotal";
            this.lblQuiltOneSubTotal.Size = new System.Drawing.Size(127, 23);
            this.lblQuiltOneSubTotal.TabIndex = 24;
            this.lblQuiltOneSubTotal.Text = "$0.00";
            this.lblQuiltOneSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuiltTwoSubTotal
            // 
            this.lblQuiltTwoSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiltTwoSubTotal.Location = new System.Drawing.Point(364, 355);
            this.lblQuiltTwoSubTotal.Name = "lblQuiltTwoSubTotal";
            this.lblQuiltTwoSubTotal.Size = new System.Drawing.Size(127, 23);
            this.lblQuiltTwoSubTotal.TabIndex = 25;
            this.lblQuiltTwoSubTotal.Text = "$0.00";
            this.lblQuiltTwoSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuiltThreeSubTotal
            // 
            this.lblQuiltThreeSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiltThreeSubTotal.Location = new System.Drawing.Point(363, 451);
            this.lblQuiltThreeSubTotal.Name = "lblQuiltThreeSubTotal";
            this.lblQuiltThreeSubTotal.Size = new System.Drawing.Size(127, 23);
            this.lblQuiltThreeSubTotal.TabIndex = 26;
            this.lblQuiltThreeSubTotal.Text = "$0.00";
            this.lblQuiltThreeSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuiltSubTotal
            // 
            this.lblQuiltSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiltSubTotal.Location = new System.Drawing.Point(364, 534);
            this.lblQuiltSubTotal.Name = "lblQuiltSubTotal";
            this.lblQuiltSubTotal.Size = new System.Drawing.Size(127, 23);
            this.lblQuiltSubTotal.TabIndex = 27;
            this.lblQuiltSubTotal.Text = "$0.00";
            this.lblQuiltSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuiltTax
            // 
            this.lblQuiltTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiltTax.Location = new System.Drawing.Point(364, 573);
            this.lblQuiltTax.Name = "lblQuiltTax";
            this.lblQuiltTax.Size = new System.Drawing.Size(127, 23);
            this.lblQuiltTax.TabIndex = 28;
            this.lblQuiltTax.Text = "$0.00";
            this.lblQuiltTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxtInvoiceID
            // 
            this.mtxtInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInvoiceID.Location = new System.Drawing.Point(145, 161);
            this.mtxtInvoiceID.Mask = "0000";
            this.mtxtInvoiceID.Name = "mtxtInvoiceID";
            this.mtxtInvoiceID.Size = new System.Drawing.Size(43, 26);
            this.mtxtInvoiceID.TabIndex = 1;
            this.mtxtInvoiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.mtxtInvoiceID, "Enter 4 digit number");
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(379, 164);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(112, 23);
            this.lblCurrentDate.TabIndex = 30;
            this.lblCurrentDate.Text = "Today\'s Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(368, 612);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(122, 23);
            this.lblTotalCost.TabIndex = 31;
            this.lblTotalCost.Text = "$0.00";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmQuiltWorks
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(502, 651);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.mtxtInvoiceID);
            this.Controls.Add(this.lblQuiltTax);
            this.Controls.Add(this.lblQuiltSubTotal);
            this.Controls.Add(this.lblQuiltThreeSubTotal);
            this.Controls.Add(this.lblQuiltTwoSubTotal);
            this.Controls.Add(this.lblQuiltOneSubTotal);
            this.Controls.Add(this.lblPriceQuiltThree);
            this.Controls.Add(this.lblPriceQuiltTwo);
            this.Controls.Add(this.lblPriceQuiltOne);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.updQuiltThree);
            this.Controls.Add(this.updQuiltTwo);
            this.Controls.Add(this.updQuiltOne);
            this.Controls.Add(this.picQuiltThree);
            this.Controls.Add(this.picQuiltTwo);
            this.Controls.Add(this.picQuiltOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblQuilts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "frmQuiltWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gini\'s Quilt Works";
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiltThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQuiltThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerate;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateCalculate;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblQuilts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picQuiltOne;
        private System.Windows.Forms.PictureBox picQuiltTwo;
        private System.Windows.Forms.PictureBox picQuiltThree;
        private System.Windows.Forms.NumericUpDown updQuiltOne;
        private System.Windows.Forms.NumericUpDown updQuiltTwo;
        private System.Windows.Forms.NumericUpDown updQuiltThree;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPriceQuiltOne;
        private System.Windows.Forms.Label lblPriceQuiltTwo;
        private System.Windows.Forms.Label lblPriceQuiltThree;
        private System.Windows.Forms.Label lblQuiltOneSubTotal;
        private System.Windows.Forms.Label lblQuiltTwoSubTotal;
        private System.Windows.Forms.Label lblQuiltThreeSubTotal;
        private System.Windows.Forms.Label lblQuiltSubTotal;
        private System.Windows.Forms.Label lblQuiltTax;
        private System.Windows.Forms.MaskedTextBox mtxtInvoiceID;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

