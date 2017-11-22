using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GetData
{
    public class Liczenie : ILiczenie
    {
        public double Testowa (List<Values> dane)
        {
            string jk4 = String.Empty;
            double wynik = 0;
            double e = 0;
            double up = 0;
            double down = 0;
            TimeSpan d = TimeSpan.Zero;
            double speed = 0;
            double max = 0;
            double min = 0;
            for (int i = 0; i < dane.Count - 1; i++)
            {

                double speedpop = speed;
                var l1 = dane[i].lat;
                double l1lon = Convert.ToDouble(dane[i].lon.Replace(".", ","));
                double l1lat = Convert.ToDouble(dane[i].lat.Replace(".", ","));
                double l2lon = Convert.ToDouble(dane[i + 1].lon.Replace(".", ","));
                double l2lat = Convert.ToDouble(dane[i + 1].lat.Replace(".", ","));
                double e1 = Convert.ToDouble(dane[i].elevation.Replace(".", ","));
                double e2 = Convert.ToDouble(dane[i + 1].elevation.Replace(".", ","));
                DateTime timeSpan = Convert.ToDateTime(dane[i].timeSpan);
                DateTime timeSpan1 = Convert.ToDateTime(dane[i + 1].timeSpan);
                TimeSpan t = timeSpan1 - timeSpan;
                double droga = 0;
                //   double value = (timeSpan.Hours + timeSpan.Minutes / 100.0 + timeSpan.Seconds / 10000.0) * (timeSpan > TimeSpan.Zero ? 1 : -1);
                wynik += Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);
                droga = Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);
                double p = (t.Hours + t.Minutes / 100.0 + t.Seconds / 10000.0) * (t > TimeSpan.Zero ? 1 : -1);

                speed = droga / p;
                if (speed != speedpop)
                    if (speed > speedpop) { max = speed; } else { min = speed; }
                //   d = dane[i + 1].timeSpan - dane[i].timeSpan;
                if (e1 < e2)
                {
                    up += Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);

                }
                else if (e1 > e2)
                {
                    down += Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);
                }
                else
                {

                }
            }
            wynik = Math.Round(wynik, 2);





            //var lat 2 = pobrana wartosc lat 2
            //var lon 1 = pobrana wartosc lon 1 
            //var lon 2 = pobrana wartosc lon 2 

            //Havershine.HScalculate(lat1, lon1, lat2, lon2)



            return wynik;
            
        }


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

        public double Speed(double l1ltat,double l1lot,double l2lat,double l2lon,DateTime timeSpan,DateTime timeSpan1)
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

       

        public double AverageSpeed(List<Values> dane)
        {
            string jk4 = String.Empty;
            double wynik = 0;

            TimeSpan d = TimeSpan.Zero;
            double speed = 0;
            double max = 0;
            double averagespeed = 0; 

            for (int i = 0; i < dane.Count - 1; i++)
            {

                double speedpop = speed;
                var l1 = dane[i].lat;
                double l1lon = Convert.ToDouble(dane[i].lon.Replace(".", ","));
                double l1lat = Convert.ToDouble(dane[i].lat.Replace(".", ","));
                double l2lon = Convert.ToDouble(dane[i + 1].lon.Replace(".", ","));
                double l2lat = Convert.ToDouble(dane[i + 1].lat.Replace(".", ","));

                DateTime timeSpan = Convert.ToDateTime(dane[i].timeSpan);
                DateTime timeSpan1 = Convert.ToDateTime(dane[i + 1].timeSpan);
                TimeSpan t = timeSpan1 - timeSpan;
                double droga = 0;

                wynik += Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);
                droga = Havershine.HScalculate(l1lat, l1lon, l2lat, l2lon);

                double p = (t.Hours + t.Minutes / 100.0 + t.Seconds / 10000.0) * (t > TimeSpan.Zero ? 1 : -1);

                speed = droga / p;
                averagespeed = speed / dane.Count;

            }

            
            return averagespeed;
        }

       
        public double AverageDescentSpeed(List<Values> dane)
        {
            return 0;
        }

        public double AverageFlatSpeed(List<Values> dane)
        {
            return 0;
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
