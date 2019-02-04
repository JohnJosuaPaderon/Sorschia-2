using Microsoft.EntityFrameworkCore;
using Sorschia.Extension;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Process
{
    public static class DbProcessHelper
    {
        public static T HandleExecute<T>(DbContext context, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback)
        {
            var connection = context.Database.GetOpenDbConnection();

            try
            {
                using (var command = createCommand(connection))
                {
                    return callback(command.ExecuteNonQuery(), command);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static T HandleExecute<T>(DbContext context, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbTransaction, T> callback)
        {
            var connection = context.Database.GetOpenDbConnection();

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = createCommand(connection, transaction))
                    {
                        return callback(command.ExecuteNonQuery(), transaction);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static T HandleExecute<T>(DbContext context, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, DbTransaction, T> callback)
        {
            var connection = context.Database.GetOpenDbConnection();

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = createCommand(connection, transaction))
                    {
                        return callback(command.ExecuteNonQuery(), command, transaction);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static async Task<T> HandleExecuteAsync<T>(DbContext context, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = await context.Database.GetOpenDbConnectionAsync(cancellationToken);

            try
            {
                using (var command = createCommand(connection))
                {
                    return callback(await command.ExecuteNonQueryAsync(cancellationToken), command);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static async Task<T> HandleExecuteAsync<T>(DbContext context, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbTransaction, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = await context.Database.GetOpenDbConnectionAsync();

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = createCommand(connection, transaction))
                    {
                        return callback(await command.ExecuteNonQueryAsync(cancellationToken), transaction);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static async Task<T> HandleExecuteAsync<T>(DbContext context, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, DbTransaction, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = await context.Database.GetOpenDbConnectionAsync(cancellationToken);

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = createCommand(connection, transaction))
                    {
                        return callback(await command.ExecuteNonQueryAsync(cancellationToken), command, transaction);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
