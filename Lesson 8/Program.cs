using System;
using static Lesson_8.Class1;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Console.Write("Num: ");
                bool num_ = int.TryParse(Console.ReadLine(), out num);
                if (num_ == false)
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
                switch (num)
                {
                    case 1:
                        Console.WriteLine(Day.Monday);
                        break;
                    case 2:
                        Console.WriteLine(Day.Tuesday);
                        break;
                    case 3:
                        Console.WriteLine(Day.Wednesday);
                        break;
                    case 4:
                        Console.WriteLine(Day.Thursday);
                        break;
                    case 5:
                        Console.WriteLine(Day.Friday);
                        break;
                    case 6:
                        Console.WriteLine(Day.Saturday);
                        break;
                    case 7:
                        Console.WriteLine(Day.Sunday);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

        }   
    }
}
