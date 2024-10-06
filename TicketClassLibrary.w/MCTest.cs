using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace VehicleAppTests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Tester prisen for MC (125 kr).
        /// </summary>
        [TestMethod]
        public void Price_ReturnPrice_125()
        {
            var mc = new MC();
            var result = mc.Price();
            Assert.AreEqual(125.0, result);
        }

        /// <summary>
        /// Tester at VehicleType returnerer "MC".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnMCString()
        {
            var mc = new MC();
            var result = mc.VehicleType();
            Assert.AreEqual("MC", result);
        }

        /// <summary>
        /// Tester at nummerpladen max er 7 tegn.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlate_ShouldThrowException_IfMoreThan7Characters()
        {
            var mc = new MC();
            mc.LicensePlate = "12345678";
        }

        /// <summary>
        /// Tester 5% rabat med BroBizz.
        /// havde mange problemer med rabat delen. den lykkedes med at det var den pris efter rabbaten der skulle sætten ind
        /// </summary>
        [TestMethod]
        public void DiscountBB_WithBroBizz_ShouldApply5PercentDiscount()
        {
            var mc = new MC
            {
                BroBizz = true
            };
            var discountedPrice = mc.DiscountBB();
            Assert.AreEqual(118.75, discountedPrice, 0.01);
        }
    }
}