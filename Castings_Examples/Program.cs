using System;

namespace Castings_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***");

            Console.WriteLine("number: " + 512345.1234563789123);     //16 digit
            float f1 = 512345678.1234563789123f;                        //24 bit == 7bit 10
            Console.WriteLine("float: " + f1);
            decimal d1 = (decimal)f1;
            Console.WriteLine("decimal: " + d1);


            Console.WriteLine("***");

            double f2 = 512345678245.1234563789123456789123456789d;
            Console.WriteLine();
            decimal d2 = (decimal)f2;
            Console.WriteLine(d2);

            decimal w1 = 10000000000000000000;
            double x1 = (double)w1;
            Console.WriteLine(x1);

            //decimal to int
            decimal a = 3456678;     // if (a = 34566788888888) then will be
                                     // System.OverflowException: 'Value was either
                                     // too large or too small for an Int32.'
            int kl = (int)a;
            Console.WriteLine(kl);

            Console.WriteLine("__________");

            //implicit casting (char to int)
            char c1;                                       //      '~'
            Console.Write("Input first character: ");
            c1 = Convert.ToChar(Console.ReadLine());
            char c2;                                       //      ')'
            Console.Write("Input second character: ");
            c2 = Convert.ToChar(Console.ReadLine());
            int sum1 = c1 + c2;                             //126 + 41 = 167
            Console.WriteLine("----->  " + sum1);
            Console.WriteLine("ASCii -> " + (char)sum1);      //167  ==>  §


            //char to double-implicit
            char c3 = 'd';
            double dd1 = c3;
            Console.WriteLine(dd1);

            //explicit casting
            double q;
            q = Convert.ToDouble(Console.ReadLine());
            int q1 = (int)q;                                //explicit cating from double to int
            Console.WriteLine($"double({q}) = int({q1})  ");

            Console.WriteLine("____________________");
            int aa = 5;
            string s = Convert.ToString(aa);                 //int to string
            Console.WriteLine(s);

            //Parsing     --> String to double
            double aa1;
            aa1 = double.Parse(Console.ReadLine());
            Console.WriteLine(aa1);
            Console.WriteLine(aa1.GetType());       //after parsing type of aa1 is double


            decimal x;
            float y;
            double z;
            Console.Write($"x = ");
            x = decimal.Parse(Console.ReadLine());
            Console.Write($"y = ");
            y = float.Parse(Console.ReadLine());
            Console.Write($"z = ");
            z = double.Parse(Console.ReadLine());

            double suum = (double)(x + (decimal)y + (decimal)z) / 3;
            Console.WriteLine("The arithmetic average։ " + suum);


            //Operations


            //&
            int d;
            Console.Write("input 1: ");             //5 == 101
            d = int.Parse(Console.ReadLine());
            int dd;
            Console.Write("Input 2: ");         //6 ==110
            dd = int.Parse(Console.ReadLine());


            Console.WriteLine($"{d} & {dd} = {d & dd}");          //      d       -> 101
                                                                  //      dd      -> 110
                                                                  //      d & dd  -> 100 == 4

            Console.WriteLine($"{d} | {dd} = {d | dd}");          //      d       -> 101
                                                                  //      dd      -> 110
                                                                  //      d | dd  -> 111 == 7

            //Unary operators
            int u1;
            Console.WriteLine("Num: ");
            u1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"++{u1} : {++u1}");
            Console.WriteLine($"{u1}++ : {u1++}");
            Console.WriteLine();

            int a1 = 5;
            int a2 = a1++;
            Console.WriteLine(a1);      //6
            Console.WriteLine(a2);      //5

            int t = 4;
            t += a1;                   //x1 = x1 + a1 = 4+5 = 9

            Console.WriteLine(x1);

            //Binary
            int t1 = a1 * t;
            Console.WriteLine(t1);      //t1 = 5*4 = 20

            //Ternary operator

            double v1;
            Console.Write("First Number: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            double v2;
            Console.Write("Second Number: ");
            v2 = Convert.ToDouble(Console.ReadLine());

            string s1 = $"{v1} is grater then {v2}";
            string s2 = $"{v1} is smaller then {v2}";
            string v = v1 > v2 ? s1 : s2;
            Console.WriteLine(v);
            Console.ReadLine();

        }
    }
}