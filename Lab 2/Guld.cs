using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    namespace SminkButik
    {
        public class GuldKund : Kund
        {
            public GuldKund(string namn, string lösenord) : base(namn, lösenord) { }

            public override KundNivå Nivå => KundNivå.Guld;

            public decimal Rabatt(decimal total)
            {
                return total * 0.15m; // 15% rabatt
            }
        }
    }

}
