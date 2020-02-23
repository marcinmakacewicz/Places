using System;
using System.IO;
using System.Text;

namespace Places.Models
{
    public class PlacePicture
    {
        private static readonly string PLACES_PATH = @"C:\Users\W & M\Documents\PROJEKTY\NicePlace\Places\";
        private Place place;
        public string PictureFileName { get; set; }
        public string Text { get; set; }

        public void CheckPlaceDirectoryOrCreateIt()
        {
            if (!Directory.Exists(GetFileName()))
            {
                Directory.CreateDirectory(GetPlacePath());
            }
        }

        public String GetPlacePath()
        {
            return PLACES_PATH + place.PlaceType + @"\" + place.PlaceId + @"\";
        }

        public String GetFileName()
        {
            return GetPlacePath() + PictureFileName;
        }

        public PlacePicture(Place myPlace, DateTime timestamp)
        {
            place = myPlace;
            PictureFileName = timestamp.ToString("yyyy-dd-M--HH-mm-ss") + ".txt";
            CheckPlaceDirectoryOrCreateIt();
            String pictureText = timestamp + Environment.NewLine;
            File.WriteAllText(GetFileName(), pictureText, Encoding.UTF8);
            Text = pictureText;
        }
    }
}