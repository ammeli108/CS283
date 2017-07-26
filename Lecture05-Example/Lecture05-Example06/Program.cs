using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05_Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // int next = 1;
            int next = 0;
            int total = 0;
            while (total < 10)
            {
                total += (next++);
            }
            Console.WriteLine("next =" + next);
            Console.WriteLine("total =" + total);
        }
    }
}