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
        
        
        /// <summary>
        /// Tester at brobizz rabatten virker
        /// </summary>
        [TestMethod]
        public void DiscountBB_WithBroBizz_ShouldApply5PercentDiscount()
        {
            var car = new Car()
            {
                BroBizz = true
            };
            var discountedPrice = car.DiscountBB();
            Assert.AreEqual(228.0, discountedPrice, 0.01);
        }
        
        
        /// <summary>
        /// Tester weekndsrabbaten virker
        /// </summary>
        [TestMethod]
        public void WeekendDiscount_OnWeekend()
        {
            var car = new Car()
            {
                Date = new DateTime(2025,03,23),
                BroBizz = false
            };
            var discountedPrice = car.WeekendDiscount();
            Assert.AreEqual(192.0, discountedPrice, 0.01);
        }
        
        
        /// <summary>
        /// Tester at weekndsrabbaten + brobizz rabbaten virker
        /// </summary>
        [TestMethod]
        public void DiscountBB_WithBroBizz_ShouldApply5PercentDiscount_Also_with_Weekend_Discount()
        {
            var car = new Car()
            {
                Date = new DateTime(2025,03,23),
                BroBizz = true
            };
            var discountedPrice = car.WeekendDiscount();
            Assert.AreEqual(182.4, discountedPrice, 0.01);
        }
        
    }
}