using System;

namespace Projeto_Final.Models
{
    public class Depoimento
    {
        public ulong Id{get;set;}
        public string NomeCliente{get;set;}
        public string Comentario{get;set;}
        public DateTime DataComentario{get;set;}
    }
}