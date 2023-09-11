using set_getmethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_getmethods
{
    class Customer {
        private int Id;
        private string custname;

        //write only
        public int ID
        {
            set
            {
                Id = value;
            }

        }
        public string CustName
        {
            set
            {

                this.custname = value;
            }

        }
        public void display()
        {
            Console.WriteLine("{0}--{1}", this.Id, this.custname);

        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer cc = new Customer();
        cc.ID = 101;
        cc.CustName = "harish";
        cc.display();
        Console.ReadLine();
    }
}
