using PerfectOnion.Core.Interfaces;

namespace PerfectOnion.Infrastructure.Interfaces
{
    public interface IPerfectOnionUnitOfWork : IUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}