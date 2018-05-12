using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// representa al repositorio principal
/// </summary>
namespace Biblioteca2017
{
    /// <summary>
    /// clase que representa un usuario
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// representa el codigo del usuario
        /// </summary>
        public int CodigoUsuario { get; private set;}

        /// <summary>
        /// representa el nombre del usuario
        /// </summary>

        public string NombreUsuario { get; private set; }

        /// <summary>
        /// es un constructor usuario de tipo privado
        /// </summary>

        private Usuario() { }

        /// <summary>
        /// es un constructor usuario de tipo publico
        /// </summary>
        /// <param name="asNombreUsuario">instancia de nombre usuario  </param>
        /// <returns></returns>
        public static Usuario Registrar(string asNombreUsuario)
        {
            
            return new Usuario()
            {
                NombreUsuario = asNombreUsuario
            };
        }
    }
}