using System;
using Lab_2;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Meny huvudMeny = new Meny(); // Skapar en koppling till Meny-klassen
            huvudMeny.Start(); // Anropar metoden Start() i Meny-klassen som visar menyn för användaren 
        }
    }
}
