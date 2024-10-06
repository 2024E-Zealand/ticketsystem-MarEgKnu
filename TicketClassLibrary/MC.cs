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
        private const double BROBIZZDISCOUNT = 5;
        private const double BASETICKETPRICE = 125;
        /// <summary>
        /// Constructor for a MC object, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the MC</param>
        /// <param name="date">The DateTime representing the time the ticket was purchased</param>
        /// <param name="broBizz">Whether or not the ticket should have BroBizz discount enabled</param>
        public MC(string licencePlate, DateTime date, bool broBizz) : base(licencePlate, date, broBizz)
        {
        }
        /// <summary>
        /// Default constructor for a MC object, will give the MC some predetermined default values
        /// </summary>
        public MC() : base("AA12345", new DateTime(2000, 1, 1), false)
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
            return "MC";
        }
    }
}
