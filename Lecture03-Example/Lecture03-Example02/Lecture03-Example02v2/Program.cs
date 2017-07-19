using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03_Example02v2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 0,
                    Y = 0,
                },
                Angle = 0
            };

            for (var count = 0; count < 4; count++)
            {
                MoveForward(100);
                TurnRight(120);
            }
        }
    }
}