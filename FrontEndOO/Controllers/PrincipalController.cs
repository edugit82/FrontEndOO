using FrontEndOO.FrontEnd;
using FrontEndOO.FrontEnd.Principal.Corpo;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FrontEndOO.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public string PaginaIndex()
        {
            return "<script id='paginaindex'>" + new PaginaPrincipal().MontaPagina() + "</script>";            
        }
        
        [HttpGet]
        public string PaginaBotoes()
        {
            return "<script id='botoes_exemplo'>" + new PaginaBotoes().MontaPagina() + "</script>";
        }

        [HttpGet]
        public string PaginaContainers()
        {
            return "<script id='containers_exemplo'>" + new PaginaContainers().MontaPagina() + "</script>";
        }
    }
}
