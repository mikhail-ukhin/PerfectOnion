using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Common.Dtos;

namespace PerfectOnion.Core.Common.Interfaces
{
    public interface IService<T> where T : BaseDto
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}