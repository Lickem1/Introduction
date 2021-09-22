using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Isa's Math Shit!!! HELL YEAH OOOOOOO");
            Console.WriteLine("Enter function number:");
            Console.WriteLine("");
            Console.WriteLine("1. Divisibles of numbers");
            Console.WriteLine("2. Common Multiples of Numbers");
            Console.WriteLine("");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("Entering Divisibles");
                    divisibleMethod(args);
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Entering Common Multiples");
                    multipleMethod(args);
                    break;

                default: Main(args); break;
            }
        }

        static void divisibleMethod(string[] args)
        {
            Console.WriteLine("Type as many numbers | Use '/back' to go back to main menu");
            string[] input = Console.ReadLine().Split(" ");

            if(input[0] == "/back")
            {
                Console.WriteLine();
                Main(args);
                return;
            }

            IEnumerable<int> common = divisibleBy(input);
            Console.WriteLine();
            Console.Write("Divisibles of ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + (i == input.Length - 1 ? "" : ", "));
            }
            Console.WriteLine();

            if (!common.Any())
            {
                Console.Write("None");
            }
            else
            {
                foreach (int i in common)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine();
            common = null;
            divisibleMethod(args);
        }

        static void multipleMethod(string[] args)
        {
            Console.WriteLine("Type as many numbers | Use '/back' to go back to main menu");
            string[] input = Console.ReadLine().Split(" ");

            if(input[0] == "/back") {
                Console.WriteLine();
                Main(args);
                return;
            }
            
            IEnumerable<int> common = commonMultiples(input);
            
            Console.WriteLine();
            Console.Write("Common Multiples of ");
            for(int i = 0; i < input.Length; i++) {
                Console.Write(input[i] + (i == input.Length-1 ? "" : ", ") );
            }
            Console.WriteLine();

            if(!common.Any())
            {
                Console.Write("None");
            } else
            {
                foreach (int i in common)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine();
            common = null;
            multipleMethod(args);
        }

        static IEnumerable<int> commonMultiples(string[] input)
        {
            List<int> common = new List<int> {};
            foreach (string i in input)
            {
                int o = int.Parse(i);
                for (int i2 = 1; i2 < 100; i2++) {
                    int p = i2 * o;
                    common.Add(p);
                }
            }
            return common.GroupBy(i => i).Where(g => g.Count() >= input.Length).Select(g => g.Key);

        }

        static IEnumerable<int> divisibleBy(string[] input)
        {
            List<int> by = new List<int> {};
            foreach (string each in input)
            {
                int o = int.Parse(each);
                for(int i = 2; i < 100; i++)
                {
                    if(o % i == 0) {
                        by.Add(i);
                    }
                }
            }
            return by.GroupBy(i => i).Where(g => g.Count() >= input.Length).Select(g => g.Key);
        }
    }

}
