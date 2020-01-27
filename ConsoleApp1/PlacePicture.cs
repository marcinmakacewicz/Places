using System;
using System.IO;
using System.Text;

namespace ConsoleApp1 {
    public class PlacePicture
    {
        private static readonly String PLACES_PATH = @"C:\Users\W & M\Documents\PROJEKTY\NicePlace\Places\";
        private String text;
        internal Place place;
        private String pictureFileName;

        public string PictureFileName { get => pictureFileName; set => pictureFileName = value; }
        public string Text { get => text; set => text = value; }

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