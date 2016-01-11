using System;

namespace SingletonFactoryThreadSafe
{
    public class LogEvent
    {
        public LogEvent(string msg)
        {
            this.Messages = msg;
            this.EventsTime = DateTime.Now;
        }

        public string Messages { get; private set; }

        public DateTime EventsTime { get; private set; }
    }
}
