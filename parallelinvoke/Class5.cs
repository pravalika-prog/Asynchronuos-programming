using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Iican
{
    class Class5
    {
        static void Main()
        {
            Parallel.Invoke(
                 NormalAction, 
                 delegate ()    
                 {
                     Console.WriteLine($"Method 2, Thread={Thread.CurrentThread.ManagedThreadId}");
                 },
                () =>   // Invoking a lambda expression
                {
                    Console.WriteLine($"Method 3, Thread={Thread.CurrentThread.ManagedThreadId}");
                }
            );
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        static void NormalAction()
        {
            Console.WriteLine($"Method 1, Thread={Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
