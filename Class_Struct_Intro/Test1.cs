using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Struct_Intro
{
    class Test1                             //static constructors
    {
        public double MaxValue;
        public static double currentValue { get; set; }
        // Static constructor
        static Test1()
        {
            Console.WriteLine("This is static constructor");
            currentValue = 0;
        }
        public Test1(double value)
        {
            currentValue = value;
            Console.WriteLine("This is public constructor");
        }
        public Test1(double value, double maxValue)
        {
            Console.WriteLine("This is constructor with 2 argument");
            currentValue = value;
            MaxValue = maxValue;
        }


        public double GetMaxValue() => MaxValue;
        public double GetCurrentValue() => currentValue;


    }
}
