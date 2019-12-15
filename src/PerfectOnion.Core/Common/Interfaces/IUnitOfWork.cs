using System.Threading.Tasks;

namespace PerfectOnion.Core.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}