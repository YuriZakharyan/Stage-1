using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInStruct
{
    public class Student1
    {
        public int countOfGrades;
        public double Mid(int []grades)
        {
            int sum = 0;
            int count = 0;
            for(int i = 0; i<grades.Length; i++)
            {
                sum += grades[i];
                count++;
            }
            return sum / count;
        }
        public struct Student_1
        {
            public int a;
            public static class Phone
            {
                public static double Price(int screenWidth, int screenLength, int memorySize)
                {
                    return screenLength * screenWidth * memorySize * 500;
                }
            }
            public int countOfB(int[] grades)
            {
                int count = 0;
                for(int i = 0; i<grades.Length; i++)
                {
                    if(Convert.ToChar(grades[i]) == '-')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
