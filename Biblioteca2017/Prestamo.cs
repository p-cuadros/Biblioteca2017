using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017
{
    /// <summary>
    /// Clase que representa el prestamo un Libro
    /// </summary>
    public class Prestamo
    {
        #region PROPIEDADES

        /// <summary>
        /// Representa el número correlativo del prestamo
        /// </summary>
        public int NumeroPrestamo { get; private set; }
        /// <summary>
        /// Representa la fecha del préstamo
        /// </summary>
        public DateTime FechaPrestamo { get; private set; }
        /// <summary>
        /// Representa la fecha de devolución
        /// </summary>
        public DateTime? FechaDevolucion { get; private set; }
        /// <summary>
        /// Representa el código de identificación del libro
        /// </summary>
        public int CodigoLibro { get; private set; }
        /// <summary>
        /// Representa el código de identificación del usuario
        /// </summary>
        public int CodigoUsuario { get; private set; }
        /// <summary>
        /// Representa el Libro relacionado
        /// </summary>
        public virtual Libro Libro { get; private set; }
        /// <summary>
        /// Representa el Usuario relacionado
        /// </summary>
        public virtual Usuario Usuario { get; private set; }

        #endregion

        #region METODOS - completar y comentar
        // CONSTRUCTOR Prestamo
        public Prestamo(Libro xLibro, Usuario xUsuario)
        {
            //Establecer codigo de usuario
            this.CodigoUsuario = xUsuario.CodigoUsuario;
            //Establecer codigo de libro
            this.CodigoLibro = xLibro.CodigoLibro;
            //Establecer fecha de prestamo
            this.FechaPrestamo = DateTime.Today;
            //Establecer clase Libro
            this.Libro = xLibro;
            //Establecer clase Usuario
            this.Usuario = xUsuario;
        
        }



        #endregion

    }
}
