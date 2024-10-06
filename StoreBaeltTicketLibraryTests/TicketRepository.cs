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
        public void AddTicket(Vehicle ticket)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetByLicenceNumber(string licenceNum)
        {
            throw new NotImplementedException();
        }
    }
}
