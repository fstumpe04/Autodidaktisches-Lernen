using System;

namespace StaticKlassenvariablen
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule kit = new Schule();
            string currentGesetzesgrundlage = kit.getGesetzesgrundlage();
            Console.WriteLine(currentGesetzesgrundlage);
        }
    }
}
