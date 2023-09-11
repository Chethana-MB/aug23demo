using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericmethoddemo
{
    internal class Helper2<T>
    {
        public static void swap(ref T a, ref T b)
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
