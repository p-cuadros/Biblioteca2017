using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca2017
{
    public class Usuario
    {
        public int CodigoUsuario { get; private set;}

        public string NombreUsuario { get; private set; }

        private Usuario() { }
        public static Usuario Registrar(string asNombreUsuario)
        {
            return new Usuario()
            {
                NombreUsuario = asNombreUsuario
            };
        }
    }
}