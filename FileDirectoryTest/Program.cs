using System;
using System.IO;
using System.Text;

namespace FileDirectoryTest
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            //Write text

            string filePath = @"D:\Basic_It\FileTest.txt";
            using FileStream obj = File.OpenWrite(filePath);

            var data = "Programming languages\n\nC-Sharp\nCpp\nPython\nJava\nJavascript\nRuby";
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            
            obj.Write(bytes, 0, bytes.Length);
            
            */




            /*
            //Read data from file

            var filePath = @"D:\Basic_It\FileTest.txt";

            using FileStream fs = File.OpenRead(filePath);

            byte[] data = new byte[1024];
            int c;

            while ((c = fs.Read(data, 0, data.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(data, 0, c));
            }
            */




            /*
            //Copy data from one file to another

            var filePath = @"D:\Basic_It\FileTest.txt";
            using var obj = new FileStream(filePath, FileMode.Open);

            var filePath2 = @"D:\Basic_It\FileTest2.txt";
            using var obj2 = new FileStream(filePath2, FileMode.OpenOrCreate);

            obj.CopyTo(obj2);

            Console.WriteLine("File copied");
            */
            


        }
    }
}
