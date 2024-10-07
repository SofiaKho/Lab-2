using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    namespace SminkButik
    {
        public class Produkt
        {
            public string Namn { get; private set; }
            public decimal Pris { get; private set; }

            public Produkt(string namn, decimal pris)
            {
                Namn = namn;
                Pris = pris;
            }

            public override string ToString()
            {
                return $"{Namn}, Pris: {Pris} SEK";
            }
        }
    }

}
