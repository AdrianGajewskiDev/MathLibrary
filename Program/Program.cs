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
            //  Point point = new Point(0, -1);

            //  Point point2 = new Point(1, 1);

            //  Point point3 = new Point(2, -1);

            //  Vector2 vectorCP = point - point3; //-2, -2
            //  Vector2 vectorIP = point - point2;

            //  float lenght_sqr_cp = vectorCP.LengthSqr();
            //  float length_sqr_ip = vectorIP.LengthSqr();

            ////  Console.WriteLine("Result: " + vector.x + ", " + vector.y);
            //  Console.WriteLine("Lenght squared of Cp: " + lenght_sqr_cp );
            //  Console.WriteLine("Lenght squared of Ip: " + length_sqr_ip);

            Vector2 vector = new Vector2(3, 4);
            Console.WriteLine("Pac man initial speed: " + vector.Lenght());

            Vector2 doubled = vector.Increase(2);
            Console.WriteLine("Pac man doubled speed: " + doubled.Lenght());

            Vector2 halved = vector.Reduce(2);
            Console.WriteLine("Pac man halved speed: " + halved.Lenght());




        }
    }
}
