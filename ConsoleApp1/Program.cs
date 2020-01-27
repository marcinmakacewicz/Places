using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaceAddress placeAddress = new PlaceAddress("Poland", "Warsaw", "Obywatelska", "5", "02-409");
            Place place = new Place("105-tka", PlaceType.RESTAURANT, placeAddress);
            DateTime dateTime = DateTime.Now; 
            PlacePicture placePicture = new PlacePicture(place, dateTime);
        }
    }
}
