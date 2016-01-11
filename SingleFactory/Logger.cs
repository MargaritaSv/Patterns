using System;
using System.Collections.Generic;

namespace SingleFactory
{
    public sealed class Logger
    {
        private static Logger loggerInstance;

        private readonly List<LogEvent> events = new List<LogEvent>();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (loggerInstance == null)
                {
                    loggerInstance = new Logger();
                }

                return loggerInstance;
            }
        }

        public void SafeToLog(string msg)
        {
            this.events.Add(new LogEvent(msg));
        }

        public void PrintLog()
        {
            foreach (var ev in this.events)
            {
                Console.WriteLine("Time {0} ,Event {1}", ev.EventTime.ToShortTimeString(), ev.Messages);
            }
        }
    }
}
