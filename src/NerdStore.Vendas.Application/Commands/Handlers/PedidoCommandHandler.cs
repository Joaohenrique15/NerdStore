using MediatR;
using NerdStore.Core.DomainObjects.Messages;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Commands.Handlers
{
    public class PedidoCommandHandler : IRequestHandler<AdicionarItemPedidoCommand, bool>
    {
        public async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            return true;
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                //TODO lançar evento de erro
            }

            return false;
        }
    }
}
