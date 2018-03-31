using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca2017.Infraestructura.Datos
{
    public class LibroMapeo : EntityTypeConfiguration<Libro>
    {
        public LibroMapeo()
        {
            ToTable("LIBROS");
            HasKey(k => k.CodigoLibro);
            Property(k => k.CodigoLibro).HasColumnName("COD_LIBRO").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(k => k.NombreLibro).HasColumnName("TITULO").HasMaxLength(100);
            Ignore(k => k.Reservado);
        }
    }
}
