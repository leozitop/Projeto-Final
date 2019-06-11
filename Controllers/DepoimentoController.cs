using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;

namespace Projeto_Final.Controllers
{
    public class DepoimentoController : Controller
    {
        DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        public IActionResult Index(){
            ViewData["NomeView"] = "CadastroDepoimento";
            return View();
        }

        public IActionResult CadastroDepoimento(IFormCollection form){
            Depoimento comentario = new Depoimento();
            comentario.NomeCliente = form["nome"];
            comentario.Comentario = form["comentario"];
            comentario.DataComentario = DateTime.Parse(form["data-comentario"]);

            depoimentoRepositorio.Inserir(comentario);

            ViewData["Action"] = "CadastroDepoimento";
            return View("Index", "Aprovação");
        }
    }
}