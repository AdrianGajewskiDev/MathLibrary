using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class Point
    {
        public Point(float X, float Y)
        {
            x = X;
            y = Y;
        }

        public Point() { }

        public float x;
        public float y;

        public Point AddVector(Vector2 vector)
        {

            Point p2 = new Point();
            p2.x = x + vector.x;
            p2.y = y + vector.y;

            return p2;
        }
    }
}
