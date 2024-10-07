using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    namespace SminkButik
    {
        public class SilverKund : Kund
        {
            public SilverKund(string namn, string lösenord) : base(namn, lösenord) { }

            public override KundNivå Nivå => KundNivå.Silver;

            public decimal Rabatt(decimal total)
            {
                return total * 0.10m; // 10% rabatt
            }
        }
    }

}
