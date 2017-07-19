using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03_Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator iphone = new Calculator();
            int[] numbers = new int[] { 1, 3, 19 };
            int result = iphone.Sum(2, 30);
            Console.WriteLine(result);
        }
    }
}