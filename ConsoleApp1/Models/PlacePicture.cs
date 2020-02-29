using System;

namespace Places
{
    public class PlacePicture
    {
        private static readonly String PLACES_PATH = @"C:\Users\W & M\Documents\PROJEKTY\NicePlace\Places\";
        private String text;
        internal Place place;
        private String pictureFileName;

        public string PictureFileName { get; set; }
        public string Text { get; set; }
    }
}