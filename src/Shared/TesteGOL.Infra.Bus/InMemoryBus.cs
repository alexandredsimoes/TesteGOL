using MediatR;
using TesteGOL.Domain.Core.Bus;
using TesteGOL.Domain.Core.Commands;
using TesteGOL.Domain.Core.Events;
using System;
using System.Threading.Tasks;

namespace TesteGOL.Shared.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;

        public InMemoryBus(IEventStore eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return Publish(command);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return Publish(@event);
        }

        private Task Publish<T>(T message) where T : Message
        {
            var result  = _mediator.Publish(message);
            return result;
        }
    }
}
