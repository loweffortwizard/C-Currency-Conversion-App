using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importing libs.

//External class created under ConversionProgramV1 namespace. 
namespace ConversionProgramV1
{
    /// <summary>
    /// Class for converting centimeters to inches.
    /// </summary>
    //class CentToInch has inheritance from class BaseConversion. 
    //it has all methods in the parent class. 
    class CentToInch : BaseConversion
    {
        private double CentToInchConversion;

        //constructor method for the class. 
        public CentToInch(double centToInchConversion) : base(1)
        {
            this.CentToInchConversion = centToInchConversion;
        }//end of constructor

        public void SetConversion(double centToInchConversion)
        {
            this.CentToInchConversion = centToInchConversion;
        }//end of set

        //getter method for converting the value entered by the user. 
        public double ConversionResult()
        {
            double result = CentToInchConversion * 0.39370;

            //return result
            return result;
        }//end of conversion method.
    }//end of class.
}//end of namespace.
