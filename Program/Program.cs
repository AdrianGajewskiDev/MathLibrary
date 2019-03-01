using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 0);

            Vector2 vector = new Vector2(2, 3);

            Point point2 = point.AddVector(vector);

            Console.WriteLine("Result: " + point2.x + ", " + point2.y);
        }
    }
}
