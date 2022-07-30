using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meinArray = {1,2};
            try
            {
                System.Console.WriteLine(meinArray[2]);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
            }
            finally
            {
                System.Console.WriteLine("hallo");
            }
        }
    }
}
