using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Implemetations
{
    public class ModeloContratoImplementation : BaseRepository<ModeloContratoModel>, IModeloContratoImplementation
    {
        private readonly DbSet<ModeloContratoModel> _dataSet;

        public ModeloContratoImplementation(DataContext database) : base(database)
        {
            _dataSet = database.Set<ModeloContratoModel>();
        }
    }
}
