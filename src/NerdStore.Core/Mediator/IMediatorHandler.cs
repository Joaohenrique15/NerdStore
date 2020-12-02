using NerdStore.Core.DomainObjects.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
