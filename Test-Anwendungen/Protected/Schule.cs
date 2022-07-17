namespace Protected
{
    protected class Schule
    {
        public int AnzahlSchueler { get; set; }
        public void NeuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}