using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {                                                 
            return View(RepositorioDeNoticias.Noticias);
        }
        public ActionResult Detalhes(int id)
        {
            var noticias = RepositorioDeNoticias.Noticias
                                 .Where(c => c.Id == id).FirstOrDefault();
            return View(noticias);
        }
        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioDeNoticias.Noticias
                                 .Where(c => c.Titulo.Contains(texto) 
                                          || c.Conteudo.Contains(texto)).ToList();
            return View(noticias);
        }

    }
}