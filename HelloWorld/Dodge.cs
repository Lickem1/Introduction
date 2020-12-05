using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Dodge : Car
    {

        public Dodge(string car, int year)
        {
            this.model = "Dodge";
            this.name = car;
            this.year = year;
        }

        public override void gas()
        {
            throw new NotImplementedException();
        }
    }
}
