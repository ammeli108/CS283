﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example01
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(-100, 100, 10);
            Console.WriteLine("修改前:");
            foreach (var v in vectors) ;
            Console.WriteLine(vectors);
        }
    }
}