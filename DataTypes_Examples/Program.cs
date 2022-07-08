using System;

namespace DataTypes_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 2;
            string s = "Calculate:  (a + b)/c - b%2 + a^2, where: ";
            Console.WriteLine(s);

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.ReadLine();

            int sum1 = a + b;                               //sum1 = 12
            Console.Write("a + b = " + sum1);
            Console.ReadLine();

            int result1 = sum1 / c;                         //result1 == 12/2 == 6
            Console.Write("(a + b)/c = " + result1);
            Console.ReadLine();

            int result2 = b % 2;                            //result2 == 7%2 == 1
            Console.Write("b % 2 = " + result2);
            Console.ReadLine();

            int result3 = a * a;
            Console.WriteLine("a*a = " + result3);
            Console.ReadLine();

            int result = result1 - result2 + result3;                 //result == 5
            Console.Write("(a + b)/c - b%2 + a*a = " + result);



            Console.ReadLine();
            Console.Clear();


            //  sbyte a1 = 128;         //error becouse sbyte -> [-128,127] 
            sbyte a2 = 100;
            byte a3 = 255;
            //Console.WriteLine("a1 : " + a1);
            Console.WriteLine("a2 : " + a2);
            Console.WriteLine("a3 : " + a3);



            //boolean
            bool k = false;
            Console.WriteLine("k = " + k);
            Console.ReadKey();                  //t  -> type   (line 63)
            //Console.ReadLine();
            Console.WriteLine("ype of k: " + k.GetType() + "\n");


            Console.WriteLine("Click any key to clear console");
            Console.ReadLine();
            Console.Clear();



            //  print if(a>b), using character's ASCII Code
            string S = "print if(a>b), using character's ASCII Code";

            Console.WriteLine(S);
            Console.ReadLine();

            Console.WriteLine($"{'\u0069'}{'\u0066'}{'\u0028'}{'\u0061'}{'\u003E'}{'\u0062'}{'\u0029'}");



            DateTime date = new DateTime(2022, 06, 30, 2, 5, 50);     //yy:mm::dd         2:05:50
            Console.WriteLine(date);


            //DateTime date1 = new DateTime(2022, 06, 30, 26, 5, 50);     //Error, becouse hour==26   [0,24)
            //Console.WriteLine(date1);

            DateTime y = DateTime.Now;
            Console.WriteLine("Now is " + y);


            Console.ReadLine();
            Console.Clear();

            //_______________________________________________________________________


            Console.WriteLine("\t\t EXAM  \n");
            DateTime n = DateTime.Now;
            Console.WriteLine("Now is " + n);
            DateTime w = DateTime.Now.AddMinutes(20);
            w = DateTime.Now.AddMinutes(80);        //1h20m = 80min
            Console.WriteLine("After 1 hour and 20 minutes test will be closed:        " + w + "       >>\n");

            Console.WriteLine("If you want to start test click any key! ");


            //———————————————————————————————————————————————————————————————————————
            //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));


            bool p1 = new bool();
            Console.WriteLine("Default value <p1> :  " + p1);        //by default -> false

            int p2 = new int();
            Console.WriteLine("Default value <p2> :  " + p2);        //by default-> 0

            byte p3 = new byte();
            Console.WriteLine("Default value <p3> :  " + p3);        //by default -> 0


            Console.ReadLine();

        }
    }
}