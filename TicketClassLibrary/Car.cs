
namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car object
    /// </summary>
    public class Car : Vehicle
    {
        private const double BROBIZZDISCOUNT = 5;
        private const double BASETICKETPRICE = 240;
        /// <summary>
        /// Constructor for a car object, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the car</param>
        /// <param name="date">The DateTime representing the time the ticket was purchased</param>
        /// <param name="broBizz">Whether or not the ticket should have BroBizz discount enabled</param>
        public Car(string licencePlate, DateTime date, bool broBizz) : base(licencePlate, date, broBizz)
        {
        }
        /// <summary>
        /// Default constructor for a car object, will give the car some predetermined default values
        /// </summary>
        public Car() : base("AA12345", new DateTime(2000, 1, 1), false)
        {
        }
        /// <inheritdoc/>
        public override double PriceNoDiscount()
        {
            return BASETICKETPRICE;
        }
        /// <inheritdoc/>
        public override double Price()
        {
            if (BroBizz)
            {
                return PriceNoDiscount() * (1 - (BROBIZZDISCOUNT / 100));
            }
            return PriceNoDiscount();
        }
        /// <inheritdoc/>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
