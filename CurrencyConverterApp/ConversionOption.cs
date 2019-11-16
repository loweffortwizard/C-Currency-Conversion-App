using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    class ConversionOption
    {
        //field for storing the option choice
        private static int conChoice;

        //get/set
        public static int ConChoice
        {
            get { return conChoice; }
            set { conChoice = value; }
        }//end of getter/setter

        //class constructor.
        public ConversionOption()
        {
            //null
        }//end constructor
    }//end class
}//end namespace
