using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> tonne = new Container<int>(new int[]{0, 5, 2, 4});
            for (int i = 0; i < tonne.MeinArray.Length; i++)
            {
                System.Console.WriteLine(tonne.MeinArray[i]);
            }
        }
    }
}
