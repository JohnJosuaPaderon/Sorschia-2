using System.Data;
using System.Data.Common;

namespace Sorschia.Extension
{
    public static class DbConnectionExtensions
    {
        public static DbCommand CreateCommand(this DbConnection instance, string commandText, DbTransaction transaction = null)
        {
            var command = instance.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = commandText;

            return command;
        }

        public static DbCommand CreateProcedureCommand(this DbConnection instance, string procedure, DbTransaction transaction = null)
        {
            var command = instance.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = procedure;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }
    }
}
