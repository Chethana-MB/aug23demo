using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericmethoddemo
{
    class abcd
    {
        public static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void swap(ref string a,ref string b)
        {
            string temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void swap(ref DateTime a, ref DateTime b)
        {
            DateTime temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            string s1 = "kiran";
            string s2 = "manu";
            Console.WriteLine("\n before swapping : ");
            Console.WriteLine("{0}--{1}", s1, s2);
            abcd.swap(ref s1, ref s2);
            Console.WriteLine("\n after swapping: ");
            Console.WriteLine("{0}--{1}", s1, s2);
            double kk1 = 123.45;
            double kk2 = 234.67;
            Console.WriteLine("\n before swap:");
            Console.WriteLine("{0}--{1}", kk1, kk2);
            Helper1.swap<double>(ref kk1, ref kk2);
            Console.WriteLine("\n after swap :");
            Console.WriteLine("{0}--{1}", kk1, kk2);
            DateTime day1 = DateTime.Now;
            DateTime day2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n before swap:");
            Console.WriteLine("{0}--{1}", day1, day2);
            Helper1.swap<DateTime>(ref day1, ref day2);
            Console.WriteLine("\n after swap :");
            Console.WriteLine("{0}--{1}", day1, day2);

            int a = 10; 
            int b= 20;

            Console.WriteLine("the sum of double numbers:{0}",Helper1.add<double>(kk1, kk2));
            Console.WriteLine("the sum of int numbers:{0}", Helper1.add<int>(a,b));
            Console.WriteLine("\n before swap:");
            Console.WriteLine("{0}--{1}", a, b);

            Helper2<int>.swap(ref a, ref b);
            Console.WriteLine("\n after swap:");
            Console.WriteLine("{0}--{1}", a, b);
            Console.WriteLine("the sum is {0} ", Helper1.add<int>(a, b));
            Console.ReadLine();
        }
    }
}
