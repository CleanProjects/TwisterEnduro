using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GetData
{
    public class Liczenie : ILiczenie
    {
       


        public double TotalDistance(double l1ltat,double l1lot,double l2lat,double l2lon)
        {   
             
           return    Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);
               
            
         
        }

        public double ClimbingDistance(double l1ltat, double l1lot, double l2lat, double l2lon,double e1, double e2)
        {
            double wynik = 0;
   
                if (e1 < e2)
                {
                    wynik = Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);

                }
              

            return wynik;

        }

        public double DescentDistance(double l1ltat, double l1lot, double l2lat, double l2lon, double e1, double e2)
        {
            
            double wynik = 0;
          

                if (e1 > e2)
                {
                    wynik += Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);

                }

         
            return wynik;
        }

        public double FlatDistance(double l1ltat, double l1lot, double l2lat, double l2lon, double e1, double e2)
        {
            double wynik = 0;
                if (e1 == e2)
                {
                    wynik += Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);

                }
            return wynik;
        }

        public double Speed(double l1ltat, double l1lot, double l2lat, double l2lon, DateTime timeSpan, DateTime timeSpan1)
        {
            double wynik = 0;

            TimeSpan d = TimeSpan.Zero;
            double speed = 0;

            TimeSpan t = timeSpan1 - timeSpan;
            double droga = 0;

            wynik += Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);
            droga = Havershine.HScalculate(l1ltat, l1lot, l2lat, l2lon);

            double p = (t.Hours + t.Minutes / 100.0 + t.Seconds / 10000.0) * (t > TimeSpan.Zero ? 1 : -1);
            //double p = Convert.ToDouble(t);
            speed = droga / p;

            return speed;

        }
      

        public double FinalBalance(double totaldistacne,double distancedescend)
        {


            return (distancedescend / totaldistacne) * 100;
;        }
        public double FinalBalanceFLat(double totaldistacne, double distanceflat)
        {


            return (distanceflat / totaldistacne) * 100;
  ;
        }

        public double FinalBalanceClimb(double totaldistacne, double distanceclimb)
            {

            return (distanceclimb / totaldistacne) * 100; 

        }

        public TimeSpan ClimbingTime(double e1,double e2,DateTime t1,DateTime t2)
        {
           TimeSpan wynik = TimeSpan.Zero;

            if (e1 < e2)
            {
                wynik = t2 - t1;
            }


            return wynik;
        }

        public TimeSpan DescentTime(double e1, double e2, DateTime t1, DateTime t2)
        {
             TimeSpan wynik = TimeSpan.Zero;

            if (e1 > e2)
            {
                wynik = t2 - t1;
            }


            return wynik;
        }

        public TimeSpan FlatTime(double e1, double e2, DateTime t1, DateTime t2)
        {

            TimeSpan wynik = TimeSpan.Zero;

            if (e1 ==e2)
            {
                wynik = t2 - t1;
            }


            return wynik;
        }

    }
}
