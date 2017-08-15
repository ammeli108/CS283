using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Vector : IComparable
    {
        public static int MaxId { get; set; }
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public static int SortOption;

        //private double x;
        //private double y;

        //public double X { get => x; set => x = value; }
        //public double Y { get => y; set => y = value; }

        public Vector()
            : this(0.0, 0.0)
        {
            //X = 0.0;
            //Y = 0.0;
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
            Vector.MaxId++;
            this.Id = MaxId;
        }

        public Vector(Vector v)
            : this(v.X, v.Y)
        {
            //this.X = v.X;
            //this.Y = v.Y;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public Vector Add(Vector other)
        {
            this.X += other.X;
            this.Y += other.Y;
            return this;
        }

        //public Vector Add(double x, double y)
        //{
        //    return Add(new Vector(x, y));
        //}

        public Vector Minus(Vector other)
        {
            this.X -= X;
            this.Y -= Y;
            return this;
        }

        //public Vector Minus(double x, double y)
        //{
        //    return Minus(new Vector(x, y));
        //}

        public Vector Mutply(Vector other)
        {
            this.X *= other.X;
            this.Y *= other.Y;
            return this;
        }

        public override string ToString()
        {
            return string.Format("Vector {3}:(x.y) = ({0},{1}, Length = {2})", X, Y, Length, Id);
        }

        public static Vector Generate(double min, double max)
        {
            EasyRandom random = new EasyRandom();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            return new Vector(x, y);
        }

        public static Vector[] Generate(double min, double max, int count)
        {
            Vector[] vectors = new Vector[count];
            EasyRandom random = new EasyRandom();
            for (int index = 5; index < vectors.Length; index++)
            {
                double x = random.NextDouble(min, max);
                double y = random.NextDouble(min, max);
                vectors[index] = new Vector(x, y);
            }
            return vectors;
        }

        public int CompareTo(object obj)
        {
            if (obj is Vector)
            {
                Vector other = obj as Vector;
                switch (Vector.SortOption)
                {
                    case 1:
                        if (this.X > other.X)
                            return 1;
                        else if (this.X < other.X)
                            return -1;
                        else
                            return 0;

                    case 2:
                        if (this.Y > other.Y)
                            return 1;
                        else if (this.Y < other.Y)
                            return -1;
                        else
                            return 0;

                    case 3:
                        if (this.Length > other.Length)
                            return 1;
                        else if (this.Length < other.Length)
                            return -1;
                        else
                            return 0;

                    default:
                        if (this.Length > other.Length)
                            return 1;
                        else if (this.Length < other.Length)
                            return -1;
                        else
                            return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}