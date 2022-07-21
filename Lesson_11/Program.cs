using System;
using System.Globalization;

namespace Lesson_11
{
    class Program
    {
        const int a = 7;
        public readonly int b;
        Program()
        {
            b = 9;
        }

        public void Print()
        { 
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            const int a = 5;
            Program p = new Program();
            p.Print();

        }
    }
}
