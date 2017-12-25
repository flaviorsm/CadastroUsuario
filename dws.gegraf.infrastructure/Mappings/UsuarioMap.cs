using dws.gegraf.domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace dws.gegraf.infrastructure.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasMaxLength(250).IsRequired();
            Property(x => x.Senha).IsRequired();
            Property(x => x.Email).HasMaxLength(100).IsRequired();
        }
    }
}
