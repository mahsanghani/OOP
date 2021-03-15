using System;

namespace LibraryUtil
{
    public class MathLib
    {
        public MathLib() { }
        public void calculateSum(int x,int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }

        public void calculateSqrt(double x)
        {
            double z = Math.Sqrt(x);
            Console.WriteLine(z);
        }
    }
}
