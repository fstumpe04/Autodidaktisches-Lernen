namespace ÜberschreibenVonMethoden
{
    class Gymnasium : Schule
    {
        private bool hasSchueler;

        public bool HasSchueler{get; set;}

        public Gymnasium()
        {
            HasSchueler = false;
        }

        public void neuerSchueler()
        {
           if (HasSchueler)
           {
                anzahlSchueler += 1;
           } 
        }
    }   
}