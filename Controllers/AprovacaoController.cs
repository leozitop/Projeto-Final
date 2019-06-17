using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;

namespace Projeto_Final.Controllers
{
    public class AprovacaoController : Controller
    {
        DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();

        public IActionResult Index(){
            ViewData["NomeView"] = "Aprovacao";
            return View();
        }

        public List<Depoimento> ListarComentario(Depoimento depoimento){
            List<Depoimento> listaDeComentarios = depoimentoRepositorio.Listar();
            foreach (var item in listaDeComentarios)
            {
                if (item != null)
                {
                    Console.WriteLine($"Nome do Autor: {item.NomeCliente}; Depoimento: {item.Comentario}; data: {item.DataComentario}");
                }
            }
            return View("Index", "Aprovados");
        }
    }
}