using System;
using System.Data;
using System.Data.Common;

namespace Sorschia.Extension
{
    public static class DbCommandExtensions
    {
        public static DbCommand AddInParameter(this DbCommand instance, string name, object value)
        {
            instance.Parameters.AddIn(name, value ?? DBNull.Value);
            return instance;
        }

        public static DbCommand AddInParameter(this DbCommand instance, string name, object value, DbType dbType)
        {
            instance.Parameters.AddIn(name, value ?? DBNull.Value, dbType);
            return instance;
        }

        public static DbCommand AddInParameter(this DbCommand instance, string name, object value, SqlDbType sqlDbType)
        {
            instance.Parameters.AddIn(name, value ?? DBNull.Value, sqlDbType);
            return instance;
        }

        public static DbCommand AddOutParameter(this DbCommand instance, string name, DbType dbType)
        {
            instance.Parameters.AddOut(name, dbType);
            return instance;
        }

        public static DbCommand AddOutParameter(this DbCommand instance, string name, DbType dbType, int size)
        {
            instance.Parameters.AddOut(name, dbType, size);
            return instance;
        }

        public static DbCommand AddOutParameter(this DbCommand instance, string name, SqlDbType sqlDbType)
        {
            instance.Parameters.AddOut(name, sqlDbType);
            return instance;
        }

        public static DbCommand AddOutParameter(this DbCommand instance, string name, SqlDbType sqlDbType, int size)
        {
            instance.Parameters.AddOut(name, sqlDbType, size);
            return instance;
        }

        public static DbCommand AddInOutParameter(this DbCommand instance, string name, object value, DbType dbType)
        {
            instance.Parameters.AddInOut(name, value ?? DBNull.Value, dbType);
            return instance;
        }

        public static DbCommand AddInOutParameter(this DbCommand instance, string name, object value, DbType dbType, int size)
        {
            instance.Parameters.AddInOut(name, value ?? DBNull.Value, dbType, size);
            return instance;
        }

        public static DbCommand AddInOutParameter(this DbCommand instance, string name, object value, SqlDbType sqlDbType)
        {
            instance.Parameters.AddInOut(name, value ?? DBNull.Value, sqlDbType);
            return instance;
        }

        public static DbCommand AddInOutParameter(this DbCommand instance, string name, object value, SqlDbType sqlDbType, int size)
        {
            instance.Parameters.AddInOut(name, value ?? DBNull.Value, sqlDbType, size);
            return instance;
        }
    }
}
