using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary.Helpers;

namespace TicketClassLibraryTests
{
    [TestClass]
    public class LicencePlateValidatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateLicencePlateTest_ArgumentNullException()
        {
            string licencePlate = null;
            LicencePlateValidator.ValidateLicencePlate(licencePlate);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataTestMethod]
        [DataRow("AB1234")] // 6 chars
        [DataRow("AB123455")] // 8 chars
        [DataRow("")] // 0 chars
        public void ValidateLicencePlateTest_ArgumentException_XCharacters(string licencePlate)
        {
            LicencePlateValidator.ValidateLicencePlate(licencePlate);
            Assert.Fail();
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("AB12340")] 
        [DataRow("AB12345")]
        [DataRow("TG31356")]
        [DataRow("AE565EF")] 
        public void ValidateLicencePlateTest_NoException_7Characters(string licencePlate)
        {
            LicencePlateValidator.ValidateLicencePlate(licencePlate);
            Assert.IsTrue(true);
        }
    }
}
