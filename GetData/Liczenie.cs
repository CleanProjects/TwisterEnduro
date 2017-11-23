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

        public void MinimumElevation()
        {
            //najmniejszy element ELE
        }

        public void MaximumElevation()
        {
            //maksymalnyElement ELE
        }

        public void AverageElevation()
        {
            //Wszystkie punkty ELE/ilosc
        }

        public void TotalTrackTime()
        {
            //zsumowany Czas
        }

        public void TotalDescent()
        {
            //wszystkie spadki
        }

        public void FinalBalance()
        {
            //stosunek spadkow do wzrostow
        }

        public void ClimbingTime()
        {
            //czas na wzniesieniach
        }

        public void DescentTime()
        {
            //czas na spadkach
        }

        public void FlatTime()
        {
            //czas na plaskim 
        }

    }
}
