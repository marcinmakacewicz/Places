using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places
{
    public class PlaceAddress
    {
        public String PostCode { get; set; }
        public String Number { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

        

        public String GetPlaceAddress()
        {
            return Country + City + Street + Number + PostCode;
        }

        
    }
}
