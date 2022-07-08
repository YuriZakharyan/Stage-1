using System;
using System.Text;
namespace String_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //151. Find which numbers satisfy the following condition: n%[num] == 0
            StringBuilder s = new StringBuilder("  1, 65,48,  2, 5, 72  ");          //         "  1, 65,48,  2, 5, 72  "
            Console.WriteLine($"Numbers: {s}");
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            s = s.Replace(" ", "").Append(',').Insert(0, ',');                      //      ",1,65,48,2,5,72,"
            int temp1, temp2;
            int tempNum;
            int sum = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    count++;
                }
            }
            for (int i = 0; i < count - 1; i++)
            {
                temp1 = s.ToString().IndexOf(',');
                temp2 = s.ToString().IndexOf(',', temp1 + 1);
                string numStr = s.ToString(temp1 + 1, temp2 - temp1 - 1);
                tempNum = int.Parse(numStr, System.Globalization.NumberStyles.Number);
                if (n % tempNum == 0)
                {
                    sum += tempNum;
                }
                s = s.Remove(temp1, temp2 - temp1);
            }
            Console.WriteLine("Sum = " + sum);
        
            
            */

            /*
            //1*. find most occurring character in string and his value
            Console.Write("Input String: ");
            string s = Console.ReadLine();
            int[] arr = new int[256];
            int max = -1;
            char ch = ' ';
            for(int i = 0; i<s.Length; i++)
            {
                arr[s[i]]++;
            }
            for(int i = 0; i<s.Length; i++)
            {
                if(max < arr[s[i]])
                {
                    max = arr[s[i]];
                    ch = s[i];
                }
            }
            if (ch == ' ')
            {
                Console.WriteLine($"The highest occurring character in <{s}> is: [space] , which occurs {max} times");
            }
            else
            {
                Console.WriteLine($"The highest occurring character in <{s}> is: {ch} , which occurs {max} times");
            }
            */












            /*
             //2*.find most occurring character count in string
            
            string s = "Hello e aaeavvre";
            string s1 = s.Replace(" ", "");
            int count = 0;
            int temp = 0;
            char value;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                    }
                }
                if (count > temp)
                {
                    temp = count;
                }
                count = 0;
            }
            Console.WriteLine("=> " + temp);
            */




            /*
            //2. Write a program in C# Sharp to find the length
            //of a string without using library function. 
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (int i in s)
            {
                count++;
            }
            Console.WriteLine($"Length of the string is : {count}");
            */




            /*
            //4. Write a program in C# Sharp to print individual
            //characters of the string in reverse order.
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            for(int i = s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }
            */



            /*
            //6.Write a program in C# Sharp to compare
            //two string without using string library functions. 
            Console.Write("Input first string: ");
            string s1 = Console.ReadLine();
            Console.Write("Input second string: ");
            string s2 = Console.ReadLine();
            int length1 = 0;
            int length2 = 0;
            int count = 0;
            foreach (int i in s1)
            {
                length1++;
            }
            foreach(int j in s2)
            {
                length2++;
            }
            if(length1 != length2)
            {
                Console.WriteLine("Strings are not equal");
            }
            else
            {
                for(int i = 0; i<length1; i++)
                {
                    if(s1[i] == s2[i])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("The length of both strings are equal, but value of strings not equal");
                        break;
                    }
                }
                if(count == length1)
                {
                    Console.WriteLine("The length of both strings are equal and also, both strings are equal");
                }
            }
            */

            /*
            //7. Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.
            Console.Write("Input string: ");
            int numOfChar = 0;
            int numOfDig = 0;
            int numOfAlph = 0;
            string s = Console.ReadLine();
            for(int i = 0; i<s.Length; i++)
            {
                if(s[i] < 58 && s[i] > 47) 
                {
                    numOfDig++;
                }
                else if(s[i] > 64 && s[i] < 91 || s[i] >96 && s[i] < 123)
                {
                    numOfAlph++;
                }
                else
                {
                    numOfChar++;
                }
            }
            Console.WriteLine(numOfChar);
            Console.WriteLine(numOfDig);
            Console.WriteLine(numOfAlph);
             */

            /*
            //8. Write a program in C# Sharp to copy one string to another string.
            string s1;
            StringBuilder s2 = new StringBuilder();
            Console.Write("Input first string: ");
            s1 = Console.ReadLine();
            for(int i = 0; i<s1.Length; i++)
            {
                s2 = s2.Append(s1[i]);
            }
            Console.WriteLine("--->>" + s2);
            */

            /*
            //10. Write a program in C# Sharp to find maximum occurring character in a string.
            //STRINGI XNDIRY 
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            string s1 = s.Replace(" ", "");
            int count = 0;
            int temp = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                    }
                }
                if (count > temp)
                {
                    temp = count;
                }
                count = 0;
            }
            Console.WriteLine("=> " + temp);
        
            */
            /*
            //11. Write a program in C# Sharp to sort a string array in ascending order.
            StringBuilder s = new StringBuilder("abayixb sqdc");
            s.Replace(" ", "").ToString().ToLower();
            for(int i = 0; i<s.Length; i++)
            {
                if(!(s[i] >64 && s[i]< 91 || s[i] > 96 && s[i] < 123 || s[i] == 32))
                {
                    Console.WriteLine("Wrong Format of String!!!");
                    break;
                }
            }
            for(int i = 0; i<s.Length; i++)
            {
                for(int j = i+1; j<s.Length; j++)
                {
                    if (s[i] > s[j])
                    {
                        char temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine(s);
            */



            /*
            //13. Write a program in C# Sharp to extract a substring from a
            //given string without using the library function.
            Console.Write("Input the String: ");
            string s = Console.ReadLine();                                  //Hello World
            
            Console.Write("Input the position to start extraction :");
            int start = Convert.ToInt32(Console.ReadLine());                //2
                
            Console.Write("Input the length of substring :");
            int length = Convert.ToInt32(Console.ReadLine());               //3
            
            for (int i = start; i<start+length; i++)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
            */

            /*
            //14. Write a C# Sharp program to check whether a given substring is present in the given string.
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            Console.Write("Input the substring to search :");
            string s1 = Console.ReadLine();
            if (s.Contains(s1))
            {
                Console.WriteLine("The substring exists in the string");
            }
            else
            {
                Console.WriteLine("The substring not exists in the string");
            }
            */
            /*
            //15. Write a program in C# Sharp to read a sentence and replace
            //lowercase characters by uppercase and vice-versa.
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]>64 && s[i]< 91)
                {
                    Console.Write(s[i].ToString().ToLower());
                }
                else if(s[i]> 96 && s[i] < 123)
                {
                    Console.Write(s[i].ToString().ToUpper());
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
            */

            /*
            //19. Write a program in C# Sharp to find the number of times a substring appears in a given string.
            Console.Write("Input the original string : ");
            string s1 = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            string s2 = Console.ReadLine();
            string[] k =s1.Split(" ");
            int count = 0;
            for(int i = 0; i<k.Length; i++)
            {
                if(k[i] == s2)
                {
                    count++;
                }
            }
            Console.WriteLine($"The string '{s2}' occurs {count} times");
            */



            /*
            //21. Write a C# Sharp program to compare (less than, greater than, equal to ) two substrings. 
            //      str1 = 'computer', str2 = 'system'                                               
            //      Substring 'mp' in 'computer' is less than substring 'sy' in 'system'.
            
            Console.Write("Input String 1: ");
            string s1 = Console.ReadLine();
            Console.Write("Input String 2: ");
            string s2 = Console.ReadLine();
            Console.Write("Input Substring 1: ");
            string st1 = Console.ReadLine();
            Console.Write("Input SubString 2: ");
            string st2 = Console.ReadLine();
            int length;
            int count = 0;
            if(!s1.Contains(st1) || !s2.Contains(st2))
            {
                Console.WriteLine("Wrong substring!!");
            }
            else
            {
                if (st1.Length >= st2.Length)
                {
                    length = st2.Length;
                }
                else
                {
                    length = st1.Length;
                }
                
                for(int i = 0; i<length; i++)
                {
                    if(st1[i]< st2[i])
                    {
                        Console.WriteLine($"Substring '{st1}' in '{s1}' is less than substring '{st2}' in '{s2}'.");
                        break;
                    }
                    else if (st1[i] > st2[i])
                    {
                        Console.WriteLine($"Substring '{st1}' in '{s1}' is greater than substring '{st2}' in '{s2}'.");
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if(count == length)
                {
                    Console.WriteLine("Substrings is equal!!!");
                }
            }
            */



            /*
            //22. Write a C# Sharp program to compare two substrings that only differ in case.
            //The first comparison ignores case and the second comparison considers case.
            //21 + 
            
            Console.Write("Input String 1: ");
            string s1 = Console.ReadLine();
            Console.Write("Input String 2: ");
            string s2 = Console.ReadLine();
            Console.Write("Input Substring 1: ");
            string st1 = Console.ReadLine();
            Console.Write("Input SubString 2: ");
            string st2 = Console.ReadLine();
            if (!s1.Contains(st1) || !s2.Contains(st2))
            {
                Console.WriteLine("Wrong substring!!");
            }
            else
            {
                s1 = s1.ToLower();
                s2 = s2.ToLower();
                if(st1.Length != st2.Length)
                {
                    Console.WriteLine($"Substrings isn't equal to each other");
                }
                else
                {
                    st1 = st1.ToLower();
                    st2 = st2.ToLower();
                    if(st1 == st2)
                    {
                        Console.WriteLine($"Substring '{st1}' in '{s1}' is equal to substring '{st2}' in '{s2}'");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Substring '{st1}' in '{s1}' isn't equal to substring '{st2}' in '{s2}'");
                    }
                }
            }
            
            */

            /*
            //156. Ayn erknish tveri artadryaly, voronq bazmapatik en 3 ev 5 tverin

            StringBuilder s = new StringBuilder(" 25,    30, 4,7,60,  80, 1000 ");             //          "  3,6,2,8,11, 30 ,2 ,15,7, 60,2, 3 "
            Console.WriteLine($"Numbers: {s}");
            s = s.Replace(" ", "").Append(',').Insert(0, ',');                                      //          "3,6,2,8,11,30,2,15,7,60,2,3"
            int temp1, temp2;
            int tempNum;
            int sum = 0;
            int count = 0;
            int mul = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    count++;
                }
            }
            for (int i = 0; i < count - 1; i++)
            {
                temp1 = s.ToString().IndexOf(',');
                temp2 = s.ToString().IndexOf(',', temp1 + 1);
                string numStr = s.ToString(temp1 + 1, temp2 - temp1 - 1);
                tempNum = int.Parse(numStr, System.Globalization.NumberStyles.Number);
                if (tempNum / 100 == 0 && tempNum / 10 != 0 && tempNum % 3 == 0 && tempNum % 5 == 0)
                {
                    mul *= tempNum;
                }
                s = s.Remove(temp1, temp2 - temp1);
            }
            Console.WriteLine($"Mul: {mul}");
            */








            /*
            string s = "";
            s = s.ToString().Insert(0, "a");
            s = s.ToString().Insert(1, "b");
            Console.WriteLine(s);
            */
        }
    }
}