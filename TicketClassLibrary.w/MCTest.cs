using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleApp;

namespace TicketClassLibrary.w
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
         
            var mc = new Mc();

       
            var result = mc.Price();
            Assert.AreEqual(125.0, result, "Prisen skal være 125.");
        }

        /// <summary>
        /// Tester at VehicleType-metoden returnerer "MC".
        /// </summary>
        [TestMethod]
        public void VehicleType_ShouldReturnMCString()
        {
            var mc = new Mc();
            var result = mc.VehicleType();

            
            Assert.AreEqual("MC", result, "Køretøjstypen skal være 'MC'.");
        }
        
        /// <summary>
        /// Tester at ArgumentException bliver kastet hvis nummerpladen er længere end 7 tegn.
        /// Vehicle klassen skal ikke testes da mc og car nedarver fra den.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateType_ShouldNotBeLongeThan7Characters()
        {
            
            var mc = new Mc();
            mc.LicensePlate="12345678";
        }
    }
}