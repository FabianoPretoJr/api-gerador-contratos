using Domain.GeradorContrato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.GeradorContrato.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.User_Login).IsUnique();
            builder.Property(u => u.Senha);
        }
    }
}
