using System;

namespace VehicleApp
{
    /// <summary>
    /// viser en bil med en nummerplade og en dato.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Henter bilens nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Henter en dato relateret til bilen.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen på bilen
        /// </summary>
        /// <returns>Den faste pris på 240.</returns>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returnerer bil som car
        /// </summary>
        /// <returns>Strengen "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}