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
            var placeAddress = new PlaceAddress("Poland", "Warsaw", "Obywatelska", "5", "02-409");
            IPlace place = new Place();
            place.PlaceId;
            DateTime dateTime = DateTime.Now; 
            PlacePicture placePicture = new PlacePicture(place, dateTime);
        }
    }
}
