using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Implemetations
{
    public class ContratoGeradoImplementation : BaseRepository<ContratoGeradoModel>, IContratoGeradoImplementation
    {
        private readonly DbSet<ContratoGeradoModel> _dataSet;

        public ContratoGeradoImplementation(DataContext database) : base(database)
        {
            _dataSet = database.Set<ContratoGeradoModel>();
        }
    }
}
