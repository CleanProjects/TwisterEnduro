﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GetData
{
    public interface ILiczenie
    {
       
        double TotalDistance(double l1ltat, double l1lot, double l2lat, double l2lon);
        double ClimbingDistance(double l1ltat, double l1lot, double l2lat, double l2lon,double e1,double e2);
        double DescentDistance(double l1ltat, double l1lot, double l2lat, double l2lon, double e1, double e2);
        double FlatDistance(double l1ltat, double l1lot, double l2lat, double l2lon, double e1, double e2);        
        double Speed(double l1ltat, double l1lot, double l2lat, double l2lon, DateTime timeSpan, DateTime timeSpan1);
        void MinimumElevation();
        void MaximumElevation();
        void AverageElevation();
        void TotalTrackTime();
        void TotalDescent();
        void FinalBalance();
        void ClimbingTime();
        void DescentTime();
        void FlatTime();
        
    }
}
