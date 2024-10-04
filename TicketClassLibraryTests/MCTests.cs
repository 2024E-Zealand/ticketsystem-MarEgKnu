using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace TicketClassLibraryTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest_Returns125()
        {
            Vehicle mc = new MC();
            double expected = 125;
            double actual = mc.Price();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeTest_ReturnsMC()
        {
            Vehicle mc = new MC();
            string expected = "MC";
            string actual = mc.VehicleType();
            Assert.AreEqual(expected, actual);
        }
    }
}
