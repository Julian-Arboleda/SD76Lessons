using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCondition()
        {
            int day = 2;

            switch(day)
            {
                case 0:
                    Console.WriteLine("Happy Monday /s :(");
                    break;
                case 1:
                    Console.WriteLine("it is tuesday");
                    break;
                case 2:
                    Console.WriteLine("It is humpday, my dudes!");
                        break;
                default:
                Console.WriteLine( "Happy whatever day");
                    break;


            }
       }
    }
}
