using System;

namespace VehicleApp
{
    /// <summary>
    /// Repræsenterer en motorcykel som arver fra base klassen vehicle
    /// </summary>
    public class MC : Vehicle

    {
        
        /// <summary>
        /// Opretter en MC
        /// </summary>
        public override double Price()
        {
            return 125.0;
        }

        
        /// <summary>
        /// Returnerer køretøjstypen
        /// </summary>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}