using System.Collections.Generic;
using Projeto_Final.Models;

namespace Projeto_Final.ViewModels
{
    public class PedidoViewModel
    {
        public List<Plano> Planos {get;set;}
        public Cliente Cliente {get;set;}
    }
}