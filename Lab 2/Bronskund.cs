using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    namespace SminkButik
    {
        public class BronsKund : Kund
        {
            public BronsKund(string namn, string lösenord) : base(namn, lösenord) { }

            public override KundNivå Nivå => KundNivå.Brons;

            public decimal Rabatt(decimal total)
            {
                return total * 0.05m; // 5% rabatt
            }
        }
    }

}
