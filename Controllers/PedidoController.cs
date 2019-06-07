using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositories;
using Projeto_Final.Repositorios;
using Projeto_Final.ViewModels;

namespace Projeto_Final.Controllers
{
    public class PedidoController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();
        PlanoRepositorio planoRepositorio = new PlanoRepositorio();
        
        [HttpGet]
        public IActionResult Index()
        {
            var planos = planoRepositorio.Listar();
            var cliente = clienteRepositorio.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));
            
            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Planos = planos;
            pedido.Cliente = cliente == null ? new Cliente() : cliente;

            return View(pedido);
        }


        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];

            Plano plano = new Plano(
            Nome: form["plano"],
            Preco: planoRepositorio.ObterPrecoDe(form["plano"])
            );

            pedido.Cliente = cliente;
            pedido.Produto = plano;
            pedido.PrecoTotal = pedido.Produto.Preco;
            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Controller"] = "Pedido";

            return View("Sucesso");
        }
    }
}