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

        public Vector2 Normalized()
        {
            Vector2 normalized = new Vector2();
            normalized.x = this.x / Length();
            normalized.y = this.y / Length();

            return normalized;
        }

        public Vector2 AddVector(ref Vector2 vector)
        {
            Vector2 vector2 = new Vector2();
            vector2.x = x + vector.x;
            vector2.y = y + vector.y;

            return vector2;
        }

        public Vector2 SubtractVector(ref Vector2 vector)
        {
            return new Vector2(x - vector.x, y - vector.y);
        }

        public float Length() 
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
