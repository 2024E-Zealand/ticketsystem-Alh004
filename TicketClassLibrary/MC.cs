using System;

namespace VehicleApp
{
    /// <summary>
    /// Repræsenterer en motorcykel.
    /// </summary>
    public class MC : Car
    {
        /// <summary>
        /// Returnerer prisen som er 125 kr.
        /// </summary>
        /// <returns>125 kr.</returns>
        public new double Price()
        {
            return 125.0;
        }

        /// <summary>
        /// Returnerer køretøjstypen som "MC".
        /// </summary>
        /// <returns>"MC"</returns>
        public new string VehicleType()
        {
            return "MC";
        }
    }
}