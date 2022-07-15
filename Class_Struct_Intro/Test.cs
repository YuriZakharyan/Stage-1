using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Struct_Intro
{
    class Test
    {
        private double currBalance;
        public static double MaxNum = 10;
        public void SetCurrBalance(double currBalance) =>
            this.currBalance = currBalance;

        
        
        public void GetBalance() => Console.WriteLine(currBalance);
        public bool MaxNumber(int[] arr)
        {
            foreach(int item in arr)
            {
                if(item > MaxNum)
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool EqualOrNot(int[] arr1, int[] arr2)
        {
            if(arr1.Length != arr2.Length)
            {
                return false;
            }
            else
            {
                for(int i = 0; i<arr1.Length; i++)
                {
                    if(arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
