using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places
{
    public class Restaurant : Place
    {
        public Restaurant(string PlaceName, PlaceAddress PlaceAddress)
            : base(PlaceName, PlaceAddress)
        {
        }
    }
}
