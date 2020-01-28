using Modelo.Domain.Core.Commands;
using Modelo.Domain.Core.Events;
using MediatR;
using System.Threading.Tasks;

namespace Modelo.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task PublishCommand<T>(T command) where T : Command;

        Task PublishMessage<T>(T message) where T : Message;

        Task<TResponse> SendCommand<TResponse>(IRequest<TResponse> command);

        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
