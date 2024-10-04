using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Constructor for a the base vehicle, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number</param>
        /// <param name="date"></param>
        protected Vehicle(string licencePlate, DateTime date)
        {
            LicencePlate = licencePlate;
            Date = date;
        }
        /// <summary>
        /// Represents the licence plate for the vehicle as a string
        /// </summary>
        public string LicencePlate { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        /// <summary>
        /// Returns the vehicle type as a string
        /// </summary>
        /// <returns>A string represneation of the vehicle type</returns>
        public abstract string VehicleType();
    }
}
