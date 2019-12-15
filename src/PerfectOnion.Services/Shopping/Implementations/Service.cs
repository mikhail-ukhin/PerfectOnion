using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Common.Dtos;
using PerfectOnion.Core.Common.Interfaces;

namespace PerfectOnion.Services.Shopping.Implementations
{
    public class Service<T> : IService<T> where T : BaseDto
    {
        public virtual Task<T> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}