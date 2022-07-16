using System;

namespace Mehrfachvererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule{AnzahlSchueler = 100};
            System.Console.WriteLine(schule.AnzahlSchueler);
            schule.neuerSchueler();
            System.Console.WriteLine(schule.AnzahlSchueler);
            Gymnasium gymnasium = new Gymnasium{AnzahlSchueler = 100};
            System.Console.WriteLine(gymnasium.AnzahlSchueler);
            gymnasium.neuerSchueler();
            System.Console.WriteLine(gymnasium.AnzahlSchueler);
        }
    }
}
