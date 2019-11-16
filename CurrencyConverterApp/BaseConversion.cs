using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importing libs.

//External class created under ConversionProgramV1 namespace. 
namespace ConversionProgramV1
{
    /// <summary>
    /// BaseConversion class for generic inheritence of other conversion specific classes.
    /// </summary>
    //Creating class BaseConversion used for getting and setting conversion values as well as being the parent for the other classes. 
    class BaseConversion
    {
        //declaring private integer ConversionChoice. 
        //Notes - this variable is only accessbale to this class, must use getters and setters to alter and retrive data stored in varibale. 
        private int ConversionChoice;

        //Constructor method for class. 
        //Note - must have the same name as the class. 
        public BaseConversion(int conversionChoice)
        {
            //initialising the private variable ConversionChoice to be equal to conversionChoice. 
            this.ConversionChoice = conversionChoice;
        }//end of method.

        //setter method used to set the value of a private field from an external source. 
        //set allows to change value for private field. 
        public void SetConversion(int conversionChoice)
        {
            //used to initialise private variable ConversionChoice by giving value of conversionChoice to it. 
            this.ConversionChoice = conversionChoice;
        }//end of set

        //getter method fr getting the value and returning the value to the private field conversionChoice. 
        public int GetConversion()
        {
            //return conversionChoice value. 
            return ConversionChoice;
        }//end of get
    }//end of class.
}//end of namespace
