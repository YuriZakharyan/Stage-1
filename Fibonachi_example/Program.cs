using System;

namespace Fibonachi_example
{
    // F(n) = 0 1 1 2 3 5 8 13 21 34 ...
    //Calculete: F(n)/F(n-1)
    class Program
    {
        public static double Fib(int n)
        {
                if (n <= 1) 
                    return n;
                else
                {
                    return Fib(n - 1) + Fib(n - 2);
                }
        }
        public static double GoldenRatio(int n)
        {
            return Fib(n) / Fib(n - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(GoldenRatio(20));
        }
    }
}
