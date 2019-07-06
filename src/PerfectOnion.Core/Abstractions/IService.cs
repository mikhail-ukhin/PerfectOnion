using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.Dtos;

namespace PerfectOnion.Core.Abstractions
{
    public interface IService<T> where T : BaseDto
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}