using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Services.Abstractions;
using PerfectOnion.Services.Dtos;

namespace PerfectOnion.Services.Implementations
{
    public class OrderService : IOrderService
    {
        public async Task<OrderDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}