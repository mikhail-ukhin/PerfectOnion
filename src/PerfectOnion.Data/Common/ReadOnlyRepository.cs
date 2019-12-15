using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Common.Entities;
using PerfectOnion.Core.Common.Interfaces;

namespace PerfectOnion.Data.Common
{
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T> where T : BaseEntity
    {
        public Task<T> GetAsync(int id)
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
    }
}