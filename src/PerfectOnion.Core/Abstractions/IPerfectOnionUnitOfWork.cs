namespace PerfectOnion.Core.Abstractions
{
    public interface IPerfectOnionUnitOfWork : IUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}