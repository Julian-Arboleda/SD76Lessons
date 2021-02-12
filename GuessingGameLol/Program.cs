using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameLol
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Development";
            string guess = "";

            while (guess != secretWord)
            {
                Console.WriteLine("Enter guess: ");
                guess = Console.ReadLine();


            }

            Console.WriteLine();
        }
    }
}
