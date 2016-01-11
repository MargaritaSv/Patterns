using System;

namespace SingleFactory
{
    public class LogEvent
    {
        public LogEvent(string msg)
        {
            this.Messages = msg;
            this.EventTime = DateTime.Now;
        }

        public string Messages { get; private set; }

        public DateTime EventTime { get; private set; }
    }
}
