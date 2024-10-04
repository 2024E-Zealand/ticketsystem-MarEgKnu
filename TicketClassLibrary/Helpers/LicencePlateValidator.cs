using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Helpers
{
    /// <summary>
    /// Static class with methods to validate licencePlates
    /// </summary>
    public static class LicencePlateValidator
    {
        /// <summary>
        /// Validates the input string as a licence plate.
        /// The method does not return anything, but will throw an appropriate exception if the string does not conform to licence plate standards
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <exception cref="ArgumentNullException">Throws if the licence plate is null</exception>
        /// <exception cref="ArgumentException">Throws if the licence plate is not 7 characters</exception>
        public static void ValidateLicencePlate(string? licencePlate)
        {
            if (licencePlate == null)
            {
                throw new ArgumentNullException("Licence plate can't be null"); 
            }
            else if (licencePlate.Length != 7)
            {
                throw new ArgumentException("Licence plate must be 7 characters");
            }
        }
    }
}
