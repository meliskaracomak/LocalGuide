using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGuide
{
    class City
    {
        public string CityName { get; set; }
        public string CityRegion { get; set; }
        public string HisPlace { get; set; }

        public string ShowCity()
        {
            return CityName;
        }
    }
}
