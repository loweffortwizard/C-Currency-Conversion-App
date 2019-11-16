namespace CurrencyConverterApp
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tblPnlMenuMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlMenuOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnPoundsAndDollarUS = new System.Windows.Forms.Button();
            this.btnPoundsAndEuros = new System.Windows.Forms.Button();
            this.btnPoundsAndYen = new System.Windows.Forms.Button();
            this.btnCentAndInch = new System.Windows.Forms.Button();
            this.tblPnlMenuFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pbxMenuLogo = new System.Windows.Forms.PictureBox();
            this.tblPnlMenuControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenuHelp = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.ttPAndD = new System.Windows.Forms.ToolTip(this.components);
            this.ttPAndE = new System.Windows.Forms.ToolTip(this.components);
            this.ttPAndY = new System.Windows.Forms.ToolTip(this.components);
            this.ttCAndI = new System.Windows.Forms.ToolTip(this.components);
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.ttExit = new System.Windows.Forms.ToolTip(this.components);
            this.tblPnlMenuMain.SuspendLayout();
            this.tblPnlMenuOptions.SuspendLayout();
            this.tblPnlMenuFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuLogo)).BeginInit();
            this.tblPnlMenuControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPnlMenuMain
            // 
            this.tblPnlMenuMain.BackColor = System.Drawing.Color.White;
            this.tblPnlMenuMain.ColumnCount = 1;
            this.tblPnlMenuMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuMain.Controls.Add(this.tblPnlMenuOptions, 0, 1);
            this.tblPnlMenuMain.Controls.Add(this.tblPnlMenuFooter, 0, 2);
            this.tblPnlMenuMain.Controls.Add(this.lblMenuTitle, 0, 0);
            this.tblPnlMenuMain.Location = new System.Drawing.Point(64, 12);
            this.tblPnlMenuMain.Name = "tblPnlMenuMain";
            this.tblPnlMenuMain.RowCount = 3;
            this.tblPnlMenuMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tblPnlMenuMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblPnlMenuMain.Size = new System.Drawing.Size(660, 537);
            this.tblPnlMenuMain.TabIndex = 0;
            // 
            // tblPnlMenuOptions
            // 
            this.tblPnlMenuOptions.ColumnCount = 2;
            this.tblPnlMenuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuOptions.Controls.Add(this.btnPoundsAndDollarUS, 0, 0);
            this.tblPnlMenuOptions.Controls.Add(this.btnPoundsAndEuros, 1, 0);
            this.tblPnlMenuOptions.Controls.Add(this.btnPoundsAndYen, 0, 1);
            this.tblPnlMenuOptions.Controls.Add(this.btnCentAndInch, 1, 1);
            this.tblPnlMenuOptions.Location = new System.Drawing.Point(3, 63);
            this.tblPnlMenuOptions.Name = "tblPnlMenuOptions";
            this.tblPnlMenuOptions.RowCount = 2;
            this.tblPnlMenuOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuOptions.Size = new System.Drawing.Size(654, 345);
            this.tblPnlMenuOptions.TabIndex = 0;
            // 
            // btnPoundsAndDollarUS
            // 
            this.btnPoundsAndDollarUS.AccessibleDescription = "Click here to go to the pounds and dollars section, for converting between them c" +
    "urrency.";
            this.btnPoundsAndDollarUS.AccessibleName = "Pounds and Dollars US";
            this.btnPoundsAndDollarUS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPoundsAndDollarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoundsAndDollarUS.BackColor = System.Drawing.Color.Lime;
            this.btnPoundsAndDollarUS.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoundsAndDollarUS.Location = new System.Drawing.Point(5, 5);
            this.btnPoundsAndDollarUS.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoundsAndDollarUS.Name = "btnPoundsAndDollarUS";
            this.btnPoundsAndDollarUS.Size = new System.Drawing.Size(317, 162);
            this.btnPoundsAndDollarUS.TabIndex = 0;
            this.btnPoundsAndDollarUS.Text = "Pounds and Dollars (US)";
            this.btnPoundsAndDollarUS.UseVisualStyleBackColor = false;
            this.btnPoundsAndDollarUS.Click += new System.EventHandler(this.btnPoundsAndDollarUS_Click);
            // 
            // btnPoundsAndEuros
            // 
            this.btnPoundsAndEuros.AccessibleDescription = "Click here to go to the pounds and euro section, for converting between them curr" +
    "ency.";
            this.btnPoundsAndEuros.AccessibleName = "Pounds and Euros";
            this.btnPoundsAndEuros.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPoundsAndEuros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoundsAndEuros.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPoundsAndEuros.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoundsAndEuros.Location = new System.Drawing.Point(332, 5);
            this.btnPoundsAndEuros.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoundsAndEuros.Name = "btnPoundsAndEuros";
            this.btnPoundsAndEuros.Size = new System.Drawing.Size(317, 162);
            this.btnPoundsAndEuros.TabIndex = 1;
            this.btnPoundsAndEuros.Text = "Pounds and Euros";
            this.btnPoundsAndEuros.UseVisualStyleBackColor = false;
            this.btnPoundsAndEuros.Click += new System.EventHandler(this.btnPoundsAndEuros_Click);
            // 
            // btnPoundsAndYen
            // 
            this.btnPoundsAndYen.AccessibleDescription = "Click here to go to the pounds and yen section, for converting between them curre" +
    "ncy.";
            this.btnPoundsAndYen.AccessibleName = "Pounds and Yen";
            this.btnPoundsAndYen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoundsAndYen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPoundsAndYen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoundsAndYen.Location = new System.Drawing.Point(5, 177);
            this.btnPoundsAndYen.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoundsAndYen.Name = "btnPoundsAndYen";
            this.btnPoundsAndYen.Size = new System.Drawing.Size(317, 163);
            this.btnPoundsAndYen.TabIndex = 2;
            this.btnPoundsAndYen.Text = "Pounds and Yen";
            this.btnPoundsAndYen.UseVisualStyleBackColor = false;
            this.btnPoundsAndYen.Click += new System.EventHandler(this.btnPoundsAndYen_Click);
            // 
            // btnCentAndInch
            // 
            this.btnCentAndInch.AccessibleDescription = "Click here to go to the cent and inch conversion form";
            this.btnCentAndInch.AccessibleName = "Cent and Inch button";
            this.btnCentAndInch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCentAndInch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCentAndInch.BackColor = System.Drawing.Color.LightCyan;
            this.btnCentAndInch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentAndInch.Location = new System.Drawing.Point(332, 177);
            this.btnCentAndInch.Margin = new System.Windows.Forms.Padding(5);
            this.btnCentAndInch.Name = "btnCentAndInch";
            this.btnCentAndInch.Size = new System.Drawing.Size(317, 163);
            this.btnCentAndInch.TabIndex = 3;
            this.btnCentAndInch.Text = "Cent and Inch";
            this.btnCentAndInch.UseVisualStyleBackColor = false;
            this.btnCentAndInch.Click += new System.EventHandler(this.btnCentAndInch_Click);
            // 
            // tblPnlMenuFooter
            // 
            this.tblPnlMenuFooter.ColumnCount = 2;
            this.tblPnlMenuFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlMenuFooter.Controls.Add(this.pbxMenuLogo, 0, 0);
            this.tblPnlMenuFooter.Controls.Add(this.tblPnlMenuControls, 1, 0);
            this.tblPnlMenuFooter.Location = new System.Drawing.Point(3, 423);
            this.tblPnlMenuFooter.Name = "tblPnlMenuFooter";
            this.tblPnlMenuFooter.RowCount = 1;
            this.tblPnlMenuFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMenuFooter.Size = new System.Drawing.Size(654, 79);
            this.tblPnlMenuFooter.TabIndex = 2;
            // 
            // pbxMenuLogo
            // 
            this.pbxMenuLogo.AccessibleDescription = "Logo - Markrosoft";
            this.pbxMenuLogo.AccessibleName = "Markrosoft logo";
            this.pbxMenuLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pbxMenuLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMenuLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenuLogo.Image")));
            this.pbxMenuLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxMenuLogo.Name = "pbxMenuLogo";
            this.pbxMenuLogo.Size = new System.Drawing.Size(321, 73);
            this.pbxMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMenuLogo.TabIndex = 0;
            this.pbxMenuLogo.TabStop = false;
            // 
            // tblPnlMenuControls
            // 
            this.tblPnlMenuControls.ColumnCount = 2;
            this.tblPnlMenuControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblPnlMenuControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlMenuControls.Controls.Add(this.btnExit, 1, 0);
            this.tblPnlMenuControls.Controls.Add(this.btnMenuHelp, 0, 0);
            this.tblPnlMenuControls.Location = new System.Drawing.Point(330, 3);
            this.tblPnlMenuControls.Name = "tblPnlMenuControls";
            this.tblPnlMenuControls.RowCount = 1;
            this.tblPnlMenuControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMenuControls.Size = new System.Drawing.Size(319, 73);
            this.tblPnlMenuControls.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "Click here to close the application";
            this.btnExit.AccessibleName = "Exit";
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(244, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 63);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenuHelp
            // 
            this.btnMenuHelp.AccessibleDescription = "Click here to open the help menu";
            this.btnMenuHelp.AccessibleName = "Help screen button";
            this.btnMenuHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuHelp.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnMenuHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnMenuHelp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHelp.Location = new System.Drawing.Point(5, 5);
            this.btnMenuHelp.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuHelp.Name = "btnMenuHelp";
            this.btnMenuHelp.Size = new System.Drawing.Size(229, 63);
            this.btnMenuHelp.TabIndex = 1;
            this.btnMenuHelp.Text = "Help?";
            this.btnMenuHelp.UseVisualStyleBackColor = false;
            this.btnMenuHelp.Click += new System.EventHandler(this.btnMenuHelp_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AccessibleDescription = "Title for the menu";
            this.lblMenuTitle.AccessibleName = "Title Menu";
            this.lblMenuTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.Location = new System.Drawing.Point(283, 9);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(94, 41);
            this.lblMenuTitle.TabIndex = 1;
            this.lblMenuTitle.Text = "Menu";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttPAndD
            // 
            this.ttPAndD.IsBalloon = true;
            // 
            // ttPAndE
            // 
            this.ttPAndE.IsBalloon = true;
            // 
            // ttPAndY
            // 
            this.ttPAndY.IsBalloon = true;
            // 
            // ttCAndI
            // 
            this.ttCAndI.IsBalloon = true;
            // 
            // ttHelp
            // 
            this.ttHelp.IsBalloon = true;
            // 
            // ttExit
            // 
            this.ttExit.IsBalloon = true;
            // 
            // frmMenu
            // 
            this.AccessibleDescription = "This is the main menu, please choose an option for converting below.";
            this.AccessibleName = "Main Menu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tblPnlMenuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - Currency Converter ";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tblPnlMenuMain.ResumeLayout(false);
            this.tblPnlMenuMain.PerformLayout();
            this.tblPnlMenuOptions.ResumeLayout(false);
            this.tblPnlMenuFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuLogo)).EndInit();
            this.tblPnlMenuControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlMenuMain;
        private System.Windows.Forms.TableLayoutPanel tblPnlMenuOptions;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnPoundsAndDollarUS;
        private System.Windows.Forms.Button btnPoundsAndEuros;
        private System.Windows.Forms.Button btnPoundsAndYen;
        private System.Windows.Forms.Button btnCentAndInch;
        private System.Windows.Forms.TableLayoutPanel tblPnlMenuFooter;
        private System.Windows.Forms.PictureBox pbxMenuLogo;
        private System.Windows.Forms.TableLayoutPanel tblPnlMenuControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenuHelp;
        private System.Windows.Forms.ToolTip ttPAndD;
        private System.Windows.Forms.ToolTip ttPAndE;
        private System.Windows.Forms.ToolTip ttPAndY;
        private System.Windows.Forms.ToolTip ttCAndI;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.ToolTip ttExit;
    }
}