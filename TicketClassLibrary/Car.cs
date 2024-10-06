using VehicleApp;

namespace TicketClassLibrary
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

        public double WeekendDiscount()
        {
            var price = Price();

            if (Date.DayOfWeek==DayOfWeek.Saturday|| Date.DayOfWeek==DayOfWeek.Sunday)

            {
                price *= 0.80;
            }

            if (BroBizz)
            {
                price*= 0.95;
            }

            return price;
        }
    }
}