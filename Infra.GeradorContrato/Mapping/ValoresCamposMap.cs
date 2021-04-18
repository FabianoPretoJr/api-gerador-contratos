using Domain.GeradorContrato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.GeradorContrato.Mapping
{
    public class ValoresCamposMap : IEntityTypeConfiguration<ValoresCamposModel>
    {
        public void Configure(EntityTypeBuilder<ValoresCamposModel> builder)
        {
            builder.ToTable("ValoresCampos");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Valor_Campo);
            builder.HasOne(v => v.CamposModelos).WithMany(c => c.ValoresCampos).HasForeignKey(v => v.Id_CamposModelos);
            builder.HasOne(v => v.ContratoGerado).WithMany(c => c.ValoresCampos).HasForeignKey(v => v.Id_ContratoGerado);
            builder.Property(v => v.Ativo);
        }
    }
}
