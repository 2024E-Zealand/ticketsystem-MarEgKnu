using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundBronLibrary
{
    /// <summary>
    /// This class represents a MC ticket object for Oresundsbron
    /// </summary>
    public class OresundMC : MC
    {
        const double BASETICKETPRICE = 210;
        const double BROBIZZPRICE = 73;
        /// <summary>
        /// Constructor for a MC object for Oresundsbron, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number of the car</param>
        /// <param name="date">The DateTime representing the time the ticket was purchased</param>
        /// <param name="broBizz">Whether or not the ticket should have BroBizz discount enabled</param>
        public OresundMC(string licencePlate, DateTime date, bool broBizz) : base(licencePlate, date, broBizz)
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
                return BROBIZZPRICE;
            }
            else
            {
                return PriceNoDiscount();
            }
        }

        /// <inheritdoc/>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
