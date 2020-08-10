using System;

namespace Exponentiation
{
    class Program
    {
        public static double FindExponentiation(double x, int n)
        {
            if (n == 0)
                return 1;
            return x * FindExponentiation(x, n - 1);
        }

        static void Main(string[] args)
        {
            int n;
            double d;
            Console.Write(" Enter exponential value ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter base value: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("exponential value is : " + FindExponentiation(d, n));
        }
    }
}
