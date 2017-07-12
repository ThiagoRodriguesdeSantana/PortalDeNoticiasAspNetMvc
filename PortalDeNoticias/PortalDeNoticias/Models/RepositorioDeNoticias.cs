using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioDeNoticias
    {
        private static List<Noticia> noticias;
        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticia();
                return noticias;
            }
        }

        private static void CriarNoticia()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Primeira noticia",
                Autor = "Thiago",
                Data = DateTime.Now,
                Conteudo = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Segunda noticia",
                Autor = "Thiago",
                Data = DateTime.Now,
                Conteudo = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore"
            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Terceira noticia",
                Autor = "Thiago",
                Data = DateTime.Now,
                Conteudo = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore"
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Quarta noticia",
                Autor = "Thiago",
                Data = DateTime.Now,
                Conteudo = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore"
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Quinta noticia",
                Autor = "Thiago",
                Data = DateTime.Now,
                Conteudo = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore"
            });
        }
    }
}                                                          