using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// This class represents a ticket to a car which is getting the weekend discount
    /// </summary>
    public class WeekendCar : Car
    {
        const double WEEKENDDISCOUNT = 20;
        const double BROBIZZDISCOUNT = 5;
        /// <summary>
        /// Constructor for a weekend car object, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the car</param>
        /// <param name="date">the DateTime representing the time the ticket was purchased</param>
        /// <param name="broBizz">Whether or not the ticket should have BroBizz discount enabled</param>
        public WeekendCar(string licencePlate, DateTime date, bool broBizz) : base(licencePlate, date, broBizz)
        {
            
        }


        private double CalculateWeekendDiscount(double price)
        {
            return price * (1 - (WEEKENDDISCOUNT / 100));
        }
        private double CalculateBrobizzDiscount(double price)
        {
            return price * (1 - (BROBIZZDISCOUNT / 100));
        }
        /// <inheritdoc/>
        public override double Price()
        {
            if (BroBizz)
            {
                double afterWeekendDiscount = CalculateWeekendDiscount(PriceNoDiscount());
                return CalculateBrobizzDiscount(afterWeekendDiscount);
            }
            else
            {
                return CalculateWeekendDiscount(PriceNoDiscount());
            }
        }
    }
}
