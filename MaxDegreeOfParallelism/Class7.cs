using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Iican
{
    class Class7
    {
        static void Main()
        {
            ParallelOptions parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = 3
        };
        



        Parallel.Invoke(
                parallelOptions,
                () => DoSomeTask(1),
                    () => DoSomeTask(2),
                    () => DoSomeTask(3),
                    () => DoSomeTask(4),
                    () => DoSomeTask(5),
                    () => DoSomeTask(6),
                    () => DoSomeTask(7)
                );
            Console.ReadKey();
             }
    static void DoSomeTask(int number)
    {
        Console.WriteLine($"DoSomeTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
        //Sleep for 500 milliseconds
        Thread.Sleep(5000);
        Console.WriteLine($"DoSomeTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
    }
}
}
