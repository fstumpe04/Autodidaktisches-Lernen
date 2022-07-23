using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MyThread.ThreadProc));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();
        }
    }
}
