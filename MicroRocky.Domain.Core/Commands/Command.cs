using MicroRocky.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Domain.Core.Commands
{
    //this is core model, core entity that drives every type of other entities or domain entities
    public abstract class Command:Message
    {
        //the basic property of any command, it has to be sent as some time
        //and only those who inherit from this abstract can set the timestamp
        public DateTime Timestamp { get; protected set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
