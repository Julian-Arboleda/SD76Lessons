using _11_IConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total < 100)
            {
                total = total + 1;
                // total++
                // total += 1

                Console.WriteLine("Total: " + total);
            }

            int number = 5;
            Console.WriteLine(number++);


            Random randy = new Random();
            int someNumber = randy.Next(0,21);

            while (true)
            {
                someNumber = randy.Next(0,21);
                if (someNumber == 7)
                {
                    break;
                }
                Console.WriteLine(someNumber);

            }

        }
        [TestMethod]
        public void ForLoops()
        {
            string greeting = "Hello World!";

            foreach (char letter in greeting)
            {
                Console.WriteLine(letter);

            }

            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("world");
            stringList.Add("banana");

            foreach (string word in stringList)
            {
                Console.WriteLine(word);
            }

            Random randy = new Random();
            for (int i = 0; i != 5; i = randy.Next(0,21))
            {
                if (i == 5)
                {
                    FunConsole console = new FunConsole("Ashley");
                    console.WriteLine("FIVE!!");
                }
                Console.WriteLine(i);


            }

        }
    }
}
