using Domain.GeradorContrato.Interface.Repository;
using Domain.GeradorContrato.Model;
using Infra.GeradorContrato.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infra.GeradorContrato.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : ModelBase
    {
        private readonly DataContext _database;
        private DbSet<T> _dataSet;

        public BaseRepository(DataContext database)
        {
            _database = database;
            _dataSet = database.Set<T>();
        }

        public bool InsertAsync(T item)
        {
            try
            {
                if (item == null)
                    return false;

                _dataSet.Add(item);
                _database.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
