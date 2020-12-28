using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Iican
{
    class Class3
    {
        static void Main()
        {
            var BreakSource = System.Linq.Enumerable.Range(0, 1000).ToList();
            int BreakData = 0;
            Console.WriteLine("Using loopstate Break Method");
            Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
            {
                BreakData += i;
                if (BreakData > 100)
                {
                    BreakLoopState.Break();
                    Console.WriteLine("Break called iteration {0}. data = {1} ", i, BreakData);
                }
            });
            Console.WriteLine("Break called data = {0} ", BreakData);
            var StopSource = Enumerable.Range(0, 1000).ToList();
            int StopData = 0;
            Console.WriteLine("Using loopstate Stop Method");
            Parallel.For(0, StopSource.Count, (i, StopLoopState) =>
            {
                StopData += i;
                if (StopData > 100)
                {
                    StopLoopState.Stop();
                    Console.WriteLine("Stop called iteration {0}. data = {1} ", i, StopData);
                }
            }

        Console.WriteLine("Stop called data = {0} ", StopData);
            Console.ReadKey();
        }
}
}
