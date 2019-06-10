using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;

namespace Projeto_Final.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult CadastrarAdm(Administrador administrador){
            administrador.Nome = "Administrador";
            administrador.Email = "admin@agoravai.com";
            administrador.Senha = "admin";

            return View("Index", "Aprovação");
        }
    }
}