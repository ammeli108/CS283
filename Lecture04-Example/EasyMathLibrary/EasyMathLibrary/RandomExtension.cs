using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public static class RandomExtension // 當外掛吧
    {
        public static double NextDouble(this Random random, double start, double end)
        {
            double x = random.NextDouble();   // NextDouble = .net的RANDOM, 會生一個 0-1的亂數
            return (end - start) * x + start;
        }
    }
}