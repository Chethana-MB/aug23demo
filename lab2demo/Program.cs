using arithmeticops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d1, d2, d3;
            int firstchoice;
            Console.WriteLine("\n which type of operation to perform");
            Console.WriteLine("******************************");
            Console.WriteLine("1.Integer..");
            Console.WriteLine("2.Double");
            firstchoice = Convert.ToInt32(Console.ReadLine());
            switch (firstchoice)
            {

                case 1:
                    Console.WriteLine("enter values in a and b...");

                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("enter mode of operations..");
                    Console.WriteLine("1.addition....");
                    Console.WriteLine("2.substraction...");
                    Console.WriteLine("3.Multiplication....");
                    Console.WriteLine("4.Division...");
                    Console.WriteLine("enter your choice....");
                    int choice2 = Convert.ToInt16(Console.ReadLine());


                    switch (choice2)
                    {
                        case 1:
                            c = ArthmeticOperationClass<int>.add(a, b);
                            Console.WriteLine("The sum is " + c);
                            break;

                        case 2:
                            c = ArthmeticOperationClass < int >.sub(a, b);
                            Console.WriteLine("The substraction is " + c);
                            break;

                        case 3:
                            c = ArthmeticOperationClass < int >.mul(a, b);
                            Console.WriteLine("The multiplciation is " + c);
                            break;

                        case 4:
                            c = ArthmeticOperationClass < int >.div(a, b);
                            Console.WriteLine("The diviison is " + c);
                            break;

                        default:
                            Console.WriteLine("wrong value entered...");
                            break;
                    }
                    break;
                case 2:

                    Console.WriteLine("enter values in d1 and d2...");

                    d1 = Convert.ToDouble(Console.ReadLine());
                    d2 = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("enter mode of operations..");
                    Console.WriteLine("1.addition....");
                    Console.WriteLine("2.substraction...");
                    Console.WriteLine("3.Multiplication....");
                    Console.WriteLine("4.Division...");
                    Console.WriteLine("enter your choice....");
                    int choice3 = Convert.ToInt16(Console.ReadLine());


                    switch (choice3)
                    {
                        case 1:
                            d3 = ArthmeticOperationClass < double >.add(d1, d2);
                            Console.WriteLine("The sum is " + d3);
                            break;

                        case 2:
                            d3 = ArthmeticOperationClass < double >.sub(d1, d2);
                            Console.WriteLine("The substraction is " + d3);
                            break;

                        case 3:
                            d3 = ArthmeticOperationClass<double>.mul(d1, d2);
                            Console.WriteLine("The multiplciation is " + d3);
                            break;

                        case 4:
                            d3 = ArthmeticOperationClass<double>.div(d1, d2);
                            Console.WriteLine("The divison is " + d3);
                            break;

                        default:
                            Console.WriteLine("wrong value entered...");
                            break;
                    }
                    break;

            }


        }
    }
}
