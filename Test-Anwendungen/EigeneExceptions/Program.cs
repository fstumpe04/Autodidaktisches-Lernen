using System;

namespace EigeneExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meinArray;
            meinFkt(meinArray);
        }

        static int meinFkt(int[] meinArray)
        {
            if (meinArray.Length == 0)
            {
                throw new MeinFehlerException("Fehler: Array ist leer");
            }
            return meinArray[0];
        }
    }
}
