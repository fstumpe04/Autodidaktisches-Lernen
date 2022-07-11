using System;

namespace TypeCasts
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule youtube = new Schule();
            Gymnasium g = new Gymnasium();
            Schule g2 = g;
            Gymnasium g3 = (Gymnasium)g2;
            Schule[] schulen = {youtube, g, g2, g3};
            foreach (var item in schulen)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
