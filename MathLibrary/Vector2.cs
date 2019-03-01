using System;

namespace MathLibrary
{
    public class Vector2
    {
        public Vector2(float X, float Y)
        {
            x = X;
            y = Y;
        }

        public Vector2() {}

        public float x;
        public float y;

        public Vector2 Increase(float s)
        {
            Vector2 scaled = new Vector2();

            scaled.x = x * s;
            scaled.y = y * s;

            return scaled;
        }

        public Vector2 Reduce(float s)
        {
            Vector2 scaled = new Vector2();
            scaled.x = x / s;
            scaled.y = y / s;

            return scaled;
        }

        public float Lenght() 
        {
            float lenght = (float)Math.Sqrt((x * x) + (y * y));

            return (float)Math.Round(lenght, 2);
        }

        public float LengthSqr()
        {
            float lenght = (x * x) + (y * y);

            return (float)Math.Round(lenght, 2);
        }
      
    }
}
