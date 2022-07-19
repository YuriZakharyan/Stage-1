using System;
using System.Collections.Generic;
using System.Text;
namespace Classes_lesson2
{
    struct Test1
    {
        class Workers
        {
            private int days;
            public decimal CountSalary()
            {
                return days * 5000;
            }


        }


        int a, b, c;
        public bool isTriangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) 
            {
                return true;
            }
            return false;
        }
    }
    class Test
    {

        static struct School
        {

        }

        public static int Sum(int a, int b) {
            return a + b;
        }
        public int Summ(int a, int b)
        {
            return a + b;
        }
    }
}