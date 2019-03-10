using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Extension
{
    public static class DbContextExtensions
    {
        public static T Execute<T>(this DbContext instance, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback)
        {
            var connection = instance.Database.GetOpenDbConnection();

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

        public static T LinkExecute<T>(this DbContext instance, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback)
        {
            using (var command = createCommand(instance.Database.GetOpenDbConnection()))
            {
                return callback(command.ExecuteNonQuery(), command);
            }
        }

        public static T Execute<T>(this DbContext instance, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, DbTransaction, T> callback)
        {
            var connection = instance.Database.GetOpenDbConnection();

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

        public static T LinkExecute<T>(this DbContext instance, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, T> callback)
        {
            using (var command = createCommand(instance.Database.GetOpenDbConnection(), instance.Database.CurrentTransaction.GetDbTransaction()))
            {
                return callback(command.ExecuteNonQuery(), command);
            }
        }

        public static async Task<T> ExecuteAsync<T>(this DbContext instance, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = await instance.Database.GetOpenDbConnectionAsync(cancellationToken);

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

        public static async Task<T> LinkExecuteAsync<T>(this DbContext instance, Func<DbConnection, DbCommand> createCommand, Func<int, DbCommand, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var command = createCommand(await instance.Database.GetOpenDbConnectionAsync(cancellationToken)))
            {
                return callback(await command.ExecuteNonQueryAsync(cancellationToken), command);
            }
        }

        public static async Task<T> ExecuteAsync<T>(this DbContext instance, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, DbTransaction, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connection = await instance.Database.GetOpenDbConnectionAsync(cancellationToken);

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

        public static async Task<T> LinkExecuteAsync<T>(this DbContext instance, Func<DbConnection, DbTransaction, DbCommand> createCommand, Func<int, DbCommand, T> callback, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var command = createCommand(await instance.Database.GetOpenDbConnectionAsync(cancellationToken), instance.Database.CurrentTransaction.GetDbTransaction()))
            {
                return callback(await command.ExecuteNonQueryAsync(cancellationToken), command);
            }
        }
    }
}
