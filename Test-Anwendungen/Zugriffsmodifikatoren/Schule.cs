namespace Zugriffsmodifikatoren
{
    public class Schule
    {
        public string name;
        private int anzahlSchueler;
        public Schule(string name = "", int anzahlSchueler = 0)
        {
            this.name = name;
            this.anzahlSchueler = anzahlSchueler;
        }

        public int getAnzahlSchueler()
        {
            return anzahlSchueler;
        }

        public void setAnzahlSchueler(int anzahlSchueler)
        {
            if (anzahlSchueler >= 0)
            {
                this.anzahlSchueler = anzahlSchueler;
            }
        }
    }
}