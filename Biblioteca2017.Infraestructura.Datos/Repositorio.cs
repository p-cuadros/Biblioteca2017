using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017.Infraestructura.Datos
{
    public class Repositorio : IRepositorio
    {
        BibliotecaContexto ioContexto;
        public Repositorio()
        {
            ioContexto = new BibliotecaContexto();
        }

        public void Adicionar<T>(T aoObjeto) where T : class
        {
            ioContexto.Set<T>().Add(aoObjeto);
        }

        public void GuardarCambios() 
        {
            ioContexto.SaveChanges();
        }

        public IList<T> Listar<T>() where T : class
        {
            return ioContexto.Set<T>().ToList();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLlaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLlaves);
        }
    }
}
