using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    class PoundsAndYen
    {
        private double CurrentValue;
        private int ConType;

        public PoundsAndYen(double poundsAndYen, int conType)
        {
            //for value
            this.CurrentValue = poundsAndYen;
            //for option
            this.ConType = conType;
        }//end constructor

        public void SetConversion(int setValue)
        {
            this.CurrentValue = setValue;
        }//end of set

        /// <summary>
        /// Getter method for current value of pounds and yen
        /// </summary>
        /// <returns></returns>
        public double ConversionResult()
        {
            //pounds to yen
            if (ConType == 1)
            {
                double result = CurrentValue * 146.896;
                CurrentValue = Convert.ToInt32(result);
                //rate: http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=JPY
            }//end if

            //yen to pounds
            else if (ConType == 2)
            {
                double result = CurrentValue * 0.00680752;
                CurrentValue = Convert.ToDouble(result);
                //rate http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=JPY
            }//end else if

            else
            {
                //null
            }//end else

            return CurrentValue;
        }//end conversionresult
    }//end class
}//end namespace
