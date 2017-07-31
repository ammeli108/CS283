using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpolyeeNS;

namespace EmpolyeeSalary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Empolyee a = new Empolyee();
            a.BaseSalary = 22000;
            a.Benefit = 0;
            Console.WriteLine(a.Salary);

            Empolyee b = new Empolyee();
            b.BaseSalary = 33000;
            b.Benefit = b.BaseSalary * 15 / 100;
            Console.WriteLine(b.Salary);

            Empolyee c = new Empolyee();
            Console.Write("請輸入底薪:");
            c.BaseSalary = int.Parse(Console.ReadLine());
            Console.Write("請輸入獎金:");
            c.Benefit = int.Parse(Console.ReadLine());
            Console.Write("薪資如下:");
            Console.WriteLine(c.Salary);
        }
    }
}

//EmployeeClass aEmployee = new EmployeeClass();
//Console.Write("請輸入底薪:");
//            string a = Console.ReadLine();
//Console.Write("請輸入獎金:");
//            string b = Console.ReadLine();
//aEmployee.Basesalary = Convert.ToInt32(a);
//            aEmployee.Benefit = Convert.ToInt32(b);
//            Console.WriteLine("您的薪水:{0}", aEmployee.Salary);