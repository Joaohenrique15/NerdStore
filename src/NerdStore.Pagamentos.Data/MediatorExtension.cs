﻿using System.Linq;
using System.Threading.Tasks;
using NerdStore.Core.DomainObjects;
using NerdStore.Pagamentos.Data;

namespace NerdStore.Core.Communication.Mediator
{
    public static class MediatorExtension
    {
        public static async Task PublicarEventos(this IMediatorHandler mediator, PagamentoContext ctx)
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.Eventos != null && x.Entity.Eventos.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.Eventos)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.LimparEventos());

            var tasks = domainEvents
                .Select(async (domainEvent) => {
                    await mediator.PublicarEvento(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}