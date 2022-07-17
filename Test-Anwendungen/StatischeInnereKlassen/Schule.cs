namespace StatischeInnereKlassen
{
    public class Schule
    {
        public static class Schueler
        {
            public static int alter;
            public static string name;
        }
        public int AnzahlSchueler { get; set; }
        public void NeuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}