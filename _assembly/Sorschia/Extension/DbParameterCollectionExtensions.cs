using Sorschia.Utility;
using System;
using System.Data.Common;
using System.IO;

namespace Sorschia.Extension
{
    public static class DbParameterCollectionExtension
    {
        private static void Validate(DbParameterCollection parameters, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("parameter name is set to null or white space.", nameof(name));
            }

            if (parameters.Count <= 0)
            {
                throw new ArgumentException("parameters is empty.", nameof(parameters));
            }
        }
        
        private static T Get<T>(this DbParameterCollection instance, string name, Func<object, T> convert)
        {
            Validate(instance, name);
            return convert(instance[name]?.Value);
        }
        
        private static T Get<T>(this DbParameterCollection instance, string name, IFormatProvider formatProvider, Func<object, IFormatProvider, T> convert)
        {
            Validate(instance, name);
            return convert(instance[name]?.Value, formatProvider);
        }
        
        public static bool GetBoolean(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToBoolean);
        }
        
        public static bool GetBoolean(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToBoolean);
        }
        
        public static byte GetByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToByte);
        }
        
        public static byte GetByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToByte);
        }
        
        public static byte[] GetByteArray(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToByteArray);
        }

        public static char GetChar(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToChar);
        }
        
        public static char GetChar(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToChar);
        }
        
        public static DateTime GetDateTime(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDateTime);
        }

        public static DateTime GetDateTime(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDateTime);
        }
        
        public static decimal GetDecimal(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDecimal);
        }

        public static decimal GetDecimal(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDecimal);
        }
        
        public static double GetDouble(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToDouble);
        }
        
        public static double GetDouble(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToDouble);
        }

        public static Guid GetGuid(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToGuid);
        }
        
        public static short GetInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt16);
        }

        public static short GetInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt16);
        }
        
        public static int GetInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt32);
        }
        
        public static int GetInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt32);
        }
        
        public static long GetInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToInt64);
        }
        
        public static long GetInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToInt64);
        }
        
        public static bool? GetNullableBoolean(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableBoolean);
        }
        
        public static bool? GetNullableBoolean(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableBoolean);
        }
        
        public static byte? GetNullableByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableByte);
        }
        
        public static byte? GetNullableByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableByte);
        }
        
        public static char? GetNullableChar(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableChar);
        }
        
        public static char? GetNullableChar(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableChar);
        }
        
        public static DateTime? GetNullableDateTime(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDateTime);
        }
        
        public static DateTime? GetNullableDateTime(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDateTime);
        }
        
        public static decimal? GetNullableDecimal(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDecimal);
        }
        
        public static decimal? GetNullableDecimal(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDecimal);
        }
        
        public static double? GetNullableDouble(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableDouble);
        }
        
        public static double? GetNullableDouble(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableDouble);
        }

        public static Guid? GetNullableGuid(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableGuid);
        }
        
        public static short? GetNullableInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt16);
        }
        
        public static short? GetNullableInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt16);
        }
        
        public static int? GetNullableInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt32);
        }
        
        public static int? GetNullableInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt32);
        }
        
        public static long? GetNullableInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableInt64);
        }
        
        public static long? GetNullableInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableInt64);
        }

        public static sbyte? GetNullableSByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableSByte);
        }
        
        public static sbyte? GetNullableSByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableSByte);
        }
        
        public static float? GetNullableSingle(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableSingle);
        }
        
        public static float? GetNullableSingle(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableSingle);
        }
        
        public static TimeSpan? GetNullableTimeSpan(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableTimeSpan);
        }
        
        public static ushort? GetNullableUInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt16);
        }
        
        public static ushort? GetNullableUInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt16);
        }
        
        public static uint? GetNullableUInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt32);
        }

        public static uint? GetNullableUInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt32);
        }
        
        public static ulong? GetNullableUInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToNullableUInt64);
        }
        
        public static ulong? GetNullableUInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToNullableUInt64);
        }
        
        public static sbyte GetSByte(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToSByte);
        }
        
        public static sbyte GetSByte(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToSByte);
        }
        
        public static float GetSingle(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToSingle);
        }
        
        public static float GetSingle(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToSingle);
        }
        
        public static Stream GetStream(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToStream);
        }

        public static string GetString(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToString);
        }
        
        public static string GetString(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToString);
        }
        
        public static TimeSpan GetTimeSpan(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToTimeSpan);
        }
        
        public static ushort GetUInt16(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt16);
        }
        
        public static ushort GetUInt16(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt16);
        }
        
        public static uint GetUInt32(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt32);
        }
        
        public static uint GetUInt32(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt32);
        }
        
        public static ulong GetUInt64(this DbParameterCollection instance, string name)
        {
            return instance.Get(name, DbValueConverter.ToUInt64);
        }
        
        public static ulong GetUInt64(this DbParameterCollection instance, string name, IFormatProvider formatProvider)
        {
            return instance.Get(name, formatProvider, DbValueConverter.ToUInt64);
        }
    }
}
