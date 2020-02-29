using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Places.Tests
{
    [TestClass]
    public class Diamond_Test
    {
        private static int ONE_DIAMOND = 1;
        private static int ZERO_DIAMONDS = 0;

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
        public void AddDiamondToRestaurant()
        {
            restaurant.AddDiamond();

            Assert.IsTrue(restaurant.GetDiamonds() == ONE_DIAMOND, "Diamond not added");
        }

        [TestMethod]
        [ExpectedException(typeof(DiamondAlreadyAddedException))]
        public void AddDiamondTwiceToRestaurant()
        {
            restaurant.AddDiamond();
            restaurant.AddDiamond();
        }

        [TestMethod]
        public void RemoveAddedDiamondFromRestaurant()
        {
            restaurant.AddDiamond();
            restaurant.RemoveDiamond();

            Assert.IsTrue(restaurant.GetDiamonds() == ZERO_DIAMONDS, "Diamond not added");
        }

        [TestMethod]
        [ExpectedException(typeof(DiamondNotAddedException))]
        public void RemoveDiamondFromRestaurantWhenNotAdded()
        {
            restaurant.RemoveDiamond();
        }
        
    }
}
