using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Basics
{
    public struct StaticStruct1
    {
        public static int u;
        public void lll(int r) 
        { 
        }
    }

    public class Pahoo
    {
        public int Foo(int n)
        {
            if (n == 1) return 1;
            return n + Foo(n - 1);
        }
        public int id;
    }
    struct Car
    {
        public string name;
        private bool isAutomatic;
        public string color;
        public int year;
        public int Price()
        {
            int sum = 0;
            if(year >= 2010)
            {
                sum += 20000;
            }
            else if(year <= 2009 && year >= 2000)
            {
                sum += 10000;
            }
            else
            {
                sum = +5000;
            }
            return sum;
        }
    }
    class Person
    {
        private string s1;
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public string firstName { 
            get 
            {
                if(s1 == "Ani")
                {
                    return "This person is Girl";
                }
                else
                {
                    return "This person is Boy";
                }
            }
            set
            {
                s1 = value;
            } 
        }
        public string lastName { get; set; }
        public int Age { get; set; }
        public bool isMale { get; set; }
        public double height { get; set; }
    }
    class Student: Person
    {
        public string uniName { get; set; }
        public int classNumber { get; set; }
        public int gradYear { get; set; }
    }
    class Driver: Person
    {
        public string carName { get; set; }
    }

    static class Workers
    {
        public static int Sum(int a, int b)
        {
            Console.Write($"{a} + {b} = ");
            return a + b;
        }
    }
    class strings
    {
        public static void secondRepeatedElemIndex(string s, char c)
        {
            int firstindex = s.IndexOf(c);
            Console.WriteLine("firstindex = " + firstindex);
            int secondIndex = s.IndexOf(c, firstindex + 1);
            if (secondIndex == -1)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine(secondIndex);
            }
        }
    }
}