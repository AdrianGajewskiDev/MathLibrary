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

        public float Lenght() 
        {
            float lenght = (float)Math.Sqrt((x * x) + (y * y));

            return (float)Math.Round(lenght, 2);
        }
      
    }
}
