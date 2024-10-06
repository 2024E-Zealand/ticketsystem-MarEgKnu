using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibraryTests
{
    public interface ITicketRepository
    {
        public void AddTicket(Vehicle ticket);

        public List<Vehicle> GetAllTickets();

        public List<Vehicle> GetByLicenceNumber(string licenceNum);
    }
}
