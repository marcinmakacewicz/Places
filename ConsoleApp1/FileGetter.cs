using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places
{
    class FileGetter
    {
        private String filePath;
        private String fileName;
        private Place place;

        public void CreateDirectory()
        {
            if (!DirectoryExists())
            {
                Directory.CreateDirectory(GetPlacePath());
            }
        }

        private bool DirectoryExists()
        {
            return Directory.Exists(GetFileName());
        }

        public String GetPlacePath()
        {
            return filePath + @"\" + place.PlaceId + @"\";
        }

        public String GetFileName()
        {
            return GetPlacePath() + fileName;
        }

    }
}
