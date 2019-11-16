namespace CurrencyConverterApp
{
    partial class frmHelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpScreen));
            this.tblPnlHelpScreenMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnHelpExit = new System.Windows.Forms.Button();
            this.pbxHelpLogo = new System.Windows.Forms.PictureBox();
            this.txtHelpOutput = new System.Windows.Forms.TextBox();
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.ttReturn = new System.Windows.Forms.ToolTip(this.components);
            this.ttExit = new System.Windows.Forms.ToolTip(this.components);
            this.tblPnlHelpScreenMain.SuspendLayout();
            this.tblPnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPnlHelpScreenMain
            // 
            this.tblPnlHelpScreenMain.BackColor = System.Drawing.Color.White;
            this.tblPnlHelpScreenMain.ColumnCount = 1;
            this.tblPnlHelpScreenMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlHelpScreenMain.Controls.Add(this.tblPnlControl, 0, 2);
            this.tblPnlHelpScreenMain.Controls.Add(this.txtHelpOutput, 0, 1);
            this.tblPnlHelpScreenMain.Controls.Add(this.lblHelpTitle, 0, 0);
            this.tblPnlHelpScreenMain.Location = new System.Drawing.Point(12, 12);
            this.tblPnlHelpScreenMain.Name = "tblPnlHelpScreenMain";
            this.tblPnlHelpScreenMain.RowCount = 3;
            this.tblPnlHelpScreenMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblPnlHelpScreenMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tblPnlHelpScreenMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPnlHelpScreenMain.Size = new System.Drawing.Size(660, 387);
            this.tblPnlHelpScreenMain.TabIndex = 0;
            // 
            // tblPnlControl
            // 
            this.tblPnlControl.ColumnCount = 3;
            this.tblPnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblPnlControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPnlControl.Controls.Add(this.btnReturn, 1, 0);
            this.tblPnlControl.Controls.Add(this.btnHelpExit, 2, 0);
            this.tblPnlControl.Controls.Add(this.pbxHelpLogo, 0, 0);
            this.tblPnlControl.Location = new System.Drawing.Point(3, 319);
            this.tblPnlControl.Name = "tblPnlControl";
            this.tblPnlControl.RowCount = 1;
            this.tblPnlControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlControl.Size = new System.Drawing.Size(654, 65);
            this.tblPnlControl.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.AccessibleDescription = "Return to the previous form";
            this.btnReturn.AccessibleName = "Return";
            this.btnReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(330, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(222, 59);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHelpExit
            // 
            this.btnHelpExit.AccessibleDescription = "Close the application";
            this.btnHelpExit.AccessibleName = "Exit";
            this.btnHelpExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHelpExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpExit.BackColor = System.Drawing.Color.Red;
            this.btnHelpExit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpExit.Location = new System.Drawing.Point(558, 3);
            this.btnHelpExit.Name = "btnHelpExit";
            this.btnHelpExit.Size = new System.Drawing.Size(93, 59);
            this.btnHelpExit.TabIndex = 1;
            this.btnHelpExit.Text = "X";
            this.btnHelpExit.UseVisualStyleBackColor = false;
            this.btnHelpExit.Click += new System.EventHandler(this.btnHelpExit_Click);
            // 
            // pbxHelpLogo
            // 
            this.pbxHelpLogo.AccessibleDescription = "Markrosoft logo";
            this.pbxHelpLogo.AccessibleName = "Logo - Markrosoft";
            this.pbxHelpLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pbxHelpLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxHelpLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxHelpLogo.Image")));
            this.pbxHelpLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxHelpLogo.Name = "pbxHelpLogo";
            this.pbxHelpLogo.Size = new System.Drawing.Size(321, 59);
            this.pbxHelpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHelpLogo.TabIndex = 2;
            this.pbxHelpLogo.TabStop = false;
            // 
            // txtHelpOutput
            // 
            this.txtHelpOutput.AccessibleDescription = "Help screen infomation";
            this.txtHelpOutput.AccessibleName = "Help screen";
            this.txtHelpOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtHelpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelpOutput.BackColor = System.Drawing.Color.White;
            this.txtHelpOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelpOutput.Location = new System.Drawing.Point(3, 38);
            this.txtHelpOutput.Multiline = true;
            this.txtHelpOutput.Name = "txtHelpOutput";
            this.txtHelpOutput.ReadOnly = true;
            this.txtHelpOutput.Size = new System.Drawing.Size(654, 275);
            this.txtHelpOutput.TabIndex = 1;
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AccessibleDescription = "Title for the help screen";
            this.lblHelpTitle.AccessibleName = "Title";
            this.lblHelpTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblHelpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.Location = new System.Drawing.Point(3, 0);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(654, 35);
            this.lblHelpTitle.TabIndex = 2;
            this.lblHelpTitle.Text = "Help Screen";
            this.lblHelpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttReturn
            // 
            this.ttReturn.IsBalloon = true;
            // 
            // ttExit
            // 
            this.ttExit.IsBalloon = true;
            // 
            // frmHelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.tblPnlHelpScreenMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHelpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelpScreen_Load);
            this.tblPnlHelpScreenMain.ResumeLayout(false);
            this.tblPnlHelpScreenMain.PerformLayout();
            this.tblPnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlHelpScreenMain;
        private System.Windows.Forms.TableLayoutPanel tblPnlControl;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHelpExit;
        private System.Windows.Forms.PictureBox pbxHelpLogo;
        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.TextBox txtHelpOutput;
        private System.Windows.Forms.ToolTip ttReturn;
        private System.Windows.Forms.ToolTip ttExit;
    }
}