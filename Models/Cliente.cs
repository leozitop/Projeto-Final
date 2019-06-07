using System;

namespace Projeto_Final.Models
{
    public class Cliente
    {
        public ulong Id{get;set;}
        public string Nome{get;set;}
        public string Email{get;set;}
        public string Senha{get;set;}
        public DateTime DataNascimento{get;set;}
    }
}