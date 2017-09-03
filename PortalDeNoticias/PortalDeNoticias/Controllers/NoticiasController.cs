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
        private List<Noticia> _lista;

        // GET: Noticias
        public ActionResult Index()
        {
            _lista = new Noticia().Listar() ?? new List<Noticia>();
            return View(_lista);
        }
        public ActionResult Detalhes(int id)
        {
            _lista = new Noticia().Listar() ?? new List<Noticia>();

            var noticias = _lista
                                 .Where(c => c.Id == id).FirstOrDefault();
            return View(noticias);
        }
        public ActionResult Buscar(string texto)
        {

            ViewResult retorno;
            _lista = new Noticia().Listar() ?? new List<Noticia>();
            try
            {

                var codigo = Convert.ToInt32(texto);

                _lista.Add(new Noticia().Buscar(codigo));
            }
            catch (Exception)
            {
                _lista = _lista.Where(c => c.Titulo.Contains(texto)
                                          || c.Conteudo.Contains(texto)).ToList();
            }
            finally
            {
                retorno = View(_lista);
            }

            return retorno;

        }

        public ActionResult Novo(Noticia noticia)
        {
            if (!string.IsNullOrEmpty(noticia.Titulo))
                NovaNoticia(noticia);

            return View();
        }

        private void NovaNoticia(Noticia noticia)
        {
            noticia.Salvar();

        }
        public ActionResult Excluir(int id)
        {

            new Noticia().Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {

            var noticia = new Noticia().Buscar(id);
            return View(noticia);
        }
        [HttpPost]
        public ActionResult Editar(Noticia noticia)
        {

            noticia.Salvar();
            return View(noticia);
        }
    }
}