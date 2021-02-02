using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EFAassignment
{
    [TestClass]
    public class W1D3amAsg
    {
        [TestMethod]
        public void TestMethod1()
        {
            string word = "Supercalifragilisticexpialidocious";
            int count = 0;
            foreach (char letter in word)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);

                }
                //else if(letter = 'l'){
                //     Console.WriteLine("L");
                // }
                else
                {

                    Console.WriteLine("Not 'i', said the console.");
                }

                count++;
            }

             Console.WriteLine(word.Length);
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    // "" same as foreach from here
                }

            
        }
       
    }
}