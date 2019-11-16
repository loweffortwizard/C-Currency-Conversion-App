using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class frmHelpScreen : Form
    {
        public frmHelpScreen()
        {
            InitializeComponent();
        }//end frmHelpScreen

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnReturn_Click

        private void btnHelpExit_Click(object sender, EventArgs e)
        {
            //If users chooses yes to close app, do this:
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //end prog
                Application.Exit();
            }//end of if

            //else do not close app
            else
            {
                //continue
                this.Activate();
            }//end of else
        }//end btnHelpExit_Click

        private void frmHelpScreen_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Student\source\repos\CurrencyConverterApp\txt\helpscreen_main.txt";
            string textLine = "";

            if(File.Exists(fileName) == true)
            {
                StreamReader objReadText = new StreamReader(fileName);

                do
                {
                    textLine = textLine + objReadText.ReadLine() + "\r\n";
                } while (objReadText.Peek() != -1);
            }//end if
            else
            {
                MessageBox.Show("Could not locate help screen file." + fileName, "Error Unknown File ");
            }//end else

            txtHelpOutput.Text = textLine;

            //creating tool tips for exit and return button
            ToolTip ttExit = new ToolTip();
            ToolTip ttReturn = new ToolTip();

            //setting up text for tool tips
            ttExit.SetToolTip(this.btnHelpExit, "CLick here to exit the application.");
            ttReturn.SetToolTip(this.btnReturn, "Click here to return to the previous form.");

        }//end frmHelpScreen_Load
    }
}
