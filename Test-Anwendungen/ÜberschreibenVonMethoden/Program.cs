using System;

namespace ÜberschreibenVonMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Gymnasium g = new Gymnasium();
            Schule meineSchule = g;
            Gymnasium g2 = new Gymnasium();
            Schule[] meineSchulen = {g, meineSchule, g2};
            foreach (var item in meineSchulen)
            {
                item.neuerSchueler();
                System.Console.WriteLine(item.anzahlSchueler);
            }
        }
    }
}
