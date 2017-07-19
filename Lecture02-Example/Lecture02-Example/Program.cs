using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字1");

            int number1 = 0;
            int.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("請輸入數字2");

            int number2 = 0;
            int.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("{0}+{1}={2}"
                , number1
                , number2
                , number1 + number2
                );
        }
    }
}