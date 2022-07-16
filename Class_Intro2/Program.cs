using System;

namespace Class_Intro2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value1;
            Console.WriteLine("---What do you want---");
            Console.WriteLine("If you want to input value of cars and return their respective car names press 1");
            Console.WriteLine("If you want to input names of cars and return their values press 2");
            bool b = int.TryParse(Console.ReadLine(), out int k);
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
                        Console.WriteLine("Your input is incorrect!!!");
                        break;
                }
            }
            Intro.IsEqual();
        }
    }
}
