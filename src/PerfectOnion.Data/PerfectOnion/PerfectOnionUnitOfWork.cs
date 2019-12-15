using PerfectOnion.Core.PerfectOnion.Interfaces;
using PerfectOnion.Data.Common;

namespace PerfectOnion.Data.PerfectOnion
{
    public class PerfectOnionUnitOfWork : UnitOfWork, IPerfectOnionUnitOfWork
    {
        public PerfectOnionUnitOfWork(
            PerfectOnionContext context,
            IOrderRepository orderRepository) : base(context)
        {
            Orders = orderRepository;
        }

        public IOrderRepository Orders { get; }
    }
}