namespace GiniQuiltWorks
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.picAboutImage = new System.Windows.Forms.PictureBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(67, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(12, 98);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(325, 193);
            this.lblInformation.TabIndex = 8;
            this.lblInformation.Text = "About gini\'s quilt shop";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAboutImage
            // 
            this.picAboutImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAboutImage.BackgroundImage")));
            this.picAboutImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAboutImage.Location = new System.Drawing.Point(12, 12);
            this.picAboutImage.Name = "picAboutImage";
            this.picAboutImage.Size = new System.Drawing.Size(86, 83);
            this.picAboutImage.TabIndex = 9;
            this.picAboutImage.TabStop = false;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMainTitle.Font = new System.Drawing.Font("Freestyle Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMainTitle.Location = new System.Drawing.Point(107, 30);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(251, 49);
            this.lblMainTitle.TabIndex = 10;
            this.lblMainTitle.Text = "Gini\'s Quilt Works Invoice";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(349, 352);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.picAboutImage);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Geni\'s Quilt Works";
            ((System.ComponentModel.ISupportInitialize)(this.picAboutImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox picAboutImage;
        private System.Windows.Forms.Label lblMainTitle;
    }
}