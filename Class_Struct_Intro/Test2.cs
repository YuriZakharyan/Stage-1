using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Struct_Intro
{
    static class Test2             //Static Classes
    {
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now);
        public static void PrintDate()
            => Console.WriteLine(DateTime.Today.Day);

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }


    }
}
