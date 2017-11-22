using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = new Point
            {
                X = 1,
                Y = 1
            };
            var x2 = new Point
            {
                X = 2,
                Y = 3
            };
            var x3 = x1 + x2;
            Console.WriteLine(x3);
            x3 = x1 - x2;
            Console.WriteLine(x3);
            x3 = x1++;
            Console.WriteLine(x3);
            x3 = x1--;
            Console.WriteLine(x3);
            Console.WriteLine(x1 > x2);

            object a = x1;
            //Point p = a;
            Point p = (Point)a;
            //Point p = (double)a;
            double a1 = x1;

            Console.ReadKey();
        }
    }
}
