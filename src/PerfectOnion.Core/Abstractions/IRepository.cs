using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Entities;

namespace PerfectOnion.Core.Abstractions
{
    public interface IRepository<T> : IReadOnlyRepository<T> where T : BaseEntity
    {
        Task<int> AddAsync(T entity);
        Task<IEnumerable<int>> AddRangeAsync(IEnumerable<T> entities);
        
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteRange(Func<T, bool> selector);       
    }
}