using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Domain.Core.Events
{
    //this is base entity; it doesnt really implement or extent anything
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        public Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
