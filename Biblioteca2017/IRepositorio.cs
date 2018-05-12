using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017
{
    public interface IRepositorio
    {
        /// <summary>
        /// consulta para obtener por codigos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aoLlaves"></param>
        /// <returns></returns>
        T ObtenerPorCodigo<T>(params object[] aoLlaves) where T : class;
        /// <summary>
        /// este es un objeto para ejecutar
        /// </summary>
        /// <typeparam name="T"> valor con la que se obtendra  los codigos</typeparam>
        /// <returns>wqwqw</returns>

        IQueryable<T> Listar<T>() where T : class;
        /// <summary>
        /// este es una array para listar
        /// </summary>
        /// <typeparam name="T">es una clase donde recibe tosos los datos</typeparam>
        /// <param name="aoObjeto">instancia de un libro que se va a valorar</param>
        void Adicionar<T>(T aoObjeto) where T : class;
        /// <summary>
        /// este es un array adicionar con el valor t que es una clase
        /// </summary>
        void GuardarCambios();
        
        ///este es un metodo para guardar cambios
    }
}
