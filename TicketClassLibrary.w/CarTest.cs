using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace TicketClassLibrary.w
{
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Tester at Price-metoden returnerer 240.
        /// </summary>
        [TestMethod]
        public void Price_ReturnPrice_240()
        {
            // Opretter en bil
            var car = new Car();

            // Henter prisen
            var result = car.Price();

            // Bekræfter at prisen er 240
            Assert.AreEqual(240.0, result, "Prisen bør være 240.");
        }

        /// <summary>
        /// Tester at VehicleType-metoden returnerer "Car".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnCarString()
        {
            // Opretter en bil
            var car = new Car();

            // Henter køretøjstypen
            var result = car.VehicleType();

            // Bekræfter at køretøjstypen er "Car"
            Assert.AreEqual("Car", result, "Køretøjstypen bør være 'Car'.");
        }
        
        /// <summary>
        /// Tester at ArgumentException bliver kastet hvis nummerpladen er længere end 7 tegn.
        /// samt bliver der opretter en bil med nummerpladen som længere end 7 tegn.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateType_ShouldNotBeLongeThan7Characters()
        {
            
            var car = new Car();
            
            car.LicensePlate="12345678";
        }
    }
}