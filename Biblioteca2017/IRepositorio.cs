using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017
{
    public interface IRepositorio
    {
        T ObtenerPorCodigo<T>(params object[] aoLlaves) where T : class;
        IQueryable<T> Listar<T>() where T : class;
        void Adicionar<T>(T aoObjeto) where T : class;
        void GuardarCambios();
    }
}
