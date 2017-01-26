using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136221
{
    class Osobowy : Pojazd
    {
        private bool klimatyzacja;
        private bool kombi;

        public Osobowy(string marka_, string model_, double cena_,bool klima_,bool kombi_) : base (marka_, model_, cena_)
        {
            this.marka = marka_;
            this.cenaZaDzien = cena_;
            this.model = model_;
            this.klimatyzacja = klima_;
            this.kombi = kombi_;
        }

        public override string ToString()
        {
            return "Osobowy,\nmarka: " + marka + ", model: " + model + ", cena za dzien: " + cenaZaDzien + ", klimatyzacja: " + (klimatyzacja ? "tak" : "nie") + ", kombi" + (kombi ? "tak" : "nie");
        }

        public override double ObliczKoszt(int cos)
        {
            if (!klimatyzacja && !kombi)
            {
                return 136221 / 100 + cenaZaDzien;
            }
            if (kombi)
            {
                return 136221 / 100 + cenaZaDzien * cos;
            }
            else return 500;
        }
    }
}
