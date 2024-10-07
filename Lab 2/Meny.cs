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
        public class Meny
        {
            private Kundhantering kundhantering = new Kundhantering();

            public void Start()
            {
                while (true)
                {
                    Console.WriteLine("1. Registrera ny kund");
                    Console.WriteLine("2. Logga in");
                    Console.WriteLine("3. Avsluta");
                    string val = Console.ReadLine();

                    switch (val)
                    {
                        case "1":
                            kundhantering.RegistreraNyKund();
                            break;
                        case "2":
                            kundhantering.LoggaIn();
                            break;
                        case "3":
                            return; // Avslutar programmet
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            break;
                    }
                }
            }
        }
    }

}
