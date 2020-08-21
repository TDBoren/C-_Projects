using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerClass_Assignment
{
    
    class Integer
    {
        public static int Multiply (int IntegerM)
        {
            return IntegerM * 10;
        }
        //public int Add;
        //public int Divide;
        //public int Subtract;
    }
}
//Hi Troy,

//The class Integer that was created has properties, not methods.To create a method it would need to be written like this:

//public static int MethodName(int parameterName)
//{
//    code that describes what the method does
//      return outputVariableName;
//}

//Then in the Main() program the method could be called and assigned to a variable like so:

//int result = Integer.MethodName(5);

//Currently, this assignment is creating new Integer objects, then assigning values to its properties that are the result of a math operation.The requirements ask for methods from the class to be called to perform the math operations but there are no methods in the Integer class. Please make this change and resubmit.If you have any questions please reach out to us for help.

//-Mark