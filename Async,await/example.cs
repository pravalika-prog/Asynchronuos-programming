using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace linq
{
 public   class example
    {
        static async Task  Main()
        {
       var watch=     Stopwatch.StartNew();
          await  startprocess();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
        static  async Task startprocess()
        {
        var T1=  Task.Run(()=> { downladfile1(); });
        var T2= Task.Run(() => { downladfile2(); });
         var T3=   Task.Run(() => { downladfile3(); });
          await Task. WhenAll(T1, T2, T3);
            
        }
    static void downladfile1()
        {
            Thread.Sleep(5000);
            Console.WriteLine("downladfile1");

        }
        static void downladfile2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("downladfile2");
        }
        static void downladfile3()
        {
            Thread.Sleep(5000);
            Console.WriteLine("downladfile3");
        }
    }

}
