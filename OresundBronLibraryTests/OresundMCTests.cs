using OresundBronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundBronLibraryTests
{
    [TestClass]
    public class OresundMCTests
    {
        [TestMethod()]
        public void VehicleTypeTests_ReturnsOresund_MC()
        {
            Vehicle car = new OresundMC("AB12345", DateTime.Now, false);
            string expected = "Oresund MC";
            string actual = car.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceNoDiscountTests_Returns210()
        {
            Vehicle car = new OresundMC("AB12345", DateTime.Now, false);
            double expected = 210;
            double actual = car.Price();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceWithBrobizzTests_Returns73()
        {
            Vehicle car = new OresundMC("AB12345", DateTime.Now, true);
            double expected = 73;
            double actual = car.Price();
            Assert.AreEqual(expected, actual);
        }
    }
}
