using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Implemetations
{
    public class CamposModelosImplementation : BaseRepository<CamposModelosModel>, ICamposModelosImplementation
    {
        private readonly DbSet<CamposModelosModel> _dataSet;

        public CamposModelosImplementation(DataContext database) : base(database)
        {
            _dataSet = database.Set<CamposModelosModel>();
        }
    }
}
