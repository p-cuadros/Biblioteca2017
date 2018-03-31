using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017.Infraestructura.Datos
{
    public class ValoracionMapeo : EntityTypeConfiguration<Valoracion>
    {
        public ValoracionMapeo()
        {
            ToTable("LIBRO_VALORACIONES");
            HasKey(k => k.NumeroValoracion);
            Property(k => k.NumeroValoracion).HasColumnName("ID_VALORACION");
            Property(k => k.CodigoLibro).HasColumnName("COD_LIBRO");
            Property(k => k.CodigoUsuario).HasColumnName("COD_USUARIO");
            Property(k => k.FechaValoracion).HasColumnName("FEC_VALORACION");
            Property(k => k.ValorValoracion).HasColumnName("VAL_VALORACION");

            HasRequired(p => p.Libro).WithMany().HasForeignKey(f => f.CodigoLibro);
            HasRequired(p => p.Usuario).WithMany().HasForeignKey(f => f.CodigoUsuario);
        }
    }
}
