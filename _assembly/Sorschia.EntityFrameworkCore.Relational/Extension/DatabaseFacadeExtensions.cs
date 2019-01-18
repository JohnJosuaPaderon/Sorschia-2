using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Extension
{
    public static class DatabaseFacadeExtensions
    {
        public static DbConnection GetOpenDbConnection(this DatabaseFacade instance)
        {
            var connection = instance.GetDbConnection();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public static async Task<DbConnection> GetOpenDbConnectionAsync(this DatabaseFacade instance, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = instance.GetDbConnection();

            if (connection.State == ConnectionState.Closed)
            {
                await connection.OpenAsync(cancellationToken);
            }

            return connection;
        }
    }
}
