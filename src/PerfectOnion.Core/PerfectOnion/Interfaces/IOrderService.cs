using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Core.PerfectOnion.Dtos;

namespace PerfectOnion.Core.PerfectOnion.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDto> GetAsync(int id);
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task<IEnumerable<OrderDto>> GetListAsync(DateTime startDate, DateTime endDate);
    }
}