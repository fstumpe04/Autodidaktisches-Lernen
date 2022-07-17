using System;

namespace InnereKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule();
            schule.neuerSchueler("Hans", 15);
            Schule.Schueler schueler = new Schule.Schueler();
            schueler.anKursTeilnehmen();
        }
    }
}
