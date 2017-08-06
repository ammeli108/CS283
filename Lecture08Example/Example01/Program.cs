using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////  Employee a = new Employee();

            //Employee a = new Manager();

            //a.Id = "0001";
            //a.Name = "abc";
            //a.BaseSalary = 3000;
            //Console.WriteLine(a);

            if (args.Length <= 0)
            {
                Employee employee = EmployeeFactory.Create
                    (EmployeeType.Default);
            }
            else
            {
                EmployeeType type = (EmployeeType)int.Parse(args[0]);
                Employee employee = EmployeeFactory.Create(type);
            }
        }
    }
}