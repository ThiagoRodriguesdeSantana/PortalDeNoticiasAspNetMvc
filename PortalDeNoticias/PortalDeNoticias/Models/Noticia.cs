using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }


        public void Salvar()
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                session.Store(this);
                session.SaveChanges();
            }

        }

        public List<Noticia> Listar()
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                return session.Query<Noticia>().ToList();
            }

        }
        public Noticia Buscar(int id)
        {

            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                var find = session.Load<Noticia>(id);
                if (find == null)
                    throw new Exception("Noticia Não encotrada!");
                return find;

            }

        }

        public void Delete(int id)
        {

            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                var news = session.Load<Noticia>(id);

                if (news.Equals(null))
                    throw new Exception("Noticia Não encotrada!");

                session.Delete(news);
                session.SaveChanges();

            }

        }




    }
}