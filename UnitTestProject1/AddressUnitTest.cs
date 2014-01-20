using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class AddressUnitTest
    {
        [TestMethod]
        public void CreateAddres()
        {
            string street = "C/ Madeira";
            string number = "19";
            string town = "Atarfe";
            string state = "Málaga";
            string country = "España";
            string postAd = "18008";

            Address anAddress = new Address(street, number, town, state, country, postAd);
            
            Assert.AreEqual(anAddress.Street, street);
            Assert.AreEqual(anAddress.Number, number);
            Assert.AreEqual(anAddress.Town, town);
            Assert.AreEqual(anAddress.State, state);
            Assert.AreEqual(anAddress.Country, country);
            Assert.AreEqual(anAddress.PostAd, postAd);
        }

        [TestMethod]
        public void EmptyAddres()
        {
            string street = "C/ Madeira";
            string number = "19";
            string town = "Atarfe";
            string state = "Málaga";
            string country = "España";
            string postAd = "18008";

            Address anAddress = new Address(street, number, town, state, country, postAd);
            anAddress.Clear();

            Assert.AreEqual(anAddress.Street, "");
            Assert.AreEqual(anAddress.Number, "");
            Assert.AreEqual(anAddress.Town, "");
            Assert.AreEqual(anAddress.State, "");
            Assert.AreEqual(anAddress.Country, "");
            Assert.AreEqual(anAddress.PostAd, "");
        }
    }
}
