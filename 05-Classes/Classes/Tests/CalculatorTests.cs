using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //i wouldnt have to do this if i made my method static
            // i would just do Calculator.Divide(3, 5)
            Calculator calc = new Calculator();

            Console.WriteLine(3.0 / 5.0);
            // Console.WriteLine(calc.Divide(3,5));

            Console.WriteLine(calc.Add("3", "5"));
        }
    }
}
