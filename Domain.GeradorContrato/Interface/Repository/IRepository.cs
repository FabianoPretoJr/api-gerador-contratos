using Domain.GeradorContrato.Model;

namespace Domain.GeradorContrato.Interface.Repository
{
    public interface IRepository<T> where T : ModelBase
    {
        bool InsertAsync(T item);
    }
}
