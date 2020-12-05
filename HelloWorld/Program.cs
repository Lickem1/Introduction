using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Ford fiesta = new Ford("Fiesta", 2020);
            Dodge charger = new Dodge("Dodge Charger", 1999);

            int ford = 0;
            int dodge = 0;

            foreach (Car c in Car.cars)
            {
                if (c is Ford)
                {
                    ford++;
                } else if(c is Dodge)
                {
                    dodge++;
                }

            }

            Console.WriteLine("You have " + ford + " Ford cars!");
            Console.WriteLine("You have " + dodge + " Dodge cars!");

        }
    }
}
