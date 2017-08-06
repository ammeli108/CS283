using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  Vector v1 = new Vector(10.0, 20.0);

            //  Vector v1 = Vector.Generate(-1000, 101.0);

            ////v.X = 1.0;
            ////v.Y = 1.9;
            //  Vector v2 = v1.Clone();
            //Vector v3 = v2();

            //Vector v2 = v1.Clone();
            //v2.X = 11;

            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //  Console.WriteLine(v1.Add(new Vector(1.0, 2.0)).Minus(new Vector(10.0, 10.0)));
            // Console.WriteLine(v1.Add(1, 2).Minus(10, 10));

            //Console.WriteLine(v2);
            //Console.WriteLine(v3);

            Vector[] vectors = Vector.Generate(-100.0, 101.0, 10);

            foreach (var v in vectors)
                Console.WriteLine(v);
        }
    }
}