using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136221
{
    class Autobus : Pojazd
    {
        private int liczbaMiejsc;

        public Autobus(string marka_,string model,double cena,int miejsca) : base (marka_, model, cena)
        {
            this.cenaZaDzien = cena;
            this.liczbaMiejsc = miejsca;
            this.marka = marka_;
            this.model = model;
        }

        public override string ToString()
        {
            return "Autobus,\nmarka: " + marka + ", model: " + model + ", cena za dzien: " + cenaZaDzien + ", ilosc miejsc: " + liczbaMiejsc;
        }
        public override double ObliczKoszt(int cos)
        {
            if (liczbaMiejsc > 50)
            {
                cos *= 100;
            }
            else
            {
                cenaZaDzien *= cos;
            }
            return 0; 
        }
    }
}
