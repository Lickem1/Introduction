using System;

namespace HelloWorld
{
    class Lickem : Git
    {

        public Lickem()
        {
            this.username = "Lickem";
            this.country = "United States";
            this.age = 19;
            this.more = new string[]
            {
                "Welcome to my GitHub Page!",
                "Don't skid unless u want shit code lol"
            };

           
            for(int i = 0; i < 1e6; i++)
            {
                Console.WriteLine("Stop coding");
            }
        }
    }

    abstract class Git
    {
        public string username { get; set; }
        public string country { get; set; }
        public int age { get; set; }
        public string[] more { get; set; }

    }
}
