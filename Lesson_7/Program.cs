using System;

namespace Lesson_7
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }


        static void Main(string[] args)
        {
            
            while (true) 
            {
                int a;
                Console.Write("Input a: ");
                bool a_ = int.TryParse(Console.ReadLine(), out int result1);
                if (a_ == false)
                {
                    Console.WriteLine("invalid Input");
                    continue;
                }
                else
                {
                    a = result1;
                }
                int b;
                Console.Write("Input b: ");
                bool b_ = int.TryParse(Console.ReadLine(), out int result2);
                if (b_ == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                else
                {
                    b = result2;
                }

                Console.Write("Input sign: ");
                char sign = Convert.ToChar(Console.ReadLine());
                if(sign != '+' && sign != '-' && sign != '*' && sign != '/')
                {
                    Console.WriteLine("Invalid Input");
                }

                switch (sign)
                {
                    case '+':
                        Console.WriteLine(Sub(a, b));
                        break;
                    case '-':
                        Console.WriteLine( Sub(a, b));
                        break;
                    case '*':
                        Console.WriteLine( Mul(a, b));
                        break;
                    case '/':
                        Console.WriteLine(Div(a, b));
                        break;

                } 
            }
        }
    }
}
