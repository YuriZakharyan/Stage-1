using System;
namespace Arrays_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ternary operator
            int a = 5;
            int b = 7;
            int max;
            max = a > b ? a : b;
            Console.WriteLine(max);
            */

            //string[] arr = new string[3];
            //arr[0] = "aa";
            //arr[1] = "bb";
            //arr[2] = "cc";
            //string s = Console.ReadLine();
            
             /*
             //1*

             for(int i = 0; i<arr.Length; i++)
             {
                 if(s == arr[i])
                 {
                     Console.WriteLine($"Index = {i}");
                     Console.WriteLine($"Value = {arr[i]}");
                     break;
                 }
             }
             */

            /*
             //2*
             foreach(string item in arr)
             {
                 if(s == item)
                 {
                     Console.WriteLine($"Index = {Array.IndexOf(arr, item)}");
                     Console.WriteLine($"Value = {item}");
                     break;
                 }
             }
            */


            //__________________________________________________________________________
            /*
            //Sort numbers using Bubble Sort

            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }

            */

            
            //Sort numbers using one for loop       O(n^2) 
            
            int[] arr = new int[6];
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i<arr.Length-1; i++)
            {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i + 1] = temp;
                        i = -1;
                    }
            }
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        
        
        }
    }
}
