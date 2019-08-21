using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PerfectOnion.Core.Abstractions;
using PerfectOnion.Core.Entities;
using PerfectOnion.Services.Shopping.Abstractions;
using PerfectOnion.Services.Shopping.Dtos;

namespace PerfectOnion.Services.Shopping.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IPerfectOnionUnitOfWork _perfectOnionUnitOfWork;
        private readonly IMapper _mapper;

        public OrderService(
            IPerfectOnionUnitOfWork perfectOnionUnitOfWork,
            IMapper mapper)
        {
            _perfectOnionUnitOfWork = perfectOnionUnitOfWork;
            _mapper = mapper;
        }
        
        public async Task<OrderDto> GetAsync(int id)
        {
            if (id <= 0) throw new ArgumentException(nameof(id));

            var order = await _perfectOnionUnitOfWork.Orders.GetAsync(id);

            return _mapper.Map<Order, OrderDto>(order);
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var orders = await _perfectOnionUnitOfWork.Orders.GetAllAsync();

            return _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders);
        }

        public async Task<IEnumerable<OrderDto>> GetListAsync(DateTime startDate, DateTime endDate)
        {
            var orders = await _perfectOnionUnitOfWork.Orders
                .GetListAsync(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate);

            return _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders);
        }
    }
}