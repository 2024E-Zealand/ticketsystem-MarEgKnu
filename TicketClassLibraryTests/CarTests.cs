using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest_Returns240_NoDiscount()
        {
            Vehicle car = new Car();
            double expected = 240;
            double actual = car.Price();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PriceTest_Returns228_WithBroBizz()
        {
            Vehicle car = new Car("AB12345", DateTime.Now, true);
            double expected = 228;
            double actual = car.Price();
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest_ReturnsCar()
        {
            Vehicle car = new Car();
            string expected = "Car";
            string actual = car.VehicleType();
            Assert.AreEqual(expected, actual);
        }
    }
}