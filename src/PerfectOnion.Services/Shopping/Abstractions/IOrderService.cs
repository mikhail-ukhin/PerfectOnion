using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Services.Shopping.Dtos;

namespace PerfectOnion.Services.Shopping.Abstractions
{
    public interface IOrderService
    {
        Task<OrderDto> GetAsync(int id);
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task<IEnumerable<OrderDto>> GetListAsync(DateTime startDate, DateTime endDate);
    }
}