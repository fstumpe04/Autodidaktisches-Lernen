namespace Interfaces
{
    class Website
    {
        public int AnzahlSchueler { get; set; }
        public void neuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}