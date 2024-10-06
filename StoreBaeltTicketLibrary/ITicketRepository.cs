using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibraryTests
{
    /// <summary>
    /// Interface for the ticket repository
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// Adds a ticket to the repository
        /// </summary>
        /// <param name="ticket">A vehicle object representing the ticket</param>
        public void AddTicket(Vehicle ticket);
        /// <summary>
        /// Returns all tickets in the repository
        /// </summary>
        /// <returns>A list containing all tickets</returns>
        public List<Vehicle> GetAllTickets();
        /// <summary>
        /// Returns all tickets in the repository which has a matching licence plate
        /// </summary>
        /// <param name="licenceNum">The licence plate to match/param>
        /// <returns>A list of tickets which has a matching licence plate</returns>
        public List<Vehicle> GetByLicenceNumber(string licenceNum);
    }
}
