using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Repositories;

namespace Projeto_Final.Controllers
{
    public class ClienteController
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        [HttpGet]
        // public IActionResult Login(){
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult Login(){
        //     var usuario = form["email"];
        //     var senha = form["senha"];

        //     var usuario = clienteRepositorio.ObterPor(cliente);

        //     if (true)
        //     {
                
        //     }
        // }
    }
}