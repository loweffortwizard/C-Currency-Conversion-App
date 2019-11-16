namespace CurrencyConverterApp
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.tblPnlSplash = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.prgSplashLoading = new System.Windows.Forms.ProgressBar();
            this.tblPnlSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPnlSplash
            // 
            this.tblPnlSplash.ColumnCount = 1;
            this.tblPnlSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlSplash.Controls.Add(this.pictureBox1, 0, 1);
            this.tblPnlSplash.Controls.Add(this.lblSplashTitle, 0, 0);
            this.tblPnlSplash.Controls.Add(this.prgSplashLoading, 0, 2);
            this.tblPnlSplash.Location = new System.Drawing.Point(12, 12);
            this.tblPnlSplash.Name = "tblPnlSplash";
            this.tblPnlSplash.RowCount = 3;
            this.tblPnlSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tblPnlSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblPnlSplash.Size = new System.Drawing.Size(260, 237);
            this.tblPnlSplash.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(254, 51);
            this.lblSplashTitle.TabIndex = 1;
            this.lblSplashTitle.Text = "Currency Convertor";
            this.lblSplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSplashLoading
            // 
            this.prgSplashLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgSplashLoading.Location = new System.Drawing.Point(3, 172);
            this.prgSplashLoading.Name = "prgSplashLoading";
            this.prgSplashLoading.Size = new System.Drawing.Size(254, 62);
            this.prgSplashLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSplashLoading.TabIndex = 2;
            // 
            // Splash
            // 
            this.AccessibleDescription = "Loading currency convertor. ";
            this.AccessibleName = "Loading screen.";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tblPnlSplash);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.tblPnlSplash.ResumeLayout(false);
            this.tblPnlSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSplashTitle;
        private System.Windows.Forms.ProgressBar prgSplashLoading;
    }
}

