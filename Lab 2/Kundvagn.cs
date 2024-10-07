using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    using System.Collections.Generic;

    namespace SminkButik
    {
        public class Kundvagn
        {
            private List<Produkt> produkter = new List<Produkt>();

            public void LäggTillProdukt(Produkt produkt)
            {
                produkter.Add(produkt);
            }

            public decimal TotalPris()
            {
                decimal total = 0;
                foreach (var produkt in produkter)
                {
                    total += produkt.Pris;
                }
                return total;
            }

            public void VisaProdukter()
            {
                foreach (var produkt in produkter)
                {
                    System.Console.WriteLine(produkt.ToString());
                }
                System.Console.WriteLine($"Totalt pris: {TotalPris()} SEK");
            }
        }
    }

}
