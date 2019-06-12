using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;

namespace Projeto_Final.Controllers
{
    public class AdministradorController : Controller
    {
        private AdministradorRepositorio administradorRepositorio = new AdministradorRepositorio();

        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_ADM = "_ADM";


        [HttpGet]
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form){
            var adm = form["email"];
            var senha = form["senha"];

            var administrador = administradorRepositorio.ObterPor(adm);

            if (administrador != null && administrador.Email.Equals(adm) && administrador.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, adm);
                HttpContext.Session.SetString(SESSION_ADM, administrador.Nome);
            }

            return RedirectToAction("Index", "Aprovacao");
        }

        public IActionResult Logout(){
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_ADM);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}