using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolPCLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product a = new Product();
            a.Price = 3333;

            Product b = new Product();
            b.Price = 1234;

            Console.WriteLine("a.Price = {0}, a.Id{1}", a.Price, a.Id);
            Console.WriteLine("b.Price = {0}, b.Id{1}", b.Price, b.Id);

            //a.Price = 300.0f;
            ////        a.SetPrice(30);

            ////Product b = a;

            ////         Console.WriteLine("a.Price = {0}", a.GetPrice());
            ////         Console.WriteLine("b.Price = {0}", b.GetPrice());
            //Console.WriteLine("a.Price = {0}", a.Price);
            //Console.WriteLine("b.Price = {0}", b.Price);

            //b.Price = 300.0f;
            ////         b.SetPrice(510);
            //Console.WriteLine("修改後");
            ////         Console.WriteLine("a.Price = {0}", a.GetPrice());
            ////         Console.WriteLine("b.Price = {0}", b.GetPrice());
            //Console.WriteLine("a.Price = {0}", a.Price);
            //Console.WriteLine("b.Price = {0}", b.Price);
        }
    }
}