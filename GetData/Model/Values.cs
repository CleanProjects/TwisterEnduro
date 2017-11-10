using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace GetData
{
    public class Values
    {
        public string lon;
        public string lat;
        public string timeSpan;
        public string elevation;
        public Values(string lon, string lat, string timeSpan, string elevation)
        {
            this.timeSpan = timeSpan;
            this.lat = lat;
            this.lon = lon;
            this.elevation = elevation;

        }
        public Values()
        {

        }

        
    }
  
}
