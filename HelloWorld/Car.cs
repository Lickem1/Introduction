using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    abstract class Car
    {
        public static ArrayList cars = new ArrayList();

       
        public string model { get; set; }
        public int year { get; set; }
        public string name { get; set; }


        public Car()
        {
            cars.Add(this);
        }


        public abstract void gas();
    }
}
