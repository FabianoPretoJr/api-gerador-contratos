using Domain.GeradorContrato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.GeradorContrato.Mapping
{
    public class ContratoGeradoMap : IEntityTypeConfiguration<ContratoGeradoModel>
    {
        public void Configure(EntityTypeBuilder<ContratoGeradoModel> builder)
        {
            builder.ToTable("ContratoGerado");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.ModeloContrato).WithMany(m => m.ContratoGerado).HasForeignKey(c => c.Id_ModeloContrato);
            builder.HasOne(c => c.Usuario).WithMany(u => u.ContratoGerado).HasForeignKey(c => c.Id_Usuario);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.UpdatedAt);
            builder.Property(c => c.Ativo);
        }
    }
}
