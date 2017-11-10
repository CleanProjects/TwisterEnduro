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

            if (dane !=null)
            {
                foreach (var item in dane)
                {
                    liczenie.WyliczDroge();
                }
            }
        }
    }
}
