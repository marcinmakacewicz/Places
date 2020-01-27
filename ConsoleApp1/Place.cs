using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Place
    {
        private String placeId;
        private String name;
        private PlaceType placeType;
        private PlaceAddress placeAddress;
        private int diamonds;
        private ArrayList placePictures;

        public Place(String name, PlaceType type, PlaceAddress address)
        {
            PlaceName = name;
            PlaceId = PlaceName + address.GetPlaceAddress();
            PlaceType = type;
            diamonds = 0;
            placePictures = new ArrayList();
        }

        public string PlaceId
        {
            get => placeId;
            set => placeId = string.Format("{0}_{1:N}", value, Guid.NewGuid());
        }
        public string PlaceName { get => name; set => name = value; }

        public PlaceType PlaceType { get => placeType; set => placeType = value; }

        public int GetDiamonds() => diamonds;

        public void AddDiamond() => diamonds++;

        public void RemoveDiamond() => diamonds--;

        public ICollection GetPlacePictures() { return placePictures; }

        public void AddPlacePicture(PlacePicture picture) => placePictures.Add(picture);
    }
}
