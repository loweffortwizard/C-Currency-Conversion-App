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
    /// Class for converting inches to centimeters.
    /// </summary>
    class InchToCent : BaseConversion
    {
        //declaring private integer InchToCentConversion. 
        //Notes - this variable is only accessbale to this class, must use getters and setters to alter and retrive data stored in varibale. 
        private double InchToCentConversion;

        //constructor method for the class. 
        public InchToCent(double inchToCentConversion) : base(2)
        {
            //InchToCentConversion has value of inchToCentConversion.
            //Basically initialising the private variable for alteration/retrieval. 
            this.InchToCentConversion = inchToCentConversion;
        }//end of constructor

        public void SetConversion(double inchToCentConversion)
        {
            this.InchToCentConversion = inchToCentConversion;
        }//end of set

        //getter method for converting the value entered by the user. 
        public double ConversionResult()
        {
            double result = InchToCentConversion * 25.4;

            //return result
            return result;
        }//end of conversion method.
    }//end of class.
}//end of namespace.
