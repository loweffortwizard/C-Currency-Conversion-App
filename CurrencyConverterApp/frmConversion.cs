using ConversionProgramV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class frmConversion : Form
    {
        /// <summary>
        /// Default method for form initalisation. 
        /// </summary>
        public frmConversion()
        {
            InitializeComponent();
        }//end frmConversion

        /// <summary>
        /// Method for displaying converted user input into a defined currency.
        /// Also allows for double data type validation and currency symbol printing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //getting currency symbols
            CultureInfo us = new CultureInfo("en-US");
            CultureInfo gb = new CultureInfo("en-GB");
            CultureInfo jp = new CultureInfo("ja-JP");
            CultureInfo eu = new CultureInfo("de-DE");

            //out for bool
            double number;

            //store users input in var userInput
            var userInput = txtInput1.Text;

            //check if userInput can be converted to a double data type (does not convert! only checks if it can)
            bool validateInput = Double.TryParse(userInput, out number);

            //if first radiobutton is checked/active, do this
            if (rdoOption1.Checked)
            {
                //if userInput is able to be converted to double, do this
                if (validateInput)
                {
                    //int var convertType has assigned value returned from ConChoice method in ConversionOption class
                    int convertType = ConversionOption.ConChoice;

                    //switch convertType to determine what conversion method will take place
                    switch (convertType)
                    {
                        //if conversion method is 1 (pounds to euros) do this
                        case 1:
                            //creating object from PoundsAndEuros class, with value of userInput and conType
                            PoundsAndEuros poundsAndEuros = new PoundsAndEuros(Convert.ToDouble(userInput), 1);

                            //resultOfPoundsAndEurosCon has assigned value returned from ConversionResult method, in poundsAndEuros object
                            double resultOfPoundsAndEurosCon = poundsAndEuros.ConversionResult();

                            //print result of variable resultOfPoundsAndEurosCon as a string (with 2 decimal points), with currency symbol
                            txtOutput.Text = eu.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfPoundsAndEurosCon, 2));

                            //break out of switch if case 1 met and completed. 
                            break;

                        //if conversion method is 2 (pounds to dollars) do this
                        case 2:
                            //creating object from PoundsAndDollarsUS class, with value of userInput and conType
                            PoundsAndDollarsUS poundsToDollarsUS = new PoundsAndDollarsUS(Convert.ToDouble(userInput), 1);

                            //resultOfPoundsToDollarsUSCon has assigned value returned from ConversionResult method, in poundsToDollarsUS object
                            double resultOfPoundsToDollarsUSCon = poundsToDollarsUS.ConversionResult();

                            //print result of variable resultOfPoundsToDollarsUSCon as a string (with 2 decimal points), with currency symbol
                            txtOutput.Text = us.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfPoundsToDollarsUSCon, 2));

                            //break out of switch if case 1 met and completed. 
                            break;

                        //if conversion method is 3 (pounds to yen) do this
                        case 3:
                            PoundsAndYen poundsAndYen = new PoundsAndYen(Convert.ToDouble(userInput), 1);
                            double resultOfpoundsAndYenCon = poundsAndYen.ConversionResult();
                            txtOutput.Text = jp.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfpoundsAndYenCon, 2));
                            break;

                        //if conversion method is 4 (cent to inch) do this
                        case 4:
                            CentToInch centToInch = new CentToInch(Convert.ToDouble(userInput));
                            double resultOfCentToInchCon = centToInch.ConversionResult();
                            txtOutput.Text = Convert.ToString(Math.Round(resultOfCentToInchCon, 2) + "in");
                            break;
                    }//end switch
                }//end if
                else
                {
                    MessageBox.Show("PLease enter a whole number.");
                }//end else

            }//end if
            else if (rdoOption2.Checked)
            {
                //if it is number
                if (validateInput)
                {
                    int convertType = ConversionOption.ConChoice;

                    switch (convertType)
                    {
                        case 1:
                            //instasiation
                            PoundsAndEuros poundsAndEuros = new PoundsAndEuros(Convert.ToDouble(userInput), 2);
                            double resultOfPoundsToEurosCon = poundsAndEuros.ConversionResult();
                            txtOutput.Text = gb.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfPoundsToEurosCon, 2));
                            break;
                        case 2:
                            PoundsAndDollarsUS poundsToDollarsUS = new PoundsAndDollarsUS(Convert.ToDouble(userInput), 2);
                            double resultOfPoundsToDollarsUSCon = poundsToDollarsUS.ConversionResult();
                            txtOutput.Text = gb.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfPoundsToDollarsUSCon, 2));
                            break;
                        case 3:
                            PoundsAndYen poundsAndYen = new PoundsAndYen(Convert.ToDouble(userInput), 2);
                            double resultOfpoundsAndYenCon = poundsAndYen.ConversionResult();
                            txtOutput.Text = gb.NumberFormat.CurrencySymbol + Convert.ToString(Math.Round(resultOfpoundsAndYenCon, 2));
                            break;
                        case 4:
                            InchToCent inchToCent = new InchToCent(Convert.ToDouble(userInput));
                            double resultOfInchToCentCon = inchToCent.ConversionResult();
                            txtOutput.Text = Convert.ToString(Math.Round(resultOfInchToCentCon, 2) + "cm");
                            break;
                    }//end switch
                }//end if

                else
                {
                    MessageBox.Show("PLease enter a whole number.");
                }//end else

            }//end else if
            else
            {
                MessageBox.Show("Please choose a conversion option.");
            }//end else
            //MessageBox.Show(Convert.ToString(ConversionOption.ConChoice));
            
        }//end btnCalculate_Click

        private void btnConversionExit_Click(object sender, EventArgs e)
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
        }//end btnConversionExit_Click

        private void btnConversionReturn_Click(object sender, EventArgs e)
        {
            //instansiation 
            frmMenu objFrm = new frmMenu();

            //show menu form
            objFrm.Show();

            //close form
            this.Close();
        }//end btnConversionReturn_Click

        private void btnConversionHelp_Click(object sender, EventArgs e)
        {
            frmHelpScreen objHelp = new frmHelpScreen();
            objHelp.Show();
        }//end btnConversionHelp_Click

        private void frmConversion_Load(object sender, EventArgs e)
        {
            int convertType = ConversionOption.ConChoice;

            //check value of convertType
            switch (convertType)
            {
                case 1:
                    rdoOption1.Text = ("Pounds to Euros (de-DE)");
                    rdoOption2.Text = ("Euros (de-DE) to Pounds");
                    break;//end switch if case 1 met

                case 2:
                    rdoOption1.Text = ("Pounds to Dollars (en-US)");
                    rdoOption2.Text = ("Dollars (en-US) to Pounds");
                    break;//end switch if case 2 met

                case 3:
                    rdoOption1.Text = ("Pounds to Yen (ja-JP)");
                    rdoOption2.Text = ("Yen (ja-JP) to Pounds");
                    break;//end switch if case 3 met

                case 4:
                    rdoOption1.Text = ("Cent to Inch");
                    rdoOption2.Text = ("Inch to Cent");
                    break;//end switch if case 4 met
                
                //if above fails, do this as default
                default:

                    //message box to end app or go to menu
                    if (MessageBox.Show("Error, could not determine choice. " +
                        "Would you like to return to the menu?", "Error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                        frmMenu objFrmMenu = new frmMenu();
                        objFrmMenu.Show();
                    }//end of if
                    else
                    {
                        //end prog
                        Application.Exit();
                    }//end of else

                    break;//end switch
            }//end of switch

            //creating tool tips for calc, return, help and exit buttons
            ToolTip ttCalc = new ToolTip();
            ToolTip ttReturn = new ToolTip();
            ToolTip ttHelp = new ToolTip();
            ToolTip ttExit = new ToolTip();

            //setting up text for calc, return, help and exit buttons
            ttCalc.SetToolTip(this.btnCalculate, "Click here to convert your value.");
            ttReturn.SetToolTip(this.btnConversionReturn, "Click here to return to the menu.");
            ttHelp.SetToolTip(this.btnConversionHelp, "Click here to go to the help screen.");
            ttExit.SetToolTip(this.btnConversionExit, "CLick here to close the application.");

        }//end frmConversion_Load

        private void tblPnlConversionFooter_Paint(object sender, PaintEventArgs e)
        {
            //do not remove
        }//end tblPnlConversionFooter_Paint

        private void pbxConversionLogo_Click(object sender, EventArgs e)
        {
            //could add hyperlink in future.
        }//end pbxConversionLogo_Click

        private void tblPnlConversionMain_Paint(object sender, PaintEventArgs e)
        {
            //do not remove 
        }
    }//end class
}//end namespace
