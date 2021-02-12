using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Call
            //FizzBuzz(15);
             FizzBuzz(Adds(5,7));
            Greeting("Class");
        }
        public static int Adds(int x, int y)
        {
            return x + y;
        }

        // Write a method that takes in a name then writes out a greeting with the name included
        public static void Greeting(string asdf)
        {
            Console.WriteLine($"Hello {asdf}");
        }
        public static void FizzBuzz(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Noun = Object
        // Adj = Properties
        // Verbs = Method       
    }
}
