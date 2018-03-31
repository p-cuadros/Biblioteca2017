using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca2017
{
    public class Valoracion
    {
        public int NumeroValoracion { get; private set; }

        public DateTime FechaValoracion { get; private set; }

        public byte ValorValoracion { get; private set; }

        public int CodigoLibro { get; private set; }

        public int CodigoUsuario { get; private set;}

        public Libro Libro { get; private set; }
        
        /// <summary>
        /// Constructor privado
        /// </summary>
        private Valoracion() { }

        public Usuario Usuario { get; private set; }
        /// <summary>
        /// Genera una nueva instancia de la clase Valoración
        /// </summary>
        /// <param name="aoLibro">Instancia de la clase Libro que se va a valorar</param>
        /// <param name="aoUsuario">Instancia de la clase Usuario que realiza la valoración</param>
        /// <param name="abyValor">Valor de la valoración</param>
        /// <returns>Nuevo objeto Valoración</returns>
        public static Valoracion Crear(Libro aoLibro, Usuario aoUsuario, byte abyValor)
        {
            return new Valoracion()
            {
                FechaValoracion = DateTime.Now,
                ValorValoracion = abyValor,
                Usuario = aoUsuario,
                CodigoUsuario = aoUsuario.CodigoUsuario,
                Libro = aoLibro,
                CodigoLibro = aoLibro.CodigoLibro
            };
        }
    }
}