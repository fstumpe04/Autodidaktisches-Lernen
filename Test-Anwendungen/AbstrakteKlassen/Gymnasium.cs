namespace AbstrakteKlassen
{
    class Gymnasium : Schule
    {
        public int AnzahlSchueler { get; set; }
        public override void NeuerSchueler()
        {
            AnzahlSchueler += 1;
        }
    }
}