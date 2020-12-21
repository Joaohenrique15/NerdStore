﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalago.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Mediator;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Application.Commands.Handlers;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            //Vendas
            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
        }
    }
}
