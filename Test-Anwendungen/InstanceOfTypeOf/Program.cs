using System;

namespace InstanceOfTypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule schule = new Schule();
            Gymnasium gymnasium = new Gymnasium();
            if (gymnasium is Schule)
            {
                System.Console.WriteLine($"{gymnasium} ist eine Instance von Schule");
            }

            if (gymnasium.GetType() == typeof(Schule))
            {
                System.Console.WriteLine($"{gymnasium} ist ein Typ von Schule");
            }
        }
    }
}
