using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136221
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pojazd> pojazdy = new List<Pojazd>();

            pojazdy.Add(new Osobowy("opel", "c3", 100, true, true));

            pojazdy.Add(new Autobus("man","c2",120,60));
            pojazdy.Add(new Osobowy("opel1", "c3", 100, true, true));
            pojazdy.Add(new Autobus("man3", "c2", 120, 60));
            pojazdy.Add(new Autobus("man2", "c2", 120, 60));
            pojazdy.Add(new Osobowy("opel2", "c3", 100, true, false));
            pojazdy.Add(new Osobowy("opel3", "c3", 100, false, true));
            pojazdy.Add(new Osobowy("opel4", "c3", 100, false, false));
            pojazdy.Add(new Autobus("man4", "c2", 110, 50));
            pojazdy.Add(new Autobus("man5", "c2", 150, 45));
           


            for (int i = 1; i < pojazdy.Count - 1; i += 2)
            {
                Console.WriteLine(pojazdy[i].ToString());
            }

            for (int i = 0; i < pojazdy.Count - 1; i += 2)
            {
                Console.WriteLine(pojazdy[i].ObliczKoszt(7));
            }
        }
    }
}
