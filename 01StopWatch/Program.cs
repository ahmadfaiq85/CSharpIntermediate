using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private bool _running { get; set; }
        private DateTime _startTime { get; set; }
        private DateTime _endTime { get; set; }

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("The Stop Watch is already running.");

            Console.WriteLine("Started.");
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            Console.WriteLine("Stopped.");
            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan Duration
        {
            get
            {
                if (_startTime == null || _endTime == null)
                    throw new InvalidOperationException("Stop Watch must first run and stop to get duration.");

                return _endTime - _startTime; 
            }
        }
    }
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
