namespace Interfaces
{
    class Schule : IBildung
    {
        public int AnzahlSchueler { get; set; }
        public void neuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}