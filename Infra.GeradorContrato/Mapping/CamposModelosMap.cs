using Domain.GeradorContrato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.GeradorContrato.Mapping
{
    public class CamposModelosMap : IEntityTypeConfiguration<CamposModelosModel>
    {
        public void Configure(EntityTypeBuilder<CamposModelosModel> builder)
        {
            builder.ToTable("CamposModelos");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Nome_Campo).IsUnique();
            builder.Property(c => c.Tipo_Campo);
            builder.HasOne(c => c.ModeloContrato).WithMany(m => m.CamposModelos).HasForeignKey(c => c.Id_ModeloContrato);
            builder.Property(c => c.Ativo);
        }
    }
}
