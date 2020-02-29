using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places;

namespace Places.Tests
{
    [TestClass]
    public class Restaurant_Creation
    {
        Restaurant restaurant;

        [TestInitialize]
        public void TestInitialize()
        {
            restaurant = GetRestaurant();
        }

        private Restaurant GetRestaurant()
        {
            var placeAddress = new PlaceAddress("Obywatelska", "5", "Warszawa");
            return new Restaurant("105-tka", placeAddress);
        }

        [TestMethod]
        public void TestCreateRestaurant()
        {
            Assert.IsInstanceOfType(restaurant, typeof(Restaurant));
        }

    }
}
