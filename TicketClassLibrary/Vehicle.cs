using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Helpers;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Constructor for a the base vehicle, must provide a valid licence number and date
        /// </summary>
        /// <param name="licencePlate">The licence number</param>
        /// <param name="date">The DateTime representing the time the ticket was purchased</param>
        /// <param name="broBizz">Whether or not the ticket should have BroBizz discount enabled</param>
        protected Vehicle(string licencePlate, DateTime date, bool broBizz)
        {
            LicencePlateValidator.ValidateLicencePlate(licencePlate);
            LicencePlate = licencePlate;
            Date = date;
            BroBizz = broBizz;
        }
        /// <summary>
        /// Represents wherther or not the given ticket has BroBizz discount
        /// </summary>
        public bool BroBizz {  get; private set; }
        /// <summary>
        /// Represents the licence plate for the vehicle as a string
        /// </summary>
        public string LicencePlate { get; private set; }
        /// <summary>
        /// The DateTime representing the time the ticket was purchased
        /// </summary>
        public DateTime Date { get; private set; }
        /// <summary>
        /// Returns the price of the ticket, including discounts
        /// </summary>
        /// <returns>A double representing the price</returns>
        public abstract double Price();
        /// <summary>
        /// Returns the price of the ticket, excluding discounts
        /// </summary>
        /// <returns>A double representing the price</returns>
        public abstract double PriceNoDiscount();
        /// <summary>
        /// Returns the vehicle type as a string
        /// </summary>
        /// <returns>A string represneation of the vehicle type</returns>
        public abstract string VehicleType();
    }
}
