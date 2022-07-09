using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule youtube = new Schule();
            youtube.name = "The Morpheus Tutorials";
            youtube.anzahlSchueler = 13000;
            youtube.neuerSchueler();
            System.Console.WriteLine(youtube.anzahlSchueler);
        }
    }
}
