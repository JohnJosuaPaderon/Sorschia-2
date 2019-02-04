using Microsoft.EntityFrameworkCore;

namespace Sorschia.Process
{
    public abstract class DbProcess<TContext> where TContext : DbContext
    {
        public DbProcess(TContext context, string schema = null)
        {
            Context = context;
            Schema = schema;
        }

        protected TContext Context { get; }
        protected string Schema { get; }

        protected string GetProcedureName()
        {
            return $"{Schema ?? "dbo"}.{GetType().Name}";
        }
    }
}
