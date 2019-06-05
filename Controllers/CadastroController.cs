using System;
using Projeto_Final.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;

namespace Projeto_Final.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index(){
            ViewData[""] = "Cadastro";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form){
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Senha = form["senha"];
            cliente.Telefone = form["telefone"];
            cliente.Cpf = form["cpf"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepositorio.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}