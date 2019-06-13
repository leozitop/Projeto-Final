using System;
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

        public IActionResult Aprovar(IFormCollection form){
            return View();
        }
    }
}