using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// This class represents a MC vehicle object
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Constructor for a MC object, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the MC</param>
        /// <param name="date"></param>
        public MC(string licencePlate, DateTime date) : base(licencePlate, date)
        {
        }
        /// <summary>
        /// Default constructor for a MC object, will give the MC some predetermined default values
        /// </summary>
        public MC() : base("AA12345", new DateTime(2000, 1, 1))
        {
        }

        public override double Price()
        {
            return 125;
        }
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
