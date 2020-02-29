using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places
{
    public abstract class Place
    {
        private string placeId;
        private string placeName;
        private PlaceAddress placeAddress;
        private int diamonds;

        private bool addedDiamond = false;

        public Place(string PlaceName, PlaceAddress PlaceAddress)
        {
            placeName = PlaceName;
            placeAddress = PlaceAddress;
            diamonds = 0;
        }

        public int GetDiamonds()
        {
            return diamonds;
        }

        public void AddDiamond()
        {
            if (!DiamondAlreadyAdded())
            {
                diamonds++;
                addedDiamond = true;
            }
            else
                throw new DiamondAlreadyAddedException();
        }

        public void RemoveDiamond()
        {
            if (DiamondAlreadyAdded())
                diamonds--;
            else
                throw new DiamondNotAddedException();
        }

        private bool DiamondAlreadyAdded()
        {
            return addedDiamond;
        }

    }
}
