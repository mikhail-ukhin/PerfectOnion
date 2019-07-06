using System.Threading.Tasks;

namespace PerfectOnion.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}