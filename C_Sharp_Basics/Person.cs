using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Basics
{
    class Person
    {
        private string s1;
        public string firstName { 
            get 
            {
                if(s1 == "Ani")
                {
                    return s1;
                }
                else
                {
                    return s1 + "Hello";
                }
            }
            set
            {
                s1 = value;
            } 
        }
        public string lastName { get; set; }
        public int Age { get; set; }
        public bool isMale { get; set; }
        public double height { get; set; }
    }
    class Student: Person
    {
        public string uniName { get; set; }
        public int classNumber { get; set; }
        public int gradYear { get; set; }
    }
    class Driver: Person
    {
        public string carName { get; set; }
    }
}