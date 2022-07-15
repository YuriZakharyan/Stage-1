using System;

namespace Class_Intro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            decimal value1, value2;
            Console.WriteLine("---What do you want---");
            Console.WriteLine("1. Input value of car and return their respective car names");
            Console.WriteLine("2. Input Names of Cars and return Values");
            bool b = int.TryParse(Console.ReadLine(), out k);
            if (b == false)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
            else
            {
                switch (k)
                {
                    case 1:
                        Console.Write("Input value: ");
                        bool t = decimal.TryParse(Console.ReadLine(), out value1);
                        if (t == false)
                        {
                            Console.WriteLine("Invalid Input");
                            return;
                        }
                        else
                        {
                            Intro.PrintNames(value1);
                        }
                        break;
                    case 2:
                        Console.Write("Input Name of Car you want: ");
                        string name = Console.ReadLine();
                        Intro.PrintValues(name);
                        break;
                    default:
                        Console.WriteLine("Default!!!!");
                        break;

                }
            }
        }
    }
}
