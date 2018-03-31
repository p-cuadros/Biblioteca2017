using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca2017
{
    public class Libro
    {
        /// <summary>
        /// Representa el código del libro
        /// </summary>
        public int CodigoLibro { get; set; }
        /// <summary>
        /// Representa el titulo del libro
        /// </summary>
        public string NombreLibro { get; set; }
        /// <summary>
        /// Indica si un libro se encuentra reservado
        /// </summary>
        public bool Reservado { get; set; }
        /// <summary>
        /// Representa la colección de valoraciones asociadas a un libro
        /// </summary>
        public ICollection<Valoracion> Valoraciones { get; private set; }

        private Libro() { }

        /// <summary>
        /// Realiza el cambio de condicion cuando un libro es reservado
        /// </summary>
        public void Reservar()
        {
            Reservado = true;
        }
        /// <summary>
        /// Realiza el cambio de condicion cuando un libro es devuelto
        /// </summary>
        public void Devolver()
        {
            Reservado = false;
        }
        /// <summary>
        /// Realiza la valoración de un Libro
        /// </summary>
        /// <param name="aoUsuario">Instancia de la clase Usuario</param>
        /// <param name="abyValor">Valor de la Valoración realizada por el Usuario</param>
        public void Valorar(Usuario aoUsuario, byte abyValor)
        {
            var valoracion = Valoracion.Crear(this, aoUsuario, abyValor);
            Valoraciones.Add(valoracion);
        }

        public static Libro Registrar(string asTitulo)
        {
            return new Libro()
            {
                NombreLibro = asTitulo
                , Reservado = false
            };
        }
    }
}