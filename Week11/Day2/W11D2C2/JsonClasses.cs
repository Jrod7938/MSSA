using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D2C2 {
    public class Data {
        public DateTime time { get; set; }
        public Values values { get; set; }
    }

    public class Location {
        public double lat { get; set; }
        public double lon { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Root {
        public Data data { get; set; }
        public Location location { get; set; }
    }

    public class Values {
        public double cloudBase { get; set; }
        public double cloudCeiling { get; set; }
        public int cloudCover { get; set; }
        public double dewPoint { get; set; }
        public int freezingRainIntensity { get; set; }
        public double hailProbability { get; set; }
        public int humidity { get; set; }
        public int precipitationProbability { get; set; }
        public double pressureSeaLevel { get; set; }
        public double pressureSurfaceLevel { get; set; }
        public int rainIntensity { get; set; }
        public int sleetIntensity { get; set; }
        public int snowIntensity { get; set; }
        public double temperature { get; set; }
        public double temperatureApparent { get; set; }
        public int uvHealthConcern { get; set; }
        public int uvIndex { get; set; }
        public int visibility { get; set; }
        public int weatherCode { get; set; }
        public int windDirection { get; set; }
        public double windGust { get; set; }
        public double windSpeed { get; set; }
    }


}
