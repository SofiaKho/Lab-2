using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    using System;

    namespace SminkButik
    {
        public abstract class Kund
        {
            public string Namn { get; private set; }
            public string Lösenord { get; private set; }

            protected Kund(string namn, string lösenord)
            {
                Namn = namn;
                Lösenord = lösenord;
            }

            public bool VerifieraLösenord(string lösenord)
            {
                return Lösenord == lösenord;
            }

            public abstract KundNivå Nivå { get; }

            public override string ToString()
            {
                return $"Kund: {Namn}, Nivå: {Nivå}";
            }
        }
    }

}
