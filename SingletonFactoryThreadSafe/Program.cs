using System;
using System.Threading.Tasks;

namespace SingletonFactoryThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 6, x => LazyThreadSafeLogger.Instance.SafeToLog(x));
            LazyThreadSafeLogger.Instance.PrintLog();

            Console.WriteLine($"DoubleLockingThreadSafeLagger: {Environment.NewLine}");

            Parallel.For(0, 4, x => DoubleLockingThreadSafeLagger.Instance.SafeToLog(x));
            DoubleLockingThreadSafeLagger.Instance.PrintLog();
        }
    }
}
