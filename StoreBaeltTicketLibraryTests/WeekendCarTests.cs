using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class WeekendCarTests
    {
        [TestMethod()]
        public void WeekendCarTest_PriceWithBroBizz()
        {
            Vehicle car = new WeekendCar("AB12345", DateTime.Now, true);
            double expected = 182.4;
            double actual = car.Price();
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void WeekendCarTest_PriceWithoutBroBizz()
        {
            Vehicle car = new WeekendCar("AB12345", DateTime.Now, false);
            double expected = 192;
            double actual = car.Price();
            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}