using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class MC
    {
        public string LicencePlate { get; set; }
        public DateTime Date {  get; set; }

        public double Price()
        {
            return 125;
        }
        public string VehicleType()
        {
            return "MC";
        }
    }
}
