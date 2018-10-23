using System.Threading.Tasks;
using TesteGOL.Domain.Core.Commands;
using TesteGOL.Domain.Core.Events;

namespace TesteGOL.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}