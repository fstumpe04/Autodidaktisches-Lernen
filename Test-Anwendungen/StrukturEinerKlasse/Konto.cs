namespace StrukturEinerKlasse
{
    class Konto
    {
        #region Attribute
        private int _guthabenVonKonto;
        private string _inhaber;
        #endregion

        #region Statisch
        public static double PI;

        private static int kontostand;
        #endregion

        #region Konstruktor
        public Konto()
        {
            _guthabenVonKonto = 0;
            _inhaber = "Anonym";
        }

        public Konto(int guthabenVonKonto, string inhaber)
        {
            _guthabenVonKonto = guthabenVonKonto;
            _inhaber = inhaber;
        }
        #endregion

        #region Methoden
        public void ueberweisung(int betrag){}
        private void anonymeUeberweisung(int betrag){}
        #endregion

        #region Properties
        public int GuthabenVonKonto { get => _guthabenVonKonto; set => _guthabenVonKonto = value; }
        public string Inhaber { get => _inhaber; set => _inhaber = value; }
        #endregion
    }
}