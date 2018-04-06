using Biblioteca2017.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Biblioteca2017.Distribucion.API.Controllers
{
    public class LibrosController : ApiController
    {
        IRepositorio irLibros;

        public LibrosController()
        {
            irLibros = new Repositorio();
        }
        // GET: api/Libros
        public IEnumerable<Libro> Get()
        {
            return irLibros.Listar<Libro>().ToList();
        }

        // GET: api/Libros/5
        public Libro Get(int id)
        {
            return irLibros.ObtenerPorCodigo<Libro>(id);
        }

        // POST: api/Libros
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Libros/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Libros/5
        public void Delete(int id)
        {
        }
    }
}
