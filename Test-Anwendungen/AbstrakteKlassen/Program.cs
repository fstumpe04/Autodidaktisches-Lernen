using System;

namespace AbstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Gymnasium gymnasium = new Gymnasium{AnzahlSchueler = 100};
            gymnasium.ZeigeAnzahlSchueler();
            gymnasium.NeuerSchueler();
            gymnasium.ZeigeAnzahlSchueler();
        }
    }
}
