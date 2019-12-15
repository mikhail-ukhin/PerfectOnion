using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Common.Entities;

namespace PerfectOnion.Core.Common.Interfaces
{
    public interface IReadOnlyRepository<T> where T: BaseEntity
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetListAsync(Func<T, bool> selector);
    }
}