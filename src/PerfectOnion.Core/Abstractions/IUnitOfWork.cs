using System.Threading.Tasks;

namespace PerfectOnion.Core.Abstractions
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}