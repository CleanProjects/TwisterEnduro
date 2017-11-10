using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GetData
{
    public class Data : IData
    {
        public List<Values> PobierzDane()
        {
            XDocument doc = XDocument.Load("C:\\twister.gpx");
            XNamespace gpx = XNamespace.Get("http://www.topografix.com/GPX/1/1");
//
            return doc.Descendants(gpx + "trkpt")
                    .Select(x => new Values(x.Attribute("lon").Value, x.Attribute("lat").Value, x.Element(gpx + "time").Value, x.Element(gpx + "ele").Value)).ToList();
        }
    }
}
