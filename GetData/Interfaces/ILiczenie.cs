using System;
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
        double FinalBalance(double totaldistacne, double distancedescend);
        double FinalBalanceFLat(double totaldistacne, double distanceflat);
        double FinalBalanceClimb(double totaldistacne, double distanceflat);
        TimeSpan ClimbingTime(double e1, double e2, DateTime t1, DateTime t2);
        TimeSpan DescentTime(double e1, double e2, DateTime t1, DateTime t2);
        TimeSpan FlatTime(double e1, double e2, DateTime t1, DateTime t2);


    }
}
