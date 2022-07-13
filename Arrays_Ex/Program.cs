﻿using System;
using System.Collections.Generic;
using static System.Math;
namespace Arrays_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            //211-arithmetic overage of positive elements


            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int count = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"Input arr[{i}] : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            float mid = sum / count;
            Console.WriteLine($"Mid: {mid}");
            */

            /*
             
            //212-
            
            
            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int count = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i] * arr[i];
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("There is no positive numbers!!");
                return;
            }
            double mid = Sqrt(sum/count);
            Console.WriteLine($"Output: {mid}");
            */


            /*
            //218
            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(i%2 != 0)
                {
                    sum += Abs(arr[i]);
                }
            }
            Console.WriteLine($"Output: {sum}");

            */

            /*

            //222    [c,d)
            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());    // 2,4,5,6,9,1,7,5,2,
            int[] arr = new int[n];
            int left, right;
            int mul = 1;
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---Input Range---");
            Console.Write("Left: ");
            left = Convert.ToInt32(Console.ReadLine());     //2
            Console.Write("Right: ");
            right = Convert.ToInt32(Console.ReadLine());    //6
            for(int i = left; i<right; i++)                 //  [left, right)
            {
                mul *= arr[i];
            }
            Console.WriteLine($"Output: {mul}");

            */


            /*
            //392-Reverse array

            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }

            */


            /*
            //393

            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<arr.Length; i++)
            {
                count = 0;
                if(arr[i] == 0)
                {
                    for(int j = i; j<arr.Length; j++)
                    {
                        if(arr[j] == 0)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }

                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
            }
            Console.WriteLine("Max=" + maxCount);
            */



            /*
             
            //394-nor zangvaci mej tpel skzbic kentery, heto zuygery

            Console.WriteLine("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int k = 0;
            for(int i = 0; i<arr1.Length; i++)
            {
                Console.Write($"arr1[{i}] = ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<arr1.Length; i++)
            {
                if(arr1[i] % 2 != 0)
                {
                    arr2[k] = arr1[i];
                    k++;
                }
            }
            for(int i = 0; i<arr1.Length; i++)
            {
                if(arr1[i] % 2 == 0)
                {
                    arr2[k] = arr1[i];
                    k++;
                }
            }
            for(int i = 0; i<arr2.Length; i++)
            {
                Console.Write($"{arr2[i]}, ");
            }

            */

            /*

            //395 - delete first element and shift array to left
            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Clear(arr, 0, 1);

            for(int i = 0; i<arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
                Console.Write($"{arr[i]}, ");
            }

            */



            /*

            //396-
            Console.Write("Input Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int index = 0;
            int count = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    index = i;
                    count++;
                    break;
                }
            }
            int[] arr2 = new int[arr.Length + 1];
            if(count == 0)
            {
                Console.WriteLine("There isn'n any alement, which is equal to zero");
                return;
            }
            else
            {
                for(int i = 0; i<index; i++)
                {
                    arr2[i] = arr[i];
                }
                arr2[index] = 0;
                for(int i = index+1; i<arr2.Length; i++)
                {
                    arr2[i] = arr[i - 1];
                }
                for(int i = 0; i<arr2.Length; i++)
                {
                    Console.WriteLine($"arR2[{i}] = {arr2[i]}");
                }
            }
            */

            /*

            //398 - Common elements in all rows of a matrix

            Console.Write("Input M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m, n];
 
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
            List<int> numbers = new List<int>();
            int countRow = 0;
            int count = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                countRow = 0;
                for (int i = 1; i < arr.GetLength(0); i++)
                {

                    count = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[0, k] == arr[i, j])
                        {
                            countRow++;
                            break;
                        }
                        else
                        {
                            count++;
                            continue;
                        }
                    }
                    if(count == arr.GetLength(1))
                    {
                        break;
                    }
                }
                if(count == n)
                {
                    continue;
                }
                if(countRow == arr.GetLength(0) - 1)
                {
                    numbers.Add(arr[0, k]);
                    continue;
                }
            }

            Console.Write("OutPut: ");
            if (numbers.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            foreach (int item in numbers)
            {
                    Console.Write($"{item}\t");
            }
            */


            /*
            //399
            Console.Write("Input N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (arr[0] != arr[1])
            {
                Console.Write(arr[0] + " ");
            }
           
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i-1] != arr[i] && arr[i] != arr[i + 1])
                {
                    Console.Write(arr[i] + " ");
                }
            }
            
            if (arr[arr.Length - 2] != arr[arr.Length - 1])
            {
                Console.Write(arr[arr.Length - 1] + " ");
            }
            */


            /*
            //400

            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int count = 0;
            for(int i = 1; i<arr.Length; i++)
            {
                if (arr[i-1] > arr[i])
                {
                    count++;
                    Console.Write($"{arr[i]},");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Count = {count}");
            */


            /*
            //402-print max of Range [B,C] 

            Console.Write("Input Size of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("B=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C=");
            int max;
            int c = int.Parse(Console.ReadLine());
            max = arr[b];
            for(int i = b+1; i<=c; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max = "+ max);
            */



            /*
            //405

            Console.Write("Input Size of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            Console.Write("Sorted array: ");
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }
            Array.Reverse(arr);
            Console.WriteLine();
            Console.Write("Reverse array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }
            
            int count = 0;
            Console.WriteLine();
            Console.Write("First 3 maximum numbers is: ");
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] > arr[i])
                {
                    Console.Write($"{arr[i-1]}, ");
                    count++;
                }
                if (count == 3) break;
            }
            */

            /*
            //406-print number which sum of digits is maximum

            Console.Write("Input Size of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int max = 0;
            int temp;
            int sumOfDigits;
            int index = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                sumOfDigits = 0;
                while(arr[i] != 0)                   //  256      25
                {                                       //
                    temp = arr[i] % 10;                 //temp =2   
                    sumOfDigits += temp;                //sum =13   
                    arr[i] = arr[i] / 10;               //arr = 0
                }
                if (max < sumOfDigits)
                {
                    max = sumOfDigits;
                    index = i;

                }
            }
            Console.WriteLine("Index = " + index);
            */

            /*
            //415
            Console.Write("Input Size of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int temp = 0;
            int k = 0;
            for(int i = 1; i<arr.Length; i++)
            {
                if(arr[0] > arr[i])           //swap(temp, a[i])
                {
                    temp = i;
                    continue;
                }
                else {
                    break; 
                }
            }
            for(int i = 1; i<=temp; i++)
            {
                k = arr[i-1];
                arr[i-1] = arr[i];
                arr[i] = k;
            }

            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            */



            /*
            //420-print that elements which appears in array[List] 4 time


            Console.Write("Input Size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> arr = new List<int>();            
            
            for(int i = 0; i<n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr.Add(int.Parse(Console.ReadLine()));
            }

            foreach(int item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            int tt = 0;
            for(int i = 0; i<arr.Count; i++)
            {
                int temp = arr[i];
                int count = 0;
                tt = 0;
                for (int j = 0; j<arr.Count; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 4)
                {
                    for(int k = 0; k<arr.Count; k++)
                    {
                        if(tt == 1)
                        {
                            k--;
                        }
                        tt = 0;
                        if(arr[k] == temp)
                        {
                            tt++;
                            arr.RemoveAt(k);
                        }
                    }
                }
            }
            foreach(int item in arr)
            {
                Console.Write(item + "\t");
            }
            

            */



            //MultiDimensional Arrays
            /*
             
            //421

            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }

            int count = 0;
            Console.WriteLine("Input k: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i > j && arr[i, j] % k == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Count: " + count);
            */


            /*
            //426-Ojandak ankyunagcic verev gtnvox zuyg tveri gumary

            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j < arr.GetLength(1)-1 && arr[i,j] % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum= {sum}");
            */

            /*
            //429
            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i>=j && arr[i,j]%2 == 0)
                    {
                        sum += arr[i, j];
                        count++;
                    }

                }
            }if(count == 0)
            {
                Console.WriteLine("There isn't even number");
                return;
            }
            double mid = (double)sum / count;
            Console.WriteLine("Output: " + mid);
            */

            /*
            //451


            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, m];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i+j == arr.GetLength(1)-1  || i == j)
                    {
                        sum += arr[i, j];
                        count++;
                    }
                }
            }
            Console.WriteLine($"Output: {(double)sum/count}");

            */

            /*
            //461-print row numbers which elements sorted in ascending order


            Console.Write("Input m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                count = 0;
                for (int j = 1; j < arr.GetLength(1); j++)
                { 
                    if(arr[i,j-1] <= arr[i, j])
                    {
                        count++;
                    }                
                }
                if(count == arr.GetLength(1)-1)
                {
                    Console.WriteLine("Index " + i);
                }
            }
            */

            /*
            //477 - find min(column(k))

            Console.Write("Input Row: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input Column: ");
            int n = int.Parse(Console.ReadLine());
            int min;
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.Write("Input number of column: ");
            int k = Convert.ToInt32(Console.ReadLine());
            min = arr[0, k];
            for(int i =1; i<arr.GetLength(0); i++)
            {
                int j = k;
                if (min > arr[i, j])
                {
                    min = arr[i, j];
                }
            }
            Console.WriteLine("Output: " + min);
            */


            //491

            Console.Write("Input Row: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input Column: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();                
            }





        }
    }
}
