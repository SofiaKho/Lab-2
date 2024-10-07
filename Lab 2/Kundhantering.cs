using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    using System;
    using System.Collections.Generic;

    namespace SminkButik
    {
        public class Kundhantering
        {
            private List<Kund> kunder = new List<Kund>();

            public Kundhantering()
            {
                // Laddar fördefinierade kunder
                kunder.Add(new GuldKund("Knatte", "123"));
                kunder.Add(new SilverKund("Fnatte", "321"));
                kunder.Add(new BronsKund("Tjatte", "213"));
            }

            public void RegistreraNyKund()
            {
                Console.WriteLine("Ange ditt namn:");
                string namn = Console.ReadLine();
                Console.Write("Ange lösenord: ");
                string lösenord = Console.ReadLine();

                Console.WriteLine("Välj kundnivå (Bronze, Silver, Gold):");
                string nivåInput = Console.ReadLine().ToLower();

                if (Enum.TryParse(typeof(KundNivå), nivåInput, true, out object result))
                {
                    KundNivå nivå = (KundNivå)result;
                    switch (nivå)
                    {
                        case KundNivå.Guld:
                            kunder.Add(new GuldKund(namn, lösenord));
                            break;
                        case KundNivå.Silver:
                            kunder.Add(new SilverKund(namn, lösenord));
                            break;
                        case KundNivå.Bronze:
                            kunder.Add(new BronsKund(namn, lösenord));
                            break;
                    }
                    Console.WriteLine("Kund registrerad!");
                }
                else
                {
                    Console.WriteLine("Ogiltig nivå, försök igen.");
                }
            }

            public void LoggaIn()
            {
                Console.Write("Ange namn: ");
                string namn = Console.ReadLine();
                Console.Write("Ange lösenord: ");
                string lösenord = Console.ReadLine();

                foreach (var kund in kunder)
                {
                    if (kund.Namn == namn && kund.VerifieraLösenord(lösenord))
                    {
                        Console.WriteLine($"Inloggning lyckades! Välkommen {kund.Namn}");
                        return;
                    }
                }

                Console.WriteLine("Inloggning misslyckades. Kontrollera dina uppgifter.");
            }
        }
    }

}
