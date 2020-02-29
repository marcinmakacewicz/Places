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
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public PlaceAddress PlaceAddress { get; set; }

        private int diamonds;
        private bool addedDiamond = false;
        private ICollection<PlacePicture> placePictures;

        public Place()
        {
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

        // TODO think what to do
        public ICollection<PlacePicture> GetPlacePictures() {
            return placePictures;
        }

    }
}
