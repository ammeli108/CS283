using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03_Example03
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
                    Y = 0
                },

                //          Person elsa = new Person();    也可以這樣寫
                //          elsa.Name = "Elsa";
                //          elsa.Pos = new Position();
                //          elsa.Pos.X = 0;
                //          elsa.Pos.Y = 0;

                Angle = 0
            };

            //          elsa.WriteLine();
            //          elsa.MoveForward(100);
            //          elsa.TurnRight(45);
            //          elsa.MoveForward(100);
            //          elsa.DrawSquare(50);

            for (var count = 0; count < 3; count++)
            {
                elsa.DrawSquare(100);
                elsa.TurnRight(120);
            }
        }
    }
}