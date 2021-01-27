using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person();
            person.FirstName = "Julian";
            person.LastName = "Arboleda";
            person.DateOfBirth = new DateTime(1994, 4, 9);
            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.WriteLine(person.FullName);

            Person otherPerson = new Person(
                "Ashley", 
                "Lawrence", 
                new DateTime(1989, 4, 26),
                new Vehicle("Chevy", "Malibu", VehicleType.Car)
                );

            Console.WriteLine(otherPerson.FullName);
            Console.WriteLine(otherPerson.Vehicle.Make);

            //otherPerson.FirstName = "Ash";

        }
    }
}
