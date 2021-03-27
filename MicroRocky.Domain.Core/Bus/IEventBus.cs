using MicroRocky.Domain.Core.Commands;
using MicroRocky.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRocky.Domain.Core.Bus
{
    public interface IEventBus
    {
        /***Explaination
         * Sendcommand can take any type of command
         * Use medatr to send command to the Bus
         * 
         * We can Publish any type of event where restriction is type Event
         * 
         * We want services to Subscribe to event
         */
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;
    }
}
