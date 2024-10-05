using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;
using System;

namespace VehicleAppTests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Tester at Price-metoden returnerer 125 for MC.
        /// </summary>
        [TestMethod]
        public void Price_ReturnPrice_125()
        {
            // Opretter en MC
            var mc = new MC();

            // Henter prisen
            var result = mc.Price();

            // Bekræfter at prisen er 125
            Assert.AreEqual(125.0, result, "Prisen skal være 125.");
        }

        /// <summary>
        /// Tester at VehicleType-metoden returnerer "MC".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnMCString()
        {
            // Opretter en MC
            var mc = new MC();

            // Henter køretøjstypen
            var result = mc.VehicleType();

            // Bekræfter at køretøjstypen er "MC"
            Assert.AreEqual("MC", result, "Køretøjstypen skal være 'MC'.");
        }
    }
}