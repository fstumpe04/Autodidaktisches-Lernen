using System;

namespace Super
{
    class Program
    {
        static void Main(string[] args)
        {
            Gymnasium g = new Gymnasium {anzahlSchueler = 100};
            Schule g2 = g;
            Gymnasium g3 = (Gymnasium)g2;
            g2.neuerSchueler();
            System.Console.WriteLine(g2.anzahlSchueler);
            g3.hasGrundschulabschluss = false;
            g3.neuerSchueler();
            System.Console.WriteLine(g3.anzahlSchueler);
            g3.vipKid();
            System.Console.WriteLine(g3.anzahlSchueler);
        }
    }
}
