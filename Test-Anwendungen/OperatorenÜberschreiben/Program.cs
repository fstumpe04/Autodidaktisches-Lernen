using System;

namespace OperatorenÜberschreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new {real = 4, imaginär = 4};
            Complex b = new {real = 4, imaginär = 4};
            Complex c = a + b;
            System.Console.WriteLine(c.real);
            System.Console.WriteLine(c.imaginär);
        }
    }
}
