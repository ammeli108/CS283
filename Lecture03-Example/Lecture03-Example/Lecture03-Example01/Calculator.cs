using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03_Example01
{
    public class Calculator
    {
        public int add(int x, int y)
        {
            int result = 2 * x + 3 * y;
            return result;
        }

        public int Sum(int Start, int end)  // 由Start至End 順序塞入值
        {
            int total = 0;
            for (var count = Start; count <= end; count++)
            {
                total += count;   // total = 迴圈運算後的值
            }
            return total;
        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            for (var count = 0; count < numbers.Length; count++)  // Length = 取陣列中所有值的總數(陣列的長度)
            {
                total += numbers[count];   //  var[count], var後加 陣列[count]
            }
            return total;
        }
    }
}