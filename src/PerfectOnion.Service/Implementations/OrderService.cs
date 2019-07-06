using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PerfectOnion.Service.Dtos;
using PerfectOnion.Service.Interfaces;

namespace PerfectOnion.Service.Implementations
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