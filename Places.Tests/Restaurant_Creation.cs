using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places;

namespace Places.UnitTests
{
    [TestClass]
    public class Restaurant_Creation
    {
        [TestMethod]
        public void TestCreateDefaultRestaurant()
        {
            var restaurant = CreateRestaurant();

            Assert.IsInstanceOfType(restaurant, typeof(Restaurant));
        }

        private Restaurant CreateRestaurant()
        {
            var placeAddress = CreatePlaceAddress();
            return new Restaurant()
                {
                    PlaceName = "105-tka",
                    PlaceAddress = placeAddress
                };
        }

        private PlaceAddress CreatePlaceAddress()
        {
            return new PlaceAddress()
            {
                Country = "Poland",
                City = "Warsaw",
                Street = "Obywatelska",
                Number = "5",
                PostCode = "02-409"
            };
        }
    }
}
