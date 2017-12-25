using dws.gegraf.domain;
using dws.gegraf.infrastructure.Mappings;
using MySql.Data.Entity;
using System.Data.Entity;

namespace dws.gegraf.infrastructure.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base("GegrafConnectionString")
        {
            Database.SetInitializer<DataContext>(new DataContextInitializer());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Usuarios.Add(new Usuario { Nome = "admin", Email = "admin@dwsservices.com.br", Senha = "123456", Ativo = true });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
