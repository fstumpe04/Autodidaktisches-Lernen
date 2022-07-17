namespace InnereKlassen
{
    class Schule
    {
        public class Schueler
        {
            public int Alter { get; set; }
            public string Name { get; set; }
            public void anKursTeilnehmen()
            {
                System.Console.WriteLine(Name);
            }
        }
        protected int anzahlSchueler;
        public void neuerSchueler(string name, int alter)
        {
            this.anzahlSchueler += 1;
            Schueler hans = new Schueler{Alter = alter, Name = name};
            hans.anKursTeilnehmen();
        }
    }
}