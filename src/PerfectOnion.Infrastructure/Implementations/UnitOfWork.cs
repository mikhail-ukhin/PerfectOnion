using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PerfectOnion.Core.Abstractions;

namespace PerfectOnion.Infrastructure.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext Context;

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        
        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}