using System;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Gymnasium g = new Gymnasium();
            g.name = "MeinGymmi";
            g.anzahlSchueler = 400;
            System.Console.WriteLine(g.abschluss);
        }
    }
}
