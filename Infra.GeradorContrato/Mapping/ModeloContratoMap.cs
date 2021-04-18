using Domain.GeradorContrato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.GeradorContrato.Mapping
{
    public class ModeloContratoMap : IEntityTypeConfiguration<ModeloContratoModel>
    {
        public void Configure(EntityTypeBuilder<ModeloContratoModel> builder)
        {
            builder.ToTable("ModeloContrato");
            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.Nome).IsUnique();
            builder.Property(m => m.Ativo);
        }
    }
}
