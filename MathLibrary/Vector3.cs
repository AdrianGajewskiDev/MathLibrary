namespace MathLibrary
{
    public class Vector3
    {
        public Vector3(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
            
        }

        public float x;
        public float y;
        public float z;

        public float DotProduct(ref Vector3 a, ref Vector3 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

    }
}
