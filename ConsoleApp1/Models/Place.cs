using System;
using System.Collections;
using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        private PlaceAddress placeAddress;
        private int diamonds;
        private List<string> placePictures;
        public PlaceType PlaceType { get; set; }

        public int GetDiamonds() => diamonds;

        public void AddDiamond() => diamonds++;

        public void RemoveDiamond() => diamonds--;

        public ICollection GetPlacePictures() { return placePictures; }

        public void AddPlacePicture(PlacePicture picture) {
            placePictures.Add(picture);
    }
}
