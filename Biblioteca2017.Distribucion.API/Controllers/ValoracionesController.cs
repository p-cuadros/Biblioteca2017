using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Biblioteca2017.Distribucion.API.Controllers
{
    public class ValoracionesController : ApiController
    {
        // GET: api/Valoraciones
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Valoraciones/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Valoraciones
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Valoraciones/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Valoraciones/5
        public void Delete(int id)
        {
        }
    }
}
