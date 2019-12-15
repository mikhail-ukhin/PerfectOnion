using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Common.Entities;
using PerfectOnion.Core.Common.Interfaces;

namespace PerfectOnion.Data.Common
{
    public class Repository<T> : ReadOnlyRepository<T>, IRepository<T> where T : BaseEntity
    {
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