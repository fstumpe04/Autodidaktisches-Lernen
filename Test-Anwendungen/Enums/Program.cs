using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(((byte)Richtung.RECHTS));
        }
        enum Richtung
        {
            HOCH, RUNTER, LINKS, RECHTS            
        }
    }
}
