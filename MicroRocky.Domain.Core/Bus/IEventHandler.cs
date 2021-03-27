using MicroRocky.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRocky.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler where TEvent: Event// EventHanlder takes in any type of Event
    {
        //Any type of event comes in let's handle that
        Task Handler(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
