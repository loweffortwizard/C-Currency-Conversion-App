using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    class PoundsAndDollarsUS
    {
        private double CurrentValue;
        private int ConType;

        public PoundsAndDollarsUS(double poundsAndDollars, int conType)
        {
            //for value
            this.CurrentValue = poundsAndDollars;
            //for option
            this.ConType = conType;
        }//end constructor

        public void SetConversion(int setValue)
        {
            this.CurrentValue = setValue;
        }//end of set

        /// <summary>
        /// Getter method for current value of pounds and dollars
        /// </summary>
        /// <returns></returns>
        public double ConversionResult()
        {
            //pounds to dollars
            if (ConType == 1)
            {
                double result = CurrentValue * 1.38701;
                CurrentValue = result;
                //rate: http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=USD
            }//end if

            //dollars to pounds
            else if (ConType == 2)
            {
                double result = CurrentValue * 0.720974;
                CurrentValue = result;
                //rate http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=USD
            }//end else if

            else
            {
                //null
            }//end else

            return CurrentValue;
        }//end conversionresult
    }
}
