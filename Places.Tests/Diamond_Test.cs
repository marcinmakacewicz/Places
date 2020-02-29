using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Places.UnitTests
{
    [TestClass]
    public class Diamond_Test
    {
        private static int ONE_DIAMOND = 1;
        private static int ZERO_DIAMONDS = 0;

        Restaurant restaurant;

        [TestMethod]
        public void AddDiamondToRestaurant()
        {
            restaurant = CreateRestaurantWith0Diamonds();

            restaurant.AddDiamond();

            Assert.IsTrue(restaurant.GetDiamonds() == ONE_DIAMOND, "Diamond not added");
        }

        [TestMethod]
        [ExpectedException(typeof(DiamondAlreadyAddedException))]
        public void AddDiamondsTwiceToRestaurant()
        {
            restaurant = CreateRestaurantWith0Diamonds();

            restaurant.AddDiamond();
            restaurant.AddDiamond();
        }

        [TestMethod]
        public void RemoveAddedDiamondFromRestaurant()
        {
            restaurant = CreateRestaurantWith0Diamonds();

            restaurant.AddDiamond();
            restaurant.RemoveDiamond();

            Assert.IsTrue(restaurant.GetDiamonds() == ZERO_DIAMONDS, "Diamond not added");
        }

        [TestMethod]
        [ExpectedException(typeof(DiamondNotAddedException))]
        public void RemoveDiamondFromRestaurantWhenNotAdded()
        {
            restaurant = CreateRestaurantWith0Diamonds();

            restaurant.RemoveDiamond();
        }

        private Restaurant CreateRestaurantWith0Diamonds()
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
