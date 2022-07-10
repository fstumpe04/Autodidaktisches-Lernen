using System;

namespace Zugriffsmodifikatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule kit = new Schule("KIT", 23000);
            kit.setAnzahlSchueler(-100000);
            int anzahlSchueler = kit.getAnzahlSchueler();
        }
    }
}
