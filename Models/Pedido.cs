using System;

namespace Projeto_Final.Models
{
    public class Pedido
    {
        public ulong Id{get;set;}
        public Cliente Cliente{get;set;}
        public Produto Produto{get;set;}
        public DateTime DataPedido{get;set;}
        public double PrecoTotal{get;set;}
    }
}