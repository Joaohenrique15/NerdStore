﻿using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoItemAdicionadoEvent : Event
    {
        public PedidoItemAdicionadoEvent(Guid clientId, Guid pedidoId, Guid produtoId, string nomeProduto, decimal valorUnitario, int quantidade) 
        {
            AggregateId = pedidoId;
            ClientId = clientId;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            NomeProduto = nomeProduto;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }

        public Guid ClientId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }

    }
}
