using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Abstractions;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Infrastructure.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public Task<T> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetListAsync(Func<T, bool> selector)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(Func<T, bool> selector)
        {
            throw new NotImplementedException();
        }
    }
}