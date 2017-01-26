using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136221
{
    abstract class Pojazd : IKoszt
    {
        protected string marka;
        protected string model;
        protected double cenaZaDzien;

        public Pojazd(string marka_ , string model_,double cena_)
        {
            this.marka = marka_;
            this.cenaZaDzien = cena_;
            this.model = model_;
        }

        abstract public double ObliczKoszt(int cos);
   
    }
}
