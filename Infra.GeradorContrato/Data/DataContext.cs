using Domain.GeradorContrato.Model;
using Infra.GeradorContrato.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ModeloContratoModel> ModeloContrato { get; set; }
        public DbSet<CamposModelosModel> CamposModelos { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<ContratoGeradoModel> ContratoGerado { get; set; }
        public DbSet<ValoresCamposModel> ValoresCampos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModeloContratoModel>(new ModeloContratoMap().Configure);
            modelBuilder.Entity<CamposModelosModel>(new CamposModelosMap().Configure);
            modelBuilder.Entity<UsuarioModel>(new UsuarioMap().Configure);
            modelBuilder.Entity<ContratoGeradoModel>(new ContratoGeradoMap().Configure);
            modelBuilder.Entity<ValoresCamposModel>(new ValoresCamposMap().Configure);

            base.OnModelCreating(modelBuilder);
        }
    }
}
