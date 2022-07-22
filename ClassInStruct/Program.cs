using System;


namespace ClassInStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 1, 5, 9, 45, 5, 4, 45 };       //45 == '-'
            Student1.Student_1 s = new Student1.Student_1();
            Console.WriteLine(s.countOfB(grades));

            Student1.Student_1 k = new Student1.Student_1();

            Console.WriteLine("__________________________");
            double t = Student1.Student_1.Phone.Price(2, 3, 5);
            Console.WriteLine(t);
        
        }
    }
}
