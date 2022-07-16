namespace Interfaces
{
    class Website : IBildung
    {
        public int AnzahlSchueler { get; set; }
        public void neuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}