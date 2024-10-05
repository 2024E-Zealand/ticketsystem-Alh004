using System;

namespace VehicleApp
{
    /// <summary>
    /// Repræsenterer en bil med en nummerplade og en dato.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Henter eller angiver bilens nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Henter eller angiver en dato relateret til bilen.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen på bilen, som er fastsat til 240.
        /// </summary>
        /// <returns>Den faste pris på 240.</returns>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returnerer køretøjstypen, som er "Car".
        /// </summary>
        /// <returns>Strengen "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}