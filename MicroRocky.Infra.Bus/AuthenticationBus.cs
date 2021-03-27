using MediatR;
using MicroRocky.Domain.Core.Bus;
using MicroRocky.Domain.Core.Commands;
using MicroRocky.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRocky.Infra.Bus
{
    //we dont want people to inherit or extending it
    public sealed class AuthenticationBus : IEventBus
    {
        private readonly IMediator _mediator;
        //we use dictionary with list of generic type, so we can use anny type of handler
        //we dont need to create each type of event
        private readonly Dictionary<string, List<Type>> _handlers;
        private readonly List<Type> _eventTypes;

        public AuthenticationBus(IMediator mediator)
        {
            _mediator = mediator;
            _handlers = new Dictionary<string, List<Type>>();
            _eventTypes = new List<Type>();
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            //use Mediator to send a command
            return _mediator.Send(command);
        }

        public void Publish<T>(T @event) where T : Event
        {
            //whoever is using the Publish method send the generic event.
            
        }


        public void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>
        {
            throw new NotImplementedException();
        }
    }
}
