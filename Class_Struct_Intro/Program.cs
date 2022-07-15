using System;

namespace Class_Struct_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                        Test t1 = new Test();
                        t1.SetCurrBalance(2);
                        t1.GetBalance();
                        t1.SetCurrBalance(8);
                        t1.GetBalance(); 
                        t1.SetCurrBalance(100);
                        t1.GetBalance();
            */

            /*
            Test t1 = new Test();
            int[] arr1 = new int[] { 1, 9, 5, 3, 7 };
            int[] arr2 = new int[] { 1, 9, 5, 3, 8 };
            
            if(t1.EqualOrNot(arr1, arr2) == true)
            {
                Console.WriteLine("Strings is equal");

            }
            else
            {
                Console.WriteLine("String isn't equal");
            }


            Console.WriteLine("---------------------------------------");
            if (t1.MaxNumber(arr1))
            {
                Console.WriteLine($"All elements less or equal then {Test.MaxNum}");
            }
            else
            {
                Console.WriteLine($"There is element which is greater then {Test.MaxNum}");
            }
            */



            //Static Constructor

            /*
            Test1 t1 = new Test1(50,80);                        //2 arg
            Console.WriteLine(t1.GetCurrentValue());
            Console.WriteLine(t1.GetMaxValue());
            Console.WriteLine("-----------------------------");

            Test1 t2 = new Test1(4);
            Console.WriteLine(t2.GetCurrentValue());
            Console.WriteLine(t2.GetMaxValue());
            Console.WriteLine("-----------------------------");
            */
            /*
            Test1 t3 = new Test1(5,80);
            
            Console.WriteLine(t3.GetCurrentValue());
            Console.WriteLine(t3.GetMaxValue());
            Console.WriteLine("-----------------------------");
            */

            //Static Classes


            Test2.PrintTime();
            Test2.PrintDate();
            Test2.Foo();

        }
    }
}
