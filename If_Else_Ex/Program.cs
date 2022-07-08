using System;
using static System.Math;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //ex. 21
            //input:    a,b,c
            //output:   max(a,b,c)
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b)      //a>b
            {
                if (a > c)  // a>b && a>c
                    Console.WriteLine($"max({a},{b},{c}) = {a}");
                else        // a>b && a<c
                    Console.WriteLine($"max({a},{b},{c}) = {c}");
            }
            else if (b < c)  //a < b && b < c
                    Console.WriteLine($"max({a},{b},{c}) = {c}");
            else        //a < b && c < b
                    Console.WriteLine($"max({a},{b},{c}) = {b}");
            }
            
            */


            /*
            
             
            //ex. 22
            //input:    a,b,c
            //output:   min(a,b,c)
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b)      //a<b
            {
                if (a < c)  // a < b && a < c
                    Console.WriteLine($"max({a},{b},{c}) = {a}");
                else        // a < b && c < a
                    Console.WriteLine($"max({a},{b},{c}) = {c}");
            }
            else if (b > c)  //a > b && b > c
                    Console.WriteLine($"max({a},{b},{c}) = {c}");
            else        //a > b &&  b < c
                    Console.WriteLine($"max({a},{b},{c}) = {b}");
            }
            */




            /*
            //Ex. 23
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            string t = "True";
            string f = "False";
            if (a == 1 || b == 1 || c == 1) 
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            */




            /*
            //Ex. 24
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a == 2 && b == 2 && c==2)
                Console.WriteLine("False");
            else if(a==2 && b==2 || a==2 && c == 2 || b == 2 && c == 2)
                    Console.WriteLine("True");
            else
                Console.WriteLine("False");
              
            */




            /*
            //Ex 25
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a+b > c && a+c>b && b+c > a)
                Console.WriteLine("y=1");
            else
                Console.WriteLine("y=2");
            */




            /*
            //Ex. 26
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a%2 == 0 || b%2 == 0 || c%2 == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
            */




            /*
            //Ex 27
            //Tvabanakan Progresiayi andamner en
            
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a == (b+c)/2 || b == (a+c)/2 || c == (a + b) / 2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            */



            /*
            //Ex. 28
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a==0 || b == 0 || c == 0)
            {
                Console.WriteLine("False");
            }
            else if(b == Sqrt(a*c))
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False"); 
            }
            */



            /*
             
            //Ex. 29
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b)      //a<b
            {
                if (a < c)  // a < b && a < c             => a<b,c
                {
                    if (b < c)                          //=> a<b<c
                        Console.WriteLine($"{a}->{b}->{c}");
                }
                else        // a < b && c < a           //c<a<b
                    Console.WriteLine($"{c}->{a}->{b}");
            }
            else if (b > c)  //a > b && b > c            =>c<b<a
                Console.WriteLine($"{c}->{b}->{a}");
            else if (a < c)          //a > b &&  b < c           =>  b<a<c
                Console.WriteLine($"{b}->{a}->{c}");
            else
                Console.WriteLine($"{b}->{c}->{a}");
            
            */

            /*
             
            //Ex. 30
            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b)      //a>b
            {
                if (a > c)  // a>b && a>c               a>b,c              
                {
                    if (b > c)                          //a>b>c
                        Console.WriteLine($"{a}->{b}->{c}");
                    else                                //a>c>b
                        Console.WriteLine($"{a}->{c}->{b}");
                }
                else        // a>b && a<c               b<a<c             
                    Console.WriteLine($"{b}->{a}->{c}");
            }
            else if (b < c)  //a < b && b < c
                Console.WriteLine($"{c}->{b}->{a}");
            else if (a < c)
                Console.WriteLine($"{b}->{c}->{a}");
            else
                Console.WriteLine($"{b}->{a}->{c}");
        
        */
        }
    }
}