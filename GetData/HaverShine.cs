﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GetData
{
    public static class Havershine
    {
        public static double HScalculate(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6372.8; // In kilometers
            var dLat = HStoRadians(lat2 - lat1);
            var dLon = HStoRadians(lon2 - lon1);
            lat1 = HStoRadians(lat1);
            lat2 = HStoRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Asin(Math.Sqrt(a));
            return R * 2 * Math.Asin(Math.Sqrt(a));
        }

        public static double HStoRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

