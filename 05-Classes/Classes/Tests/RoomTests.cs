using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes.Tests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void Volume()
        {
            Room closet = new Room(5, 5, 10);
            Console.WriteLine("closet volume: " + closet.Volume);
            Console.WriteLine("closet SA: " + closet.SurfaceArea);

            Room bobsRoom = new Room(5, 5, 10);
            Console.WriteLine("BobsRoom's  volume: " + closet.Volume);
            Console.WriteLine("BobsRoom's SA: " + closet.SurfaceArea);

        }
    }
}
