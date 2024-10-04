namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a car object
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Represents the licence plate for the car
        /// </summary>
        public string LicencePlate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
