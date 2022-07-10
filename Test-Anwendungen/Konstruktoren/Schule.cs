namespace Konstruktoren
{
    class Schule
    {
        string name;
        int anzahlSchueler;
        public Schule(string name = "", int anzahlSchueler = 0)
        {
            this.anzahlSchueler = anzahlSchueler;
            this.name = name;
        }
    }
}