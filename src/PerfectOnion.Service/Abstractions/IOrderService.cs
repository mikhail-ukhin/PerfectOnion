using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Service.Dtos;

namespace PerfectOnion.Service.Abstractions
{
    public interface IOrderService
    {
        Task<OrderDto> GetAsync(int id);
        Task<IEnumerable<OrderDto>> GetAllAsync();
    }
}