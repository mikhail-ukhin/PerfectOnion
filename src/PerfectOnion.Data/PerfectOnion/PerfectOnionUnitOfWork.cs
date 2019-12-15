using System;
using Microsoft.EntityFrameworkCore;
using PerfectOnion.Core.PerfectOnion.Interfaces;
using PerfectOnion.Data.Common;

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