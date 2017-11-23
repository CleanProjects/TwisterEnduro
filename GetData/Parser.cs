using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetData
{
    public class Parser
    {
        private IData data;
        private ILiczenie liczenie;

        public Parser(IData data, ILiczenie liczenie)
        {
            this.data = data;
            this.liczenie = liczenie;
        }

        public void Liczenie()
        {
            var dane = data.PobierzDane();

            var tmp = dane;
            List<string> listlon = new List<string>();
            List<string> listlat = new List<string>();
            Liczenie l = new Liczenie();
            TimeSpan czasclimb = TimeSpan.Zero;
            TimeSpan czasdescent = TimeSpan.Zero;
            TimeSpan czasdesflat = TimeSpan.Zero;
            double wynik = 0;
            double climb = 0;
            double descent = 0;
            double flat = 0;
            double minspeed = 0;
            double maxspeed = 0;
            double avarangespeed = 0;
            double av = 0;
            double avc = 0;
            int licznik = 0;
            int licznik1 = 0;
            double srclim = 0;
            double avd = 0;
            double drdescent = 0;
            double avf = 0;
            int licznik2 = 0;
            double srflat = 0;
            double wys = 0;
            double maxwys = 0;
            double sumael = 0;
            double srwys = 0;
            int descentcount = 0;
            if (dane != null)
            {
                
                for (int i = 0; i < dane.Count - 1; i++)
                {
                    var l1 = dane[i].lat;
                    double l1lon = Convert.ToDouble(dane[i].lon.Replace(".", ","));
                    double l1lat = Convert.ToDouble(dane[i].lat.Replace(".", ","));
                    double l2lon = Convert.ToDouble(dane[i + 1].lon.Replace(".", ","));
                    double l2lat = Convert.ToDouble(dane[i + 1].lat.Replace(".", ","));
                    double e1 = Convert.ToDouble(dane[i].elevation.Replace(".", ","));
                    double e2 = Convert.ToDouble(dane[i + 1].elevation.Replace(".", ","));
                    DateTime timeSpan = Convert.ToDateTime(dane[i].timeSpan);
                    DateTime timeSpan1 = Convert.ToDateTime(dane[i + 1].timeSpan);
                    wynik += l.TotalDistance(l1lat, l1lon, l2lat, l2lon);
                    if (l.DescentDistance(l1lat, l1lon, l2lat, l2lon, e1, e2) != 0)
                        descentcount++;
                    descent += l.DescentDistance(l1lat, l1lon, l2lat, l2lon, e1, e2);
                    climb += l.ClimbingDistance(l1lat, l1lon, l2lat, l2lon, e1, e2);
                    flat += l.FlatDistance(l1lat, l1lon, l2lat, l2lon, e1, e2);

                    if (minspeed == 0 || minspeed > l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1))
                        minspeed = l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);
                    if (maxspeed == 0 || maxspeed < l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1))
                        maxspeed = l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);

                    av += l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);

                    if (e1<e2)
                    {
                        licznik++;
                        avc += l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);
                    }
                    if (e1>e2)
                    {
                        licznik1++;
                        avd += l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);
                    }
                    if (e1==e2)
                    {
                        licznik2++;
                        avf+= l.Speed(l1lat, l1lon, l2lat, l2lon, timeSpan, timeSpan1);
                    }
                    /// wrzucic do petli
                    if (wys==0||e1<wys)
                wys = e1;
                    if (maxwys == 0 || e1 > maxwys)
                        maxwys = e1;
                    sumael += e1;

                    /// wrzucic do petli 
                    czasclimb += l.ClimbingTime(e1, e2, timeSpan, timeSpan1);
                    czasdescent += l.DescentTime(e1, e2, timeSpan, timeSpan1);
                    czasdesflat += l.FlatTime(e1, e2, timeSpan, timeSpan1);
                }
                double percentflat =l.FinalBalanceFLat (wynik, flat);
              double percentdescent=  l.FinalBalance(wynik, descent);
                double percentclimbing = l.FinalBalance(wynik, climb);
                srwys = sumael / dane.Count - 1;
                avarangespeed = av / dane.Count-2 ;
                srclim = avc / licznik;
                drdescent = avd / licznik1;
                srflat = avf / licznik2;
               DateTime p1 = Convert.ToDateTime(dane.Last().timeSpan);
                DateTime p2 = Convert.ToDateTime(dane.First().timeSpan);
             
                Console.WriteLine("Długość trasy:"+(Math.Round( wynik,2)).ToString());
                Console.WriteLine("Długość podjazdu pod góre:"+Math.Round( climb,2).ToString());
                Console.WriteLine("Długość zjazdu:"+Math.Round(descent,2).ToString());
                Console.WriteLine("Długość równi:"+Math.Round(flat,2).ToString());
                Console.WriteLine("Minimalna prędkośc:"+Math.Round(minspeed,5).ToString());
                Console.WriteLine("Maksymalna prędkość:"+Math.Round(maxspeed,2).ToString());
                Console.WriteLine("Średnia prędkość:"+Math.Round(avarangespeed,2).ToString());
                Console.WriteLine("Średnia prędkość wjazdu: "+Math.Round(srclim,2).ToString());
                Console.WriteLine("Średnia prędkość zjazdu: " + Math.Round(drdescent, 2).ToString());
                Console.WriteLine("Średnia prędkość porównym: " + Math.Round(srflat, 2).ToString());
                Console.WriteLine("Najniższa wysokość:" + wys);
                Console.WriteLine("Najwyższa wysokośc: " + maxwys);
                Console.WriteLine("Średnia wysokość: " + Math.Round(srwys,2));
                Console.WriteLine("Czas trasy:" +  Convert.ToString(p1-p2));
                Console.WriteLine("Ilość spadków: " + descentcount);
                Console.WriteLine("Procent spadów do dl: " + Math.Round(percentdescent, 2) + "%"+ "Procent równin do dl: " + Math.Round(percentflat, 2) + "%"+ "Procent wzniesień do dl:" + Math.Round(percentclimbing, 2) + "%");
                Console.WriteLine("Czas na wzniesieniach: " + czasclimb);
                Console.WriteLine("Czas na zjazdach: " + czasdescent);
                Console.WriteLine("Czas na równym: " + czasdesflat);
            }

            
        }

      
    }
}
