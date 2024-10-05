using System;

namespace VehicleApp
{
    /// <summary>
    /// Repræsenterer en bil.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Bilens nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// En dato relateret til bilen.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen som er 240 kr.
        /// </summary>
        /// <returns>240 kr.</returns>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returnerer køretøjstypen som "Car".
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}