using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticops
{
    public class ArthmeticOperationClass<T>
    {
        public static T add(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a + b;
        }
        public static T sub(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a - b;
        }
        public static T mul(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a * b;
        }
        public static T div(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a / b;
        }
    }
}





    
