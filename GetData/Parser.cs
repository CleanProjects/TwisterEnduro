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
            
            if (dane != null)
            {




           Console.WriteLine(     l.TotalDistance(dane));
                Console.WriteLine(l.ClimbingDistance(dane));
                Console.WriteLine(l.DescentDistance(dane));
                Console.WriteLine(l.FlatDistance(dane));
                Console.WriteLine(l.MinimumSpeed(dane));
                Console.WriteLine(l.MaximumSpeed(dane));
                Console.WriteLine(l.AverageSpeed(dane));
                Console.WriteLine(l.AverageClimbingSpeed(dane));





            }

            
        }

        public void Liczenie2()
        {
            var dane = data.PobierzDane();

            var tmp = dane;

            List<Data> listalat = new List<Data>();
          

            if (dane != null)

                foreach (var x in listalat)
                {

                    

                }
            
        }
    }
}
