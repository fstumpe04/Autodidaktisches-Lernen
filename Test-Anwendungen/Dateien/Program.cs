using System;
using System.IO;

namespace Dateien
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "meineDatei.txt";
            File.Create(filename);
            File.OpenWrite(filename);
            string[] zeilen = File.ReadAllLines(filename);
            for (int i = 0; i < zeilen.Length; i++)
            {
                System.Console.WriteLine(zeilen[i]);
            }
        }
    }
}
