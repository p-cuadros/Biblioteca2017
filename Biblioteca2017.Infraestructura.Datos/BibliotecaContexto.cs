using System.Data.Entity;

namespace Biblioteca2017.Infraestructura.Datos
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto() : base("biblio")
        {
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Valoracion> Valoraciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new LibroMapeo());
            modelBuilder.Configurations.Add(new UsuarioMapeo());
            modelBuilder.Configurations.Add(new ValoracionMapeo());
        }
    }
}
