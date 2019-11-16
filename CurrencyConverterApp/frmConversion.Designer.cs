namespace CurrencyConverterApp
{
    partial class frmConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversion));
            this.tblPnlConversionMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlConversionCalc = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tblPnlConversionInputAndOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlConversionInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblConversionInput = new System.Windows.Forms.Label();
            this.tblPnlConversionOptions = new System.Windows.Forms.TableLayoutPanel();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.tblPnlConversionFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pbxConversionLogo = new System.Windows.Forms.PictureBox();
            this.tblPnlConversionControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnConversionExit = new System.Windows.Forms.Button();
            this.btnConversionHelp = new System.Windows.Forms.Button();
            this.btnConversionReturn = new System.Windows.Forms.Button();
            this.lblConversionTitle = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.ttCalc = new System.Windows.Forms.ToolTip(this.components);
            this.ttReturn = new System.Windows.Forms.ToolTip(this.components);
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.ttExit = new System.Windows.Forms.ToolTip(this.components);
            this.tblPnlConversionMain.SuspendLayout();
            this.tblPnlConversionCalc.SuspendLayout();
            this.tblPnlConversionInputAndOptions.SuspendLayout();
            this.tblPnlConversionInput.SuspendLayout();
            this.tblPnlConversionOptions.SuspendLayout();
            this.tblPnlConversionFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversionLogo)).BeginInit();
            this.tblPnlConversionControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPnlConversionMain
            // 
            this.tblPnlConversionMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblPnlConversionMain.BackColor = System.Drawing.Color.White;
            this.tblPnlConversionMain.ColumnCount = 1;
            this.tblPnlConversionMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionMain.Controls.Add(this.tblPnlConversionCalc, 0, 2);
            this.tblPnlConversionMain.Controls.Add(this.tblPnlConversionInputAndOptions, 0, 1);
            this.tblPnlConversionMain.Controls.Add(this.tblPnlConversionFooter, 0, 4);
            this.tblPnlConversionMain.Controls.Add(this.lblConversionTitle, 0, 0);
            this.tblPnlConversionMain.Controls.Add(this.txtOutput, 0, 3);
            this.tblPnlConversionMain.Location = new System.Drawing.Point(67, 12);
            this.tblPnlConversionMain.Name = "tblPnlConversionMain";
            this.tblPnlConversionMain.RowCount = 5;
            this.tblPnlConversionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.1282F));
            this.tblPnlConversionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.8718F));
            this.tblPnlConversionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblPnlConversionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tblPnlConversionMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblPnlConversionMain.Size = new System.Drawing.Size(660, 537);
            this.tblPnlConversionMain.TabIndex = 0;
            this.tblPnlConversionMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPnlConversionMain_Paint);
            // 
            // tblPnlConversionCalc
            // 
            this.tblPnlConversionCalc.BackColor = System.Drawing.Color.White;
            this.tblPnlConversionCalc.ColumnCount = 3;
            this.tblPnlConversionCalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlConversionCalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPnlConversionCalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlConversionCalc.Controls.Add(this.btnCalculate, 1, 0);
            this.tblPnlConversionCalc.Location = new System.Drawing.Point(3, 314);
            this.tblPnlConversionCalc.Name = "tblPnlConversionCalc";
            this.tblPnlConversionCalc.RowCount = 1;
            this.tblPnlConversionCalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionCalc.Size = new System.Drawing.Size(654, 40);
            this.tblPnlConversionCalc.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleDescription = "Button for calculating the conversion of your entered number.";
            this.btnCalculate.AccessibleName = "Calculate";
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(133, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(386, 34);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tblPnlConversionInputAndOptions
            // 
            this.tblPnlConversionInputAndOptions.BackColor = System.Drawing.Color.Aqua;
            this.tblPnlConversionInputAndOptions.ColumnCount = 2;
            this.tblPnlConversionInputAndOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionInputAndOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionInputAndOptions.Controls.Add(this.tblPnlConversionInput, 0, 0);
            this.tblPnlConversionInputAndOptions.Controls.Add(this.tblPnlConversionOptions, 1, 0);
            this.tblPnlConversionInputAndOptions.Location = new System.Drawing.Point(3, 96);
            this.tblPnlConversionInputAndOptions.Name = "tblPnlConversionInputAndOptions";
            this.tblPnlConversionInputAndOptions.RowCount = 1;
            this.tblPnlConversionInputAndOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionInputAndOptions.Size = new System.Drawing.Size(654, 212);
            this.tblPnlConversionInputAndOptions.TabIndex = 3;
            // 
            // tblPnlConversionInput
            // 
            this.tblPnlConversionInput.BackColor = System.Drawing.Color.LimeGreen;
            this.tblPnlConversionInput.ColumnCount = 1;
            this.tblPnlConversionInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionInput.Controls.Add(this.txtInput1, 0, 1);
            this.tblPnlConversionInput.Controls.Add(this.lblConversionInput, 0, 0);
            this.tblPnlConversionInput.Location = new System.Drawing.Point(3, 3);
            this.tblPnlConversionInput.Name = "tblPnlConversionInput";
            this.tblPnlConversionInput.RowCount = 2;
            this.tblPnlConversionInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
            this.tblPnlConversionInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.64078F));
            this.tblPnlConversionInput.Size = new System.Drawing.Size(321, 206);
            this.tblPnlConversionInput.TabIndex = 0;
            // 
            // txtInput1
            // 
            this.txtInput1.AccessibleDescription = "Enter your value of conversion here.";
            this.txtInput1.AccessibleName = "Input";
            this.txtInput1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput1.Location = new System.Drawing.Point(3, 46);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(315, 20);
            this.txtInput1.TabIndex = 0;
            // 
            // lblConversionInput
            // 
            this.lblConversionInput.AutoSize = true;
            this.lblConversionInput.BackColor = System.Drawing.Color.White;
            this.lblConversionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConversionInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionInput.Location = new System.Drawing.Point(3, 0);
            this.lblConversionInput.Name = "lblConversionInput";
            this.lblConversionInput.Size = new System.Drawing.Size(315, 43);
            this.lblConversionInput.TabIndex = 1;
            this.lblConversionInput.Text = "Enter Number Below.";
            this.lblConversionInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPnlConversionOptions
            // 
            this.tblPnlConversionOptions.ColumnCount = 1;
            this.tblPnlConversionOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionOptions.Controls.Add(this.rdoOption1, 0, 0);
            this.tblPnlConversionOptions.Controls.Add(this.rdoOption2, 0, 1);
            this.tblPnlConversionOptions.Location = new System.Drawing.Point(330, 3);
            this.tblPnlConversionOptions.Name = "tblPnlConversionOptions";
            this.tblPnlConversionOptions.RowCount = 2;
            this.tblPnlConversionOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionOptions.Size = new System.Drawing.Size(321, 206);
            this.tblPnlConversionOptions.TabIndex = 1;
            // 
            // rdoOption1
            // 
            this.rdoOption1.AccessibleDescription = "Option 1 for converting";
            this.rdoOption1.AccessibleName = "Option 1";
            this.rdoOption1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdoOption1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOption1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoOption1.Checked = true;
            this.rdoOption1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOption1.Location = new System.Drawing.Point(3, 3);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(315, 97);
            this.rdoOption1.TabIndex = 0;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.Text = "Default";
            this.rdoOption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoOption1.UseVisualStyleBackColor = true;
            // 
            // rdoOption2
            // 
            this.rdoOption2.AccessibleDescription = "Option 2 for converting.";
            this.rdoOption2.AccessibleName = "Option 2";
            this.rdoOption2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOption2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoOption2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOption2.Location = new System.Drawing.Point(3, 106);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(315, 97);
            this.rdoOption2.TabIndex = 1;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.Text = "Default";
            this.rdoOption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoOption2.UseVisualStyleBackColor = true;
            // 
            // tblPnlConversionFooter
            // 
            this.tblPnlConversionFooter.ColumnCount = 2;
            this.tblPnlConversionFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlConversionFooter.Controls.Add(this.pbxConversionLogo, 0, 0);
            this.tblPnlConversionFooter.Controls.Add(this.tblPnlConversionControl, 1, 0);
            this.tblPnlConversionFooter.Location = new System.Drawing.Point(3, 461);
            this.tblPnlConversionFooter.Name = "tblPnlConversionFooter";
            this.tblPnlConversionFooter.RowCount = 1;
            this.tblPnlConversionFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionFooter.Size = new System.Drawing.Size(654, 73);
            this.tblPnlConversionFooter.TabIndex = 5;
            this.tblPnlConversionFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPnlConversionFooter_Paint);
            // 
            // pbxConversionLogo
            // 
            this.pbxConversionLogo.AccessibleDescription = "Markrosoft logo";
            this.pbxConversionLogo.AccessibleName = "Logo - Markrosoft";
            this.pbxConversionLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pbxConversionLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxConversionLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxConversionLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxConversionLogo.Image")));
            this.pbxConversionLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxConversionLogo.Name = "pbxConversionLogo";
            this.pbxConversionLogo.Size = new System.Drawing.Size(321, 67);
            this.pbxConversionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxConversionLogo.TabIndex = 0;
            this.pbxConversionLogo.TabStop = false;
            this.pbxConversionLogo.Click += new System.EventHandler(this.pbxConversionLogo_Click);
            // 
            // tblPnlConversionControl
            // 
            this.tblPnlConversionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlConversionControl.ColumnCount = 3;
            this.tblPnlConversionControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPnlConversionControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblPnlConversionControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlConversionControl.Controls.Add(this.btnConversionExit, 2, 0);
            this.tblPnlConversionControl.Controls.Add(this.btnConversionHelp, 1, 0);
            this.tblPnlConversionControl.Controls.Add(this.btnConversionReturn, 0, 0);
            this.tblPnlConversionControl.Location = new System.Drawing.Point(330, 3);
            this.tblPnlConversionControl.Name = "tblPnlConversionControl";
            this.tblPnlConversionControl.RowCount = 1;
            this.tblPnlConversionControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlConversionControl.Size = new System.Drawing.Size(321, 67);
            this.tblPnlConversionControl.TabIndex = 1;
            // 
            // btnConversionExit
            // 
            this.btnConversionExit.AccessibleDescription = "Exit";
            this.btnConversionExit.AccessibleName = "Click here to close the application";
            this.btnConversionExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConversionExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConversionExit.BackColor = System.Drawing.Color.Red;
            this.btnConversionExit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversionExit.Location = new System.Drawing.Point(243, 3);
            this.btnConversionExit.Name = "btnConversionExit";
            this.btnConversionExit.Size = new System.Drawing.Size(75, 61);
            this.btnConversionExit.TabIndex = 1;
            this.btnConversionExit.Text = "X";
            this.btnConversionExit.UseVisualStyleBackColor = false;
            this.btnConversionExit.Click += new System.EventHandler(this.btnConversionExit_Click);
            // 
            // btnConversionHelp
            // 
            this.btnConversionHelp.AccessibleDescription = "Help screen";
            this.btnConversionHelp.AccessibleName = "Click here to open the help screen";
            this.btnConversionHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConversionHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConversionHelp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversionHelp.Location = new System.Drawing.Point(131, 3);
            this.btnConversionHelp.Name = "btnConversionHelp";
            this.btnConversionHelp.Size = new System.Drawing.Size(106, 61);
            this.btnConversionHelp.TabIndex = 0;
            this.btnConversionHelp.Text = "Help?";
            this.btnConversionHelp.UseVisualStyleBackColor = true;
            this.btnConversionHelp.Click += new System.EventHandler(this.btnConversionHelp_Click);
            // 
            // btnConversionReturn
            // 
            this.btnConversionReturn.AccessibleDescription = "Click to return back to the menu";
            this.btnConversionReturn.AccessibleName = "Return to menu";
            this.btnConversionReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConversionReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConversionReturn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversionReturn.Location = new System.Drawing.Point(3, 3);
            this.btnConversionReturn.Name = "btnConversionReturn";
            this.btnConversionReturn.Size = new System.Drawing.Size(122, 61);
            this.btnConversionReturn.TabIndex = 2;
            this.btnConversionReturn.Text = "Return";
            this.btnConversionReturn.UseVisualStyleBackColor = true;
            this.btnConversionReturn.Click += new System.EventHandler(this.btnConversionReturn_Click);
            // 
            // lblConversionTitle
            // 
            this.lblConversionTitle.AccessibleDescription = "Title for the Conversion form.";
            this.lblConversionTitle.AccessibleName = "Title";
            this.lblConversionTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblConversionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConversionTitle.AutoSize = true;
            this.lblConversionTitle.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionTitle.Location = new System.Drawing.Point(3, 0);
            this.lblConversionTitle.Name = "lblConversionTitle";
            this.lblConversionTitle.Size = new System.Drawing.Size(654, 93);
            this.lblConversionTitle.TabIndex = 0;
            this.lblConversionTitle.Text = "Conversion";
            this.lblConversionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleDescription = "The result of your conversion will appear here.";
            this.txtOutput.AccessibleName = "Output";
            this.txtOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 367);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(660, 91);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "0";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttCalc
            // 
            this.ttCalc.IsBalloon = true;
            // 
            // ttReturn
            // 
            this.ttReturn.IsBalloon = true;
            // 
            // ttHelp
            // 
            this.ttHelp.IsBalloon = true;
            // 
            // ttExit
            // 
            this.ttExit.IsBalloon = true;
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tblPnlConversionMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion - Currency Converter";
            this.Load += new System.EventHandler(this.frmConversion_Load);
            this.tblPnlConversionMain.ResumeLayout(false);
            this.tblPnlConversionMain.PerformLayout();
            this.tblPnlConversionCalc.ResumeLayout(false);
            this.tblPnlConversionInputAndOptions.ResumeLayout(false);
            this.tblPnlConversionInput.ResumeLayout(false);
            this.tblPnlConversionInput.PerformLayout();
            this.tblPnlConversionOptions.ResumeLayout(false);
            this.tblPnlConversionOptions.PerformLayout();
            this.tblPnlConversionFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversionLogo)).EndInit();
            this.tblPnlConversionControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlConversionMain;
        private System.Windows.Forms.Label lblConversionTitle;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionCalc;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionInputAndOptions;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionInput;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionOptions;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionFooter;
        private System.Windows.Forms.PictureBox pbxConversionLogo;
        private System.Windows.Forms.TableLayoutPanel tblPnlConversionControl;
        private System.Windows.Forms.Button btnConversionHelp;
        private System.Windows.Forms.Button btnConversionExit;
        private System.Windows.Forms.Button btnConversionReturn;
        private System.Windows.Forms.ToolTip ttCalc;
        private System.Windows.Forms.ToolTip ttReturn;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.ToolTip ttExit;
        private System.Windows.Forms.Label lblConversionInput;
    }
}