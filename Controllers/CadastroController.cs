using System;
using Projeto_Final.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;

namespace Projeto_Final.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private AdministradorRepositorio administradorRepositorio = new AdministradorRepositorio();
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form){
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Senha = form["senha"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            Administrador administrador = new Administrador();
            administrador.Nome = "Administrador";
            administrador.Email = "admin@agoravai.com";
            administrador.Senha = "admin";

            clienteRepositorio.Inserir(cliente);
            administradorRepositorio.Inserir(administrador);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}