using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;
using System;

namespace VehicleAppTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_ReturnPrice_240()
        {
            // Opret en instans af Car-klassen
            var car = new Car();

            // Kald Price for at få prisen
            var result = car.Price();

            // prisen er lig med 240
            Assert.AreEqual(240.0, result, "Prisen bør være 240.");
        }

        [TestMethod]
        public void VehicleType_ShouldReturnCarString()
        {
            // Opret en instans af Car-klassen
            var car = new Car();

            // Kald VehicleType for at få køretøjstypen
            var result = car.VehicleType();

            // Bekræft VehicleType returnerer "Car"
            Assert.AreEqual("Car", result, "Køretøjstypen bør være 'Car'.");
        }
    }
}