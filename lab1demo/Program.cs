using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeDLL;


namespace lab1demo
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();//setting values 
            obj.EmployeeID = 101;
            obj.EmpName = "rahul";
            obj.Salary = 500000;
            obj.Dept = "HR";
            obj.Address = "gokulam";
            obj.City = "mysuru";
            //displaying values.....
            Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                obj.EmployeeID, obj.EmpName, obj.Salary,obj.Dept, obj.City,obj.Address);
            Employee[] emplist = new Employee[3];
            for(int i=0;i<emplist.Length;i++)
            {
                Console.WriteLine("\n enter employee {0} details:", i + 1);
                Employee emp = new Employee();
                Console.Write("enter employee id:");
                emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n enter salary");
                emp.EmpName = Console.ReadLine();
                Console.Write("\n enter salary");
                emp.Salary= Convert.ToInt32(Console.ReadLine());
                emplist[i] = emp;
            }
            Console.WriteLine("\n displaying employees name and salary ");
            foreach (Employee emp in emplist)
            {
                Console.WriteLine("{0}-{1}", emp.EmpName, emp.Salary);
            }
            Console.ReadLine();
        }
    }
}









