using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibraryTests
{
    public class TicketRepository : ITicketRepository
    {
        private static List<Vehicle> _tickets = new List<Vehicle>();
        /// <inheritdoc/>
        public void AddTicket(Vehicle ticket)
        {
            _tickets.Add(ticket);
        }
        /// <inheritdoc/>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }
        /// <inheritdoc/>
        public List<Vehicle> GetByLicenceNumber(string licenceNum)
        {
            return _tickets.FindAll(t => t.LicencePlate == licenceNum);
        }
    }
}
