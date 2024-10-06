using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundBronLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void VehicleTypeTests_ReturnsOresund_car()
        {
            Vehicle car = new OresundCar("AB12345", DateTime.Now, false);
            string expected = "Oresund car";
            string actual = car.VehicleType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceNoDiscountTests_Returns410()
        {
            Vehicle car = new OresundCar("AB12345", DateTime.Now, false);
            double expected = 410;
            double actual = car.Price();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceWithBrobizzTests_Returns161()
        {
            Vehicle car = new OresundCar("AB12345", DateTime.Now, true);
            double expected = 161;
            double actual = car.Price();
            Assert.AreEqual(expected, actual);
        }
    }
}