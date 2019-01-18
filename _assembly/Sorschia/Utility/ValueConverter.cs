using System;
using System.IO;

namespace Sorschia.Utility
{
    public static class ValueConverter
    {
        private static bool IsDefault<T>(T value)
        {
            return Equals(default(T), value);
        }

        private static TResult ConvertBase<TInput, TResult>(TInput value, Func<TInput, TResult> convert)
        {
            return IsDefault(value) ? default(TResult) : convert(value);
        }

        private static TResult ConvertBase<TInput, TResult>(TInput value, IFormatProvider formatProvider, Func<TInput, IFormatProvider, TResult> convert)
        {
            return IsDefault(value) ? default(TResult) : convert(value, formatProvider);
        }

        private static TResult? ConvertNullableBase<TInput, TResult>(TInput value, Func<TInput, TResult> convert)
            where TInput : class
            where TResult : struct
        {
            return value == null ? null : new TResult?(convert(value));
        }

        private static TResult? ConvertNullableBase<TInput, TResult>(TInput value, IFormatProvider formatProvider, Func<TInput, IFormatProvider, TResult> convert)
            where TInput : class
            where TResult : struct
        {
            return value == null ? null : new TResult?(convert(value, formatProvider));
        }

        public static bool ToBoolean(byte value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(decimal value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(double value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(short value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(int value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(long value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(object value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToBoolean);
        }

        public static bool ToBoolean(sbyte value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(float value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(string value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToBoolean);
        }

        public static bool ToBoolean(ushort value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(uint value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }

        public static bool ToBoolean(ulong value)
        {
            return ConvertBase(value, Convert.ToBoolean);
        }
        public static byte ToByte(bool value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(char value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(decimal value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(double value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(short value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(int value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(long value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(object value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToByte);
        }

        public static byte ToByte(sbyte value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(float value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(string value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToByte);
        }

        public static byte ToByte(ushort value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(uint value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte ToByte(ulong value)
        {
            return ConvertBase(value, Convert.ToByte);
        }

        public static byte[] ToByteArray(object value)
        {
            if (value is byte[] bytes)
            {
                return bytes;
            }
            else
            {
                return default(byte[]);
            }
        }
        public static char ToChar(byte value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(short value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(int value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(long value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(object value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToChar);
        }

        public static char ToChar(sbyte value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(string value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToChar);
        }

        public static char ToChar(ushort value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(uint value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static char ToChar(ulong value)
        {
            return ConvertBase(value, Convert.ToChar);
        }

        public static DateTime ToDateTime(object value)
        {
            return ConvertBase(value, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(string value)
        {
            return ConvertBase(value, Convert.ToDateTime);
        }

        public static DateTime ToDateTime(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDateTime);
        }
        public static decimal ToDecimal(bool value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(byte value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(double value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(short value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(int value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(long value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(object value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal ToDecimal(sbyte value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(float value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(string value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal ToDecimal(ushort value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(uint value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static decimal ToDecimal(ulong value)
        {
            return ConvertBase(value, Convert.ToDecimal);
        }

        public static double ToDouble(bool value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(byte value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(decimal value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(short value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(int value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(long value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(object value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDouble);
        }

        public static double ToDouble(sbyte value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(float value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(string value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToDouble);
        }

        public static double ToDouble(ushort value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(uint value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static double ToDouble(ulong value)
        {
            return ConvertBase(value, Convert.ToDouble);
        }

        public static Guid ToGuid(object value)
        {
            if (Guid.TryParse(ToString(value), out Guid result))
            {
                return result;
            }
            else
            {
                return default(Guid);
            }
        }

        public static short ToInt16(bool value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(byte value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(char value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(decimal value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(double value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(int value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(long value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(object value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt16);
        }

        public static short ToInt16(sbyte value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(float value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(string value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt16);
        }

        public static short ToInt16(ushort value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(uint value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }

        public static short ToInt16(ulong value)
        {
            return ConvertBase(value, Convert.ToInt16);
        }
        public static int ToInt32(bool value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(byte value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(char value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(decimal value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(double value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(short value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(long value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(object value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt32);
        }

        public static int ToInt32(sbyte value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(float value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(string value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt32);
        }

        public static int ToInt32(ushort value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(uint value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }

        public static int ToInt32(ulong value)
        {
            return ConvertBase(value, Convert.ToInt32);
        }
        public static long ToInt64(bool value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static object ToInt64(byte value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(char value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(decimal value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(double value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(short value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(int value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(object value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt64);
        }

        public static long ToInt64(sbyte value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(float value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(string value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToInt64);
        }

        public static long ToInt64(ushort value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(uint value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }

        public static long ToInt64(ulong value)
        {
            return ConvertBase(value, Convert.ToInt64);
        }
        public static bool? ToNullableBoolean(object value)
        {
            return ConvertNullableBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(string value)
        {
            return ConvertNullableBase(value, Convert.ToBoolean);
        }

        public static bool? ToNullableBoolean(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToBoolean);
        }
        public static byte? ToNullableByte(object value)
        {
            return ConvertNullableBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToByte);
        }

        public static byte? ToNullableByte(string value)
        {
            return ConvertNullableBase(value, Convert.ToByte);
        }

        public static byte? ToNullableByte(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToByte);
        }
        public static char? ToNullableChar(object value)
        {
            return ConvertNullableBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToChar);
        }

        public static char? ToNullableChar(string value)
        {
            return ConvertNullableBase(value, Convert.ToChar);
        }

        public static char? ToNullableChar(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToChar);
        }
        public static DateTime? ToNullableDateTime(object value)
        {
            return ConvertNullableBase(value, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(String value)
        {
            return ConvertNullableBase(value, Convert.ToDateTime);
        }

        public static DateTime? ToNullableDateTime(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDateTime);
        }
        public static decimal? ToNullableDecimal(object value)
        {
            return ConvertNullableBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(String value)
        {
            return ConvertNullableBase(value, Convert.ToDecimal);
        }

        public static decimal? ToNullableDecimal(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDecimal);
        }

        public static double? ToNullableDouble(object value)
        {
            return ConvertNullableBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDouble);
        }

        public static double? ToNullableDouble(string value)
        {
            return ConvertNullableBase(value, Convert.ToDouble);
        }

        public static double? ToNullableDouble(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToDouble);
        }

        public static short? ToNullableInt16(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt16);
        }

        public static short? ToNullableInt16(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt16);
        }

        public static short? ToNullableInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt16);
        }

        public static int? ToNullableInt32(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt32);
        }

        public static int? ToNullableInt32(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt32);
        }

        public static int? ToNullableInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt32);
        }

        public static long? ToNullableInt64(object value)
        {
            return ConvertNullableBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt64);
        }

        public static long? ToNullableInt64(string value)
        {
            return ConvertNullableBase(value, Convert.ToInt64);
        }

        public static long? ToNullableInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToInt64);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return ConvertNullableBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(string value)
        {
            return ConvertNullableBase(value, Convert.ToSByte);
        }

        public static sbyte? ToNullableSByte(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSByte);
        }

        public static float? ToNullableSingle(object value)
        {
            return ConvertNullableBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSingle);
        }

        public static float? ToNullableSingle(string value)
        {
            return ConvertNullableBase(value, Convert.ToSingle);
        }

        public static float? ToNullableSingle(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToSingle);
        }

        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            var converted = ToNullableInt64(value);
            return converted == null ? null : new TimeSpan?(ToTimeSpan(converted));
        }

        public static TimeSpan? ToNullableTimeSpan(object value, IFormatProvider formatProvider)
        {
            var converted = ToNullableUInt64(value, formatProvider);
            return converted == null ? null : new TimeSpan?(ToTimeSpan(converted));
        }

        public static ushort? ToNullableUInt16(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt16);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt16);
        }

        public static ushort? ToNullableUInt16(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt16);
        }

        public static ushort? ToNullableUInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt16);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt32);
        }

        public static uint? ToNullableUInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt32);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return ConvertNullableBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(string value)
        {
            return ConvertNullableBase(value, Convert.ToUInt64);
        }

        public static ulong? ToNullableUInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertNullableBase(value, formatProvider, Convert.ToUInt64);
        }

        public static sbyte ToSByte(bool value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(byte value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(char value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(decimal value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(double value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(short value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(int value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(long value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(object value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte ToSByte(float value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(string value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSByte);
        }

        public static sbyte ToSByte(ushort value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(uint value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static sbyte ToSByte(ulong value)
        {
            return ConvertBase(value, Convert.ToSByte);
        }

        public static float ToSingle(bool value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(byte value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(decimal value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(double value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(short value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(int value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(long value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(object value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSingle);
        }

        public static float ToSingle(sbyte value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(string value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToSingle);
        }

        public static float ToSingle(ushort value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(uint value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static float ToSingle(ulong value)
        {
            return ConvertBase(value, Convert.ToSingle);
        }

        public static Stream ToStream(object value)
        {
            return value == null ? null : ConvertBase(value, val => new MemoryStream(ToByteArray(val)));
        }

        public static string ToString(bool value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(bool value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(byte value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(byte value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(char value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(char value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(DateTime value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(DateTime value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(decimal value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(decimal value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(double value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(double value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(short value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(short value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(int value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(int value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(long value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(long value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(object value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(sbyte value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(sbyte value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(float value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(float value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(ushort value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(ushort value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(uint value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(uint value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static string ToString(ulong value)
        {
            return ConvertBase(value, Convert.ToString);
        }

        public static string ToString(ulong value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToString);
        }

        public static TimeSpan ToTimeSpan(object value)
        {
            var converted = ToInt64(value);
            return new TimeSpan(converted);
        }

        public static TimeSpan ToTimeSpan(object value, IFormatProvider formatProvider)
        {
            var converted = ToInt64(value, formatProvider);
            return new TimeSpan(converted);
        }

        public static ushort ToUInt16(bool value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(byte value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(char value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(decimal value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(double value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(short value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(int value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(long value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(object value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt16);
        }

        public static ushort ToUInt16(sbyte value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(float value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(string value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt16);
        }

        public static ushort ToUInt16(uint value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static ushort ToUInt16(ulong value)
        {
            return ConvertBase(value, Convert.ToUInt16);
        }

        public static uint ToUInt32(bool value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(byte value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(char value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(decimal value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(double value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(short value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(int value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(long value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(object value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt32);
        }

        public static uint ToUInt32(sbyte value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(float value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(string value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt32);
        }

        public static uint ToUInt32(ushort value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static uint ToUInt32(ulong value)
        {
            return ConvertBase(value, Convert.ToUInt32);
        }

        public static ulong ToUInt64(bool value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(byte value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(char value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(decimal value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(double value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(short value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(int value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(long value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(object value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong ToUInt64(sbyte value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(float value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(string value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(string value, IFormatProvider formatProvider)
        {
            return ConvertBase(value, formatProvider, Convert.ToUInt64);
        }

        public static ulong ToUInt64(ushort value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }

        public static ulong ToUInt64(uint value)
        {
            return ConvertBase(value, Convert.ToUInt64);
        }
    }
}
