using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Greeter
    {
        Random _random = new Random();
        // Method
                            // Parameter
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");

        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayRandomGreeting(string name)
        {
            Console.WriteLine($"{GetRandomGreeting()}, {name}"); // can insert methods
        }

        private string GetRandomGreeting() // since youre using internally
        {
            string[] greetings = new string[] {"Hi", "Yo", "Wassup", "how are you, Hola" };
            int randomNumber = _random.Next(0, greetings.Length);
            string randomGreeting = greetings.ElementAt(randomNumber);
            // alt /string randomGreeting = greetings[randomNumber];
            return randomGreeting;

        }

    }
}
