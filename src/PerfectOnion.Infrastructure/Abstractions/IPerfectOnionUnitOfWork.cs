using PerfectOnion.Core.Abstractions;

namespace PerfectOnion.Infrastructure.Abstractions
{
    public interface IPerfectOnionUnitOfWork : IUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}