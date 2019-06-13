using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final.Models;
using Projeto_Final.Repositorios;

namespace Projeto_Final.Controllers
{
    public class AdministradorController : Controller
    {

        // private const string SESSION_EMAIL = "_EMAIL";
        // private const string SESSION_ADM = "_ADM";


        [HttpGet]
        public IActionResult Login(){
            return View("Index", "Aprovacao");
        }

        // [HttpPost]
        // public IActionResult Login(IFormCollection form){
        //     var adm = form["email"];
        //     var senha = form["senha"];

        //     var administrador = administradorRepositorio.ObterPor(adm);

        //     if (adm.Equals("admin@agoravai.com") && senha.Equals("admin"))
        //     {
        //         return RedirectToAction("Index", "Aprovacao");
        //     }else{
        //         return null;
        //     }
        //     if (administrador != null && administrador.Email.Equals(adm) && administrador.Senha.Equals(senha))
        //     {
        //         HttpContext.Session.SetString(SESSION_EMAIL, adm);
        //         HttpContext.Session.SetString(SESSION_ADM, administrador.Nome);
        //         return RedirectToAction("Index", "Depoimento");
        //     }else
        //     {
        //         return View("Falha");
        //     }

            
        // }

        // public IActionResult Logout(){
        //     HttpContext.Session.Remove(SESSION_EMAIL);
        //     HttpContext.Session.Remove(SESSION_ADM);
        //     HttpContext.Session.Clear();

        //     return RedirectToAction("Index", "Home");
        // }
    }
}