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
            //         Calculator iphone = new Calculator();    代數公式例子
            //        int result = iphone.add(2, 3);
            //        Console.WriteLine(result);

            //         Calculator iphone = new Calculator();      迴圈加總範例(等差數列)
            //         int result = iphone.Sum(2, 30);
            //         Console.WriteLine(result);

            Calculator iphone = new Calculator();

            // int[] numbers = new int[4]      陣列也可以這樣寫
            // numbers[0] = 1;
            // numbers[1] = 3;
            // numbers[2] = 19;
            // numbers[3] = 21;

            int[] numbers = new int[] { 1, 3, 19, 21 }; // 假裝隨機塞幾個值進去計算

            int result = iphone.Sum(numbers);
            Console.WriteLine(result);
        }
    }
}