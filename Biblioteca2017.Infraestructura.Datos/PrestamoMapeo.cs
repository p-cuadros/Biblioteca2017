using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017.Infraestructura.Datos
{

    public class PrestamoMapeo : EntityTypeConfiguration<Prestamo>
    { 
        /// <summary>
    /// Relaciona la entidad Prestamo con la tabla ZZZZZZ
    /// </summary>
   
        public  PrestamoMapeo()
        {
            ToTable("PRESTAMO");
            HasKey(k => k.NumeroPrestamo);
            Property(k => k.NumeroPrestamo).HasColumnName("ID_PRESTAMO");
            Property(k => k.FechaPrestamo).HasColumnName("FECHA_PRESTAMO");
            Property(k => k.FechaDevolucion).HasColumnName("FECHA_DEVOLUCION_PRESTAMO");
            Property(k => k.CodigoLibro).HasColumnName("CODIGO_LIBRO");
            Property(k => k.CodigoUsuario).HasColumnName("CODIGO_USUARIO");

        }

    }
   
}
