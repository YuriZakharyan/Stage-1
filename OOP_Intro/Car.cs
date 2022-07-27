using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    public class Car
    {
        public int speed { get; set; }

        public string engine { get; set; }
        public bool IsElectric { get; set; }
        public decimal price { get; set; }
        public string transmission { get; set; }
    }
    public class BMW : Car
    {
        private string tempColor;
        public string colorr {
            get 
            {
                return tempColor;
            }
            set 
            {
                tempColor = value;
            }
        }
    }
}
