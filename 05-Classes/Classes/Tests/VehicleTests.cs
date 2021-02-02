﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle("Honda", "Civic", VehicleType.Car);
            firstVehicle.Make = "Honda";

            firstVehicle.Make = "CEC";
            firstVehicle.Model = "YT-1300f";
            firstVehicle.Mileage = 2400000;
            firstVehicle.Type = VehicleType.Spaceship;
            Console.WriteLine(firstVehicle.Mileage);
        }
        [TestMethod]
        public void Methods()
        {
            Vehicle myCar = new Vehicle("Honda", "Civic", VehicleType.Car);
            Console.WriteLine(myCar.IsRunning);
            myCar.TurnOn();
            // myCar.IsRunning = false; <--- gives an error because the setter is private
            Console.WriteLine(myCar.IsRunning);

        }
    }
}
