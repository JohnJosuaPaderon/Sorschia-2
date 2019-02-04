using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Sorschia.Extension
{
    public static class DbParameterCollectionExtensions
    {
        public static DbParameterCollection AddIn(this DbParameterCollection instance, string name, object value)
        {
            instance.Add(new SqlParameter(name, value));
            return instance;
        }

        public static DbParameterCollection AddOut(this DbParameterCollection instance, string name, DbType dbType)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                DbType = dbType,
                Direction = ParameterDirection.Output
            });
            return instance;
        }

        public static DbParameterCollection AddOut(this DbParameterCollection instance, string name, DbType dbType, int size)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                DbType = dbType,
                Direction = ParameterDirection.Output,
                Size = size
            });
            return instance;
        }

        public static DbParameterCollection AddOut(this DbParameterCollection instance, string name, SqlDbType sqlDbType)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                SqlDbType = sqlDbType,
                Direction = ParameterDirection.Output
            });
            return instance;
        }

        public static DbParameterCollection AddOut(this DbParameterCollection instance, string name, SqlDbType sqlDbType, int size)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                SqlDbType = sqlDbType,
                Direction = ParameterDirection.Output,
                Size = size
            });
            return instance;
        }

        public static DbParameterCollection AddInOut(this DbParameterCollection instance, string name, object value, DbType dbType)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                DbType = dbType,
                Value = value,
                Direction = ParameterDirection.InputOutput
            });
            return instance;
        }

        public static DbParameterCollection AddInOut(this DbParameterCollection instance, string name, object value, DbType dbType, int size)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                DbType = dbType,
                Value = value,
                Direction = ParameterDirection.InputOutput,
                Size = size
            });
            return instance;
        }

        public static DbParameterCollection AddInOut(this DbParameterCollection instance, string name, object value, SqlDbType sqlDbType)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                SqlDbType = sqlDbType,
                Value = value,
                Direction = ParameterDirection.InputOutput
            });
            return instance;
        }

        public static DbParameterCollection AddInOut(this DbParameterCollection instance, string name, object value, SqlDbType sqlDbType, int size)
        {
            instance.Add(new SqlParameter
            {
                ParameterName = name,
                SqlDbType = sqlDbType,
                Value = value,
                Direction = ParameterDirection.InputOutput,
                Size = size
            });
            return instance;
        }
    }
}
