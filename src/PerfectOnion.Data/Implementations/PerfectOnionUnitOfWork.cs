using System;
using Microsoft.EntityFrameworkCore;
using PerfectOnion.Core.Abstractions;

namespace PerfectOnion.Data.Implementations
{
    public class PerfectOnionUnitOfWork : UnitOfWork, IPerfectOnionUnitOfWork
    {
        private readonly Lazy<IOrderRepository> _orderRepository;

        public PerfectOnionUnitOfWork(
            DbContext context,
            Lazy<IOrderRepository> orderRepository) : base(context)
        {
            _orderRepository = orderRepository;
        }

        public IOrderRepository Orders => _orderRepository.Value;
    }
}