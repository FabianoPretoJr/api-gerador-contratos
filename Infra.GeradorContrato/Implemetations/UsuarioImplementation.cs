using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;
using Infra.GeradorContrato.Data;
using Infra.GeradorContrato.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.GeradorContrato.Implemetations
{
    public class UsuarioImplementation : BaseRepository<UsuarioModel>, IUsuarioImplementation
    {
        private readonly DbSet<UsuarioModel> _dataSet;

        public UsuarioImplementation(DataContext database) : base(database)
        {
            _dataSet = database.Set<UsuarioModel>();
        }
    }
}
