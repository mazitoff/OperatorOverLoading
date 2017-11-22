using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    class Point
    {
        public bool IsDrawed { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public static Point operator +(Point x1, Point x2)
        {
            return new Point
            {
                X = x1.X + x2.X,
                Y = x1.Y + x2.Y
            };
        }

        public static Point operator -(Point x1, Point x2)
        {
            return new Point
            {
                X = x1.X - x2.X,
                Y = x1.Y - x2.Y
            };
        }

        public static Point operator ++(Point x1)
        {
            return new Point
            {
                X = x1.X++,
                Y = x1.Y++
            };
        }
        public static Point operator --(Point x1)
        {
            return new Point
            {
                X = x1.X--,
                Y = x1.Y--
            };
        }

        public static bool operator >(Point x1, Point x2)
        {
            return x1.X > x2.X && x1.Y > x2.Y;
        }

        public static bool operator <(Point x1, Point x2)
        {
            return x1.X < x2.X && x1.Y < x2.Y;
        }

        public static bool operator true(Point x1)
        {
            return x1.IsDrawed;
        }
        public static bool operator false(Point x1)
        {
            return !x1.IsDrawed;
        }

        public static implicit operator double(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
        }
        //public static explicit operator double(Point p)
        //{
        //    return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
        //}

        public override string ToString()
        {
            return $"X: {X}; Y: {Y}";
        }
    }
}
