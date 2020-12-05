using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Ford : Car
    {

        private int gasTank = 0;

        public Ford(string carName, int year)
        {
            this.model = "Ford";
            this.name = carName;
            this.year = year;
        }

        public override void gas()
        {

            while (gasTank < 10)
            {
                Console.WriteLine("Filling up gas tank " + (gasTank+1) + "...");
                gasTank++;
            }

            Console.WriteLine(year + " " + model + " " + name + " has " + (gasTank == 10 ? "full" : "empty") + " tank");
        }
    }
}
