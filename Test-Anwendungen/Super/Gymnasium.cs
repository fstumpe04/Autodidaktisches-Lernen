namespace Super
{
    class Gymnasium : Schule
    {
        public bool hasGrundschulabschluss = false;
        public new void neuerSchueler()
        {   
            if (hasGrundschulabschluss)
            {
                anzahlSchueler += 1;
            }
        }

        public void vipKid()
        {
            base.neuerSchueler();
        }
    }
}