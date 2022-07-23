using System;
using System.Collections.Generic;
using System.Text;

namespace exersise__
{
    static class Class1
    {
        public static bool Check(string s1, string s2)
        {
            int count = 0;
            int tempCount = 0;
            int temp_i = 0;
            int temp_j = 0;
            for(int i = 0; i<s1.Length; i++)
            {
                for(int j = 0; j<s2.Length; j++)
                {
                    if(s1[i] == s2[j] && s1[i] != ' ')
                    {
                        tempCount++;
                        count++;
                        temp_i = i;
                        temp_j = j;
                        break;
                    }
                }
                if (tempCount == 1 ) {
                    s1 = s1.Replace(Convert.ToString(s1[temp_i]), " ");
                    s2 = s2.Replace(Convert.ToString(s2[temp_j]),  " ");
                    tempCount = 0;
                }
            }
            if(count == 2)
            {
                return true;
            }
            return false;
        }
        public static bool Test(string[] arr)
        {
            int count = 0;
            for(int i = 1; i<arr.Length; i++)
            {
                if(Check(arr[i-1], arr[i]))
                {
                    count++;
                }
            }
            return count == arr.Length-1; 
        }
    }
}
