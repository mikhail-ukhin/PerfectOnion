using PerfectOnion.Core.Common.Interfaces;

namespace PerfectOnion.Core.PerfectOnion.Interfaces
{
    public interface IPerfectOnionUnitOfWork : IUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}