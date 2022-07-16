namespace AbstrakteKlassen
{
    abstract class Schule
    {
        public int AnzahlSchueler { get; set; }
        public abstract void NeuerSchueler();
        public void ZeigeAnzahlSchueler()
        {
            System.Console.WriteLine($"Die aktuelle Schueleranzahl lautet {AnzahlSchueler}");
        }
    }
}