using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericmethoddemo
{
    class Helper1
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
      public static T add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum;
            sum = x + y;
            return sum;
        }
    }
}

   
        
    