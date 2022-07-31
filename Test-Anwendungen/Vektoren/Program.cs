using System;
using System.Windows;

namespace Vektoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1,0,1);
            Vector b = new Vector(0,0,0);
            System.Console.WriteLine(a+b);
        }
    }
}
