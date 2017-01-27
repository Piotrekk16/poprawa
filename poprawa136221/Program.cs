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
            
            
            //kod z polecenie 7
            Wypozyczalnia w1 = new Wypozyczalnia(23, 45);
            Wypozyczalnia w2 = new Wypozyczalnia(3424, 23332);
            Wypozyczalnia w3 = new Wypozyczalnia(11, 323);
            Console.WriteLine(w1.ObliczKoszt(34));
            Console.WriteLine(w2.ObliczKoszt(34));
            Console.WriteLine(w3.ObliczKoszt(34));
            

            //kod z polecenia 9
            pojazdy.Sort();
            foreach(var element in pojazdy)
            {
                Console.WriteLine(element.ToString());
            }

            //kod z polecenia 10
            Stack<Pojazd> pojazdy2 = new Stack<Pojazd>(pojazdy);
            foreach (var element in pojazdy2)
            {
                Console.WriteLine(element.ToString());
            }

            Console.ReadKey();
        }
    }
}
