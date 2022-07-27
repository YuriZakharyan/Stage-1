using System;

namespace C_Sharp_Basics
{
    class Program
    {
        public static void Calc(double a, double b, char c)
        {
            switch (c)
            {
                case '+':
                    Console.Write($"{a} + {b} = {a+b} ");
                    break;
                case '-':
                    Console.Write($"{a} - {b} = {a-b}");
                    break;
                case '*':
                    Console.Write($"{a} * {b} = {a*b}");
                    break;
                case '/':

                    if (b == 0)
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
                    else
                    {
                        Console.Write($"{a} / {b} = {a/b} ");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public static int Fact(int n)
        {
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }

        public static int Fibonacci(int n)
        {
            //0 1 1 2 3 5 8 13 21 34 55 ...

            if (n == 0 || n == 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void dowhile(int n)
        {
            do
            {
                Console.WriteLine(n);
                
            }
            while (1 == 0);
        }
        public static void whiledo(int n)
        {
            while (1 == 0)
            {
                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("\tFibonacci");
            //Console.WriteLine(Fibonacci(6));
            //
            //Console.WriteLine("\tFact");
            //Console.WriteLine(Fact(6));
            //
            //Console.WriteLine("\tCalculator");
            //Calc(5, 5,'+');
            //Console.WriteLine();
            //
            //
            //Console.WriteLine("\tDO_WHILE");
            //dowhile(5);
            //
            //Console.WriteLine("\tWhile");
            //whiledo(5);

            /*
            Driver driver1 = new Driver();
            driver1.height = 10;
            Console.WriteLine(driver1.height);
            driver1.firstName = "Ani";
            Console.WriteLine(driver1.firstName);


            Car obj;    //new Car(); 
            obj.year = 2000;
            Console.WriteLine(obj.year);
            //Console.WriteLine(obj.Price());
            */

            //Console.WriteLine( Person.Sum(2, 3));       //static method
            //Console.WriteLine(Workers.Sum(2, 3));
        
        
        
        
        }
    }
}
