using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    class WhiteboardProblems
    {
        // Paramter + return value, no console
        public string CombineStrings(string stringOne, string stringTwo)
        {
            return stringOne + "   " + stringTwo;
        }

        public void CombineStrings()
        {
            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();
            Console.WriteLine(stringOne + "    " + stringTwo);
        }


        // Both return and writing to the console are output
        // Parameters and Console.ReadLine() are both input



        public double GetSmaller(double firstNumber, double secondNumber)
        {
            // You can nest ternaries but don't nest ternaries
            return firstNumber < secondNumber ? firstNumber : secondNumber;
           
                
                /* if (firstNumber < secondNumber)
            {
                return firstNumber;
            } else if (firstNumber == secondNumber) {
                cw ("They are ");
            }
                return secondNumber;
            */
                
        }


        public void WriteProduct(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }




        public bool isWeekend(string dayOfWeek)
        {
            // string dayOfWeek = "Mondays";
            switch (dayOfWeek)
            {
                case "Saturday":
                case "Sunday":
                    return true;
                    // don't need to break because we return
                    // break ends the switch case
                    // return ends the whole method
                    //break;
                default:
                    return false;
            }
        }



        

        

    }
}
