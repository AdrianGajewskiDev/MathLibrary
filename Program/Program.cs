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
            Point point = new Point(0, -1);

            Point point2 = new Point(1, 1);

            Vector2 vector = point - point2;

            Console.WriteLine("Result: " + vector.x + ", " + vector.y);
            
        }
    }
}
