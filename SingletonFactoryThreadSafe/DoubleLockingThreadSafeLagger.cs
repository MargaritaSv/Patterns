using System;
using System.Collections.Generic;

namespace SingletonFactoryThreadSafe
{
    public sealed class DoubleLockingThreadSafeLagger
    {
        private static volatile DoubleLockingThreadSafeLagger logger;

        private static object synlock = new object();

        private readonly List<LogEvent> events;

        private DoubleLockingThreadSafeLagger()
        {
            this.events = new List<LogEvent>();
        }

        public static DoubleLockingThreadSafeLagger Instance
        {
            get
            {
                if (logger == null)
                {
                    lock (synlock)
                    {
                        if (logger == null)
                        {
                            logger = new DoubleLockingThreadSafeLagger();
                        }
                    }
                }
                return logger;
            }
        }

        public void SafeToLog(object msg)
        {
            this.events.Add(new LogEvent(msg.ToString()));
        }

        public void PrintLog()
        {
            foreach (var ev in this.events)
            {
                Console.WriteLine("Time: {0}, Event: {1}", ev.EventsTime.ToShortTimeString(), ev.Messages);
            }
        }
    }
}
