using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Class_Intro2
{
    static class Intro
    {
        public static string[] CarNames = new string[] { "BMW", "Mercedes", "Opel", "Opel" };
        public static decimal[] CarPrice = new decimal[] { 30000, 30000, 25000, 10000 };

        static Intro()
        {
        }


        public static bool IsEqual()
        {
            if(CarNames.Length != CarPrice.Length)
            {
                return false;
            }
            return true;
        }



        public static void PrintNames(decimal price)
        {
            if (IsEqual() == false)
            {
                Console.WriteLine("Arrays isn't equal");

            }
            else
            {
                int count = 0;
                for (int i = 0; i < CarPrice.Length; i++)
                {
                    if (price == CarPrice[i])
                    {
                        count++;

                        Console.WriteLine($"{i}--->" + CarNames[i].ToString());
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"There is no such car here, the price of which is equal to {CarPrice}");
                }
            }
        }

        public static void PrintValues(string name)
        {
            int count2 = 0;
            if (IsEqual() == false)
            {
                Console.WriteLine("Arrays isn't equal");

            }
            else
            { 
                for(int i = 0; i<CarNames.Length; i++)
                {
                    if(name == CarNames[i] || name.ToLower() == CarNames[i].ToLower())
                    {
                        count2++;
                        Console.WriteLine(CarPrice[i]);
                    }
                }
                if(count2 == 0)
                {
                    Console.WriteLine($"There is no Car which name is {name}");
                }

            
            
            
            
            }

            }


    }
}
