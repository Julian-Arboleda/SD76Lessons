using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    // Instructions/ Greeting/ Title
    //Draw the game board
    // Word List
    //    Random Word Generator
    // Letterbank
    // Six Tries/ Game over
    //   same letter twice
    //
    public class Program
    {

        public static void Main(string[] args)
        {
            char guess;
            int lives = 6;
            int guesses = 0;
            bool outOfGuesses = false;
            TitleScreen();
            string secretWord = CreateWordList();
            List<char> letterBank = new List<char> { };
            SwitchHangman();

            do
            {
                Console.Clear();
                List<char> wordHidden = new List<char>();
                foreach (var i in secretWord)
                {
                    if (letterBank.Contains(i))
                    {
                        wordHidden.Add(i);
                    }
                    else
                    {
                        wordHidden.Add('-');

                    }
                }
                string dashed = new string(wordHidden.ToArray());
                Console.WriteLine(dashed);
                string bank = new string(letterBank.ToArray());
                Console.WriteLine(bank);
                Console.WriteLine("Guess a letter");
                guesses++;
                guess = Console.ReadKey().KeyChar;
                if (GuessedAlready(guess, letterBank) == false)
                {
                    if (GuessedWrong(guess, secretWord) == true)
                    {
                        lives--;
                    }

                    letterBank.Add(guess);
                }
                if (lives == 0)
                {
                    outOfGuesses = true;
                    Console.WriteLine();
                    Console.WriteLine("You've lost sucka!");
                    Thread.Sleep(2000);
                }
                if (DidWin(letterBank, secretWord) == true)
                {
                    outOfGuesses = true;
                    Console.WriteLine(  );
                    Console.WriteLine("You won, you're not a sucka!");
                    Console.WriteLine($"The word was:" + secretWord);
                    Thread.Sleep(4000);
                }





            }
            while (outOfGuesses == false);
        }

        public static bool DidWin(List<char> letterBank, string secretWord)
        {
            foreach (var i in secretWord)
            {
                if (letterBank.Contains(i) == false)
                {                    
                    return false;
                }

            } return true;

        }


    public static void TitleScreen()
        {

            Console.WriteLine("         ______    ");               
            Console.WriteLine("        |      |   ");
            Console.WriteLine("        |      O    ");
            Console.WriteLine("        |     \\|/    ");
            Console.WriteLine("        |      |     ");
            Console.WriteLine("        |     / \\    ");
            Console.WriteLine("     __ | ______");
            Console.WriteLine("Welcome to Hangman!!");
            Console.WriteLine("Guess the secret word. You're already hanging, So you must figure out the secret word before you run out of air. " +
                "You have six tries to guess each letter or you die :'( ");
            Console.ReadKey();
            Console.Clear();
        }



        public static string CreateWordList()
        {
            Random random = new Random();
            List<string> secretWord = new List<string>()
            {
                "development",
                "software",
                "computer",
                "mouse",
                "cantalope",
                "stressful"
            };
            int index = random.Next(secretWord.Count);
            // Console.WriteLine(secretWord[index]);
            return secretWord[index];
        }


        public static bool GuessedWrong(char guessedLetter, string randomWord)
        {
            //check the entire random word
            foreach (var l in randomWord)
            {
                if (guessedLetter == l)
                {
                    Console.WriteLine();
                    Console.WriteLine("You are correct!");
                    Thread.Sleep(500);
                    return false;
                }

            }
            return true;

        }

        public static bool GuessedAlready(char guessedLetter, List<char> bank)
        {
            //check the entire random word
            foreach (var l in bank)
            {
                if (guessedLetter == l)
                {

                    return true;
                }
            }
            return false;

        }

        public static void GuessedRight()
        {
            Console.WriteLine("Congrats, you won the game");
        }
        public static void SwitchHangman()
        {
            int guessedWrong = 0;
            string hangman0 = System.IO.File.ReadAllText(@"hangman0.txt");
            string[] gameBoard = {
                    @"hangman0.txt",
                    @"hangman1.txt",
                    @"hangman2.txt",
                    @"hangman3.txt",
                    @"hangman4.txt",
                    @"hangman5.txt",
                    @"hangman6.txt" };

            switch (guessedWrong)
            {
                case 0:
                    guessedWrong = 0;
                    Console.WriteLine(File.ReadAllLines(@"C:\Users\arbol\source\repos\SD76Lessons\ConsoleGame\hangman0.txt"));
                    break;
                case 1:
                    guessedWrong = 1;
                    Console.WriteLine(File.ReadAllLines(@"hangman1.txt"));
                    break;
                case 2:
                    guessedWrong = 2;
                    Console.WriteLine(File.ReadAllLines(@"hangman2.txt"));
                    break;
                case 3:
                    guessedWrong = 3;
                    Console.WriteLine(File.ReadAllLines(@"hangman3.txt"));
                    break;
                case 4:
                    guessedWrong = 4;
                    Console.WriteLine(File.ReadAllLines(@"hangman4.txt"));
                    break;
                case 5:
                    guessedWrong = 5;
                    Console.WriteLine(File.ReadAllLines(@"hangman5.txt"));
                    break;
                case 6:
                    guessedWrong = 6;
                    Console.WriteLine(File.ReadAllLines(@"hangman6.txt"));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}






/* public static void CreateLetterBank()
  {            
      List<char> letterBank = new List<char> {};
      char userInput = Console.ReadKey();
      letterBank.Add(userInput);

  }
      Console.WriteLine(letterBank);
      Console.WriteLine("Choose your letter");
      Console.ReadKey();
      *//*var userChar = Console.ReadLine();
      Console.WriteLine("You chose: " + userChar);
      letterBank.Remove((userChar();*//*

*/
/*                            Console.WriteLine("         ______    ");
                            Console.WriteLine("        |      |   ");
                            Console.WriteLine("        |      O    ");
                            Console.WriteLine("        |     \\|/    ");
                            Console.WriteLine("        |      |     ");
                            Console.WriteLine("        |     / \\    ");
                            Console.WriteLine("   ____ | ______");*/