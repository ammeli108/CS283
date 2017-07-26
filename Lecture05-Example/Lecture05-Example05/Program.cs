using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05_Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int total = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(-1000, 1001);
            }

            foreach (int number in numbers)
            {
                total += number; // 程式只有一行, {}其實可以不用寫
            }
            Console.WriteLine(total);
        }
    }
}