using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Duration);
        }
    }
}
