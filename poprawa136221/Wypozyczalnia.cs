using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136221
{
    class Wypozyczalnia:IKoszt
    {
        private int ileWolnych;
        private int ileAut;

        public Wypozyczalnia(int ileWolnych, int ileAut)
        {
            this.ileWolnych = ileWolnych;
            this.ileAut = ileAut;
        }

        public double ObliczKoszt(int parametr)
        {
            if (ileWolnych <= (ileAut / 2)) return parametr * 34;
            else return 734;
        }
    }
}
