using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Logger.Instance;
            log.SafeToLog("We have started with the introduction to design patters.");
            log.SafeToLog($"Some other events.{Environment.NewLine}");

            var log1 = Logger.Instance;
            log.SafeToLog($"An event from log1 .. mind - Blown!{Environment.NewLine}");

            log.PrintLog();

            var log2 = Logger.Instance;
            log2.SafeToLog($"When we have parallel {Environment.NewLine}");
            log2.PrintLog();

            Parallel.For(0, 6, x => { Logger.Instance.SafeToLog(x.ToString()); });
            Logger.Instance.PrintLog();

        }
    }
}
