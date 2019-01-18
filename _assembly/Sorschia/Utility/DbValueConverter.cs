using System;
using System.IO;

namespace Sorschia.Utility
{
    public static class DbValueConverter
    {
        private static T Convert<T>(object value, Func<object, T> convert)
        {
            return value == DBNull.Value ? default(T) : convert(value);
        }

        private static T Convert<T>(object value, Func<object, IFormatProvider, T> convert, IFormatProvider formatProvider)
        {
            return value == DBNull.Value ? default(T) : convert(value, formatProvider);
        }

        public static bool ToBoolean(object value)
        {
            return Convert(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToBoolean, formatProvider);
        }

        public static byte ToByte(object value)
        {
            return Convert(value, ValueConverter.ToByte);
        }

        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToByte, formatProvider);
        }

        public static byte[] ToByteArray(object value)
        {
            return Convert(value, ValueConverter.ToByteArray);
        }

        public static char ToChar(object value)
        {
            return Convert(value, ValueConverter.ToChar);
        }

        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToChar, formatProvider);
        }

        public static DateTime ToDateTime(object value)
        {
            return Convert(value, ValueConverter.ToDateTime);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToDateTime, formatProvider);
        }

        public static decimal ToDecimal(object value)
        {
            return Convert(value, ValueConverter.ToDecimal);
        }

        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToDecimal, formatProvider);
        }

        public static double ToDouble(object value)
        {
            return Convert(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToDouble, formatProvider);
        }

        public static Guid ToGuid(object value)
        {
            return Convert(value, ValueConverter.ToGuid);
        }

        public static short ToInt16(object value)
        {
            return Convert(value, ValueConverter.ToInt16);
        }

        public static short ToInt16(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToInt16, formatProvider);
        }

        public static int ToInt32(object value)
        {
            return Convert(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToInt32, formatProvider);
        }

        public static long ToInt64(object value)
        {
            return Convert(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToInt64, formatProvider);
        }

        public static bool? ToNullableBoolean(object value)
        {
            return Convert(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableBoolean, formatProvider);
        }

        public static byte? ToNullableByte(object value)
        {
            return Convert(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableByte, formatProvider);
        }

        public static char? ToNullableChar(object value)
        {
            return Convert(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableChar, formatProvider);
        }

        public static DateTime? ToNullableDateTime(object value)
        {
            return Convert(value, ValueConverter.ToNullableDateTime);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableDateTime, formatProvider);
        }

        public static decimal? ToNullableDecimal(object value)
        {
            return Convert(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableDecimal, formatProvider);
        }

        public static double? ToNullableDouble(object value)
        {
            return Convert(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableDouble, formatProvider);
        }

        public static short? ToNullableInt16(object value)
        {
            return Convert(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableInt16, formatProvider);
        }

        public static int? ToNullableInt32(object value)
        {
            return Convert(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableInt32, formatProvider);
        }

        public static long? ToNullableInt64(object value)
        {
            return Convert(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableInt64, formatProvider);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return Convert(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableSByte, formatProvider);
        }

        public static float? ToNullableSingle(object value)
        {
            return Convert(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableSingle, formatProvider);
        }

        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            return Convert(value, ValueConverter.ToNullableTimeSpan);
        }

        public static TimeSpan? ToNullableTimeSpan(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableTimeSpan, formatProvider);
        }

        public static ushort? ToNullableUInt16(object value)
        {
            return Convert(value, ValueConverter.ToNullableUInt16);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableUInt16, formatProvider);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return Convert(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableUInt32, formatProvider);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return Convert(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToNullableUInt64, formatProvider);
        }

        public static sbyte ToSByte(object value)
        {
            return Convert(value, ValueConverter.ToSByte);
        }

        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToSByte, formatProvider);
        }

        public static float ToSingle(object value)
        {
            return Convert(value, ValueConverter.ToSingle);
        }

        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToSingle, formatProvider);
        }

        public static Stream ToStream(object value)
        {
            return Convert(value, ValueConverter.ToStream);
        }

        public static string ToString(object value)
        {
            return Convert(value, ValueConverter.ToString);
        }

        public static string ToString(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToString, formatProvider);
        }

        public static TimeSpan ToTimeSpan(object value)
        {
            return Convert(value, ValueConverter.ToTimeSpan);
        }

        public static TimeSpan ToTimeSpan(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToTimeSpan, formatProvider);
        }

        public static ushort ToUInt16(object value)
        {
            return Convert(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToUInt16, formatProvider);
        }

        public static uint ToUInt32(object value)
        {
            return Convert(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToUInt32, formatProvider);
        }

        public static ulong ToUInt64(object value)
        {
            return Convert(value, ValueConverter.ToUInt64);
        }

        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return Convert(value, ValueConverter.ToUInt64, formatProvider);
        }
    }
}
