
namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car object
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for a car object, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the car</param>
        /// <param name="date"></param>
        public Car(string licencePlate, DateTime date) : base(licencePlate, date)
        {
        }
        /// <summary>
        /// Default constructor for a car object, will give the car some predetermined default values
        /// </summary>
        public Car() : base("AA12345", new DateTime(2000, 1, 1))
        {
        }

        public override double Price()
        {
            return 240;
        }
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
