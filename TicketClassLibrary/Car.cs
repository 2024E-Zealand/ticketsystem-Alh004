using System;

namespace VehicleApp
{
    /// <summary>
    /// Repræsenterer en bil som arver fra Vehicle.
    /// </summary>
    public class Car : Vehicle
    {
        
        /// <summary>
        /// Returnerer prisen som er 240 kr.
        /// </summary>
        public override double Price()
        {
            return 240.0;
        }

        
        /// <summary>
        /// Returnerer køretøjstypen som "Car".
        /// </summary>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}