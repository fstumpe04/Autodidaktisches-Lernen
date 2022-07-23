using System.Threading;

namespace Threads
{
    class MyThread
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"ThreadProc: {i}");
            }
            Thread.Sleep(0);
        }
    }
}