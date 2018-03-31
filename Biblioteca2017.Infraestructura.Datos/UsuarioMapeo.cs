using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2017.Infraestructura.Datos
{
    public class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("USUARIOS");
            HasKey(k => k.CodigoUsuario);
            Property(k => k.CodigoUsuario).HasColumnName("COD_USUARIO");
            Property(k => k.NombreUsuario).HasColumnType("varchar").HasColumnName("NOM_USUARIO").HasMaxLength(100);
        }
    }
}
