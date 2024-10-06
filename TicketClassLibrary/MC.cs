namespace VehicleApp
{
    /// <summary>
    /// Motorcykel.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returnerer prisen (125 kr).
        /// </summary>
        public override double Price()
        {
            return 125.0;
        }

        /// <summary>
        /// Returnerer "MC".
        /// </summary>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}