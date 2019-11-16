using System;//using generic system elements (messagbox, application etc.)
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;//used for splash screen loading
using System.Threading.Tasks;
using System.Windows.Forms;//using GUI form elements

//working under namespace CurrencyConverterApp
namespace CurrencyConverterApp
{
    public partial class frmMenu : Form
    {

        //instantiation 
        frmConversion objfrm = new frmConversion();

        /// <summary>
        /// Method for initialising componets and handling splash screen thread.
        /// </summary>
        public frmMenu()
        {
            //run thread for runsplash method
            Thread trdSplash = new Thread(new ThreadStart(RunSplash));

            //begin thread
            trdSplash.Start();

            //sleep for 3 seconds
            Thread.Sleep(3000);

            //ini all needed elements
            InitializeComponent();

            //end thread ---- save on resources by killing unneeded processes
            trdSplash.Abort();
        }//end menu

        /// <summary>
        /// Method for running splash windows.
        /// </summary>
        public void RunSplash()
        {
            //run splash screen application
            Application.Run(new Splash());
        }//end runsplash

        /// <summary>
        /// Method for exiting the application. Will prompt user if they are sure they wish to exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
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

        }//end exit

        /// <summary>
        /// Method for taking users to the pounds and dollars conversions section of the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoundsAndDollarUS_Click(object sender, EventArgs e)
        {
            //assign value of 1 to ConChoice in class ConversionOption
            ConversionOption.ConChoice = 2;

            //show conversion form
            objfrm.Show();

            //close form
            this.Hide();

        }//end btnPoundsAndDollarUS_Click

        /// <summary>
        /// Method for taking users to the pounds and euros conversions section of the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoundsAndEuros_Click(object sender, EventArgs e)
        {
            //assign value of 2 to ConChoice in class ConversionOption
            ConversionOption.ConChoice = 1;

            //show conversion form
            objfrm.Show();

            //close form
            this.Hide();
        }//end btnPoundsAndEuros_Click

        /// <summary>
        /// Method for taking users to the pounds and yen conversions section of the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoundsAndYen_Click(object sender, EventArgs e)
        {
            //assign value of 3 to ConChoice in class ConversionOption
            ConversionOption.ConChoice = 3;

            //show conversion form
            objfrm.Show();

            //close form
            this.Hide();
        }//end btnPoundsAndYen_Click

        /// <summary>
        /// Method for taking users to the cent and inch conversions section of the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCentAndInch_Click(object sender, EventArgs e)
        {
            //assign value of 4 to ConChoice in class ConversionOption
            ConversionOption.ConChoice = 4;

            //show conversion form
            objfrm.Show();

            //close form
            this.Hide();
        }//end btnCentAndInch_Click

        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            frmHelpScreen objHelp = new frmHelpScreen();
            objHelp.Show();
        }//end btnMenuHelp_Click

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //creating tool tips for each button on the menu
            ToolTip ttPAndD = new ToolTip();
            ToolTip ttPAndE = new ToolTip();
            ToolTip ttPAndY = new ToolTip();
            ToolTip ttCAndI = new ToolTip();
            ToolTip ttHelp = new ToolTip();
            ToolTip ttExit = new ToolTip();

            //setting text for each of the buttons in the menu
            ttPAndD.SetToolTip(this.btnPoundsAndDollarUS, "CLick here to open the pounds and dollars form.");
            ttPAndE.SetToolTip(this.btnPoundsAndEuros, "CLick here to open the pounds and euros form.");
            ttPAndY.SetToolTip(this.btnPoundsAndYen, "CLick here to open the pounds and yen form.");
            ttCAndI.SetToolTip(this.btnCentAndInch, "CLick here to open the cent and inch form.");
            ttHelp.SetToolTip(this.btnMenuHelp, "CLick here to open the help screen form.");
            ttExit.SetToolTip(this.btnExit, "CLick here to close the application.");
        }//end frmMenu_Load
    }//end class
}//end namespace
