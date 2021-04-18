using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Implemetations
{
    public class ValoresCamposImplementation : BaseRepository<ValoresCamposModel>, IValoresCamposImplementation
    {
        private readonly DbSet<ValoresCamposModel> _dataSet;

        public ValoresCamposImplementation(DataContext database) : base(database)
        {
            _dataSet = database.Set<ValoresCamposModel>();
        }
    }
}
