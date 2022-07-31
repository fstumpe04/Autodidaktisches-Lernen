using System;

namespace Zufall
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i = random.Next(1, 6);
            System.Console.WriteLine(i);
            double f = random.NextDouble();
            System.Console.WriteLine(f);
            double result = Math.Ceiling(f)/100;
            System.Console.WriteLine(result);
            result = Math.Floor(f)/100;
            System.Console.WriteLine(result);
            result = Math.Round(f)/100;
            System.Console.WriteLine(result);
        }
    }
}
