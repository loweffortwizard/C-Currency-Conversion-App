using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    class PoundsAndEuros : ConversionOption
    {
        //private fields for storing the value and conversion type.
        private double CurrentValue;//storing value
        private int ConType;//storing conversion type

        /// <summary>
        /// Constructor method for creating a PoundsToEuros object. 
        /// Required parameters are the value to convert and the conversion type. 
        /// </summary>
        /// <param name="poundsAndEuros"></param>
        /// <param name="conType"></param>
        public PoundsAndEuros (double poundsAndEuros, int conType)
        {
            //for value
            this.CurrentValue = poundsAndEuros;

            //for option
            this.ConType = conType;
        }//end constructor

        /// <summary>
        /// Setter method for setting the conversion value. 
        /// </summary>
        /// <param name="setValue"></param>
        public void SetConversion(int setValue)
        {
            this.CurrentValue = setValue;
        }//end of set

        /// <summary>
        /// Getter method for current value of pounds and dollars.
        /// IF field conType is 1, will do pounds to euros conversion.
        /// Else if field conType is 2, will do euros to pounds conversion. 
        /// </summary>
        /// <returns></returns>
        public double ConversionResult()
        {
            //if pounds to euros
            if (ConType == 1)
            {
                //double field reuslt has value of the CurrentValue x conversion rate.
                double result = CurrentValue * 1.12076;

                //field CurrentValue is assigned value of result.
                CurrentValue = result;
                //rate: http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=EUR
            }//end if

            //if euros to pounds
            else if (ConType == 2)
            {
                //double field reuslt has value of the CurrentValue x conversion rate.
                double result = CurrentValue * 0.892252;

                //field CurrentValue is assigned value of result.
                CurrentValue = result;
                //rate http://www.xe.com/currencyconverter/convert/?Amount=1&From=GBP&To=EUR
            }//end else if

            //if no conType set, default to this. 
            else {
                //null
            }//end else

            return CurrentValue;
        }//end conversionresult
    }//end class
}//end namespace
