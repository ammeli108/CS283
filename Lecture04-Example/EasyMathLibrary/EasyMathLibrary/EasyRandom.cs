using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class EasyRandom
    {
        private Random random;

        public EasyRandom()
        {
            random = new Random();
        }

        public double NextDouble(double start, double end)
        {
            double x = random.NextDouble();   // NextDouble = .net的RANDOM, 會生一個 0-1的亂數
            return (end - start) * x + start;
        }

        public double[] NextDouble(double start, double end, int length) // 定義
        {
            double[] numbers = new double[length];
            for (int index = 0; index < length; index++)
            {
                numbers[index] = NextDouble(start, end);
            }
            return numbers;
        }

        public int Next(int start, int end)
        {
            return random.Next(start, end);
        }

        public int Next()
        {
            return random.Next();
        }
    }
}