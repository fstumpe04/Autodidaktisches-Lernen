using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule {AnzahlSchueler = 100};
            System.Console.WriteLine(schule.AnzahlSchueler);
            schule.neuerSchueler();
            System.Console.WriteLine(schule.AnzahlSchueler);
            Website website = new Website {AnzahlSchueler = 100};
            System.Console.WriteLine(website.AnzahlSchueler);
            website.neuerSchueler();
            System.Console.WriteLine(website.AnzahlSchueler);
        }
    }
}
