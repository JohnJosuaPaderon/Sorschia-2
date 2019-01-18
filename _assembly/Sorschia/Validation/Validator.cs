using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorschia.Validation
{
    public static partial class Validator
    {
        public static void NullOrWhiteSpace(string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException(message, ValidationType.NullOrWhiteSpace);
            }
        }

        public static void Null(object value, string message)
        {
            if (value == null)
            {
                throw new ValidationException(message, ValidationType.Null);
            }
        }

        public static void Default<T>(T value, string message)
        {
            if (Equals(default(T), value))
            {
                throw new ValidationException(message, ValidationType.Default);
            }
        }

        public static void EmptyIEnumerable<T>(IEnumerable<T> enumerable, string message)
        {
            Null(enumerable, message);

            if (!enumerable.Any())
            {
                throw new ValidationException(message, ValidationType.EmptyIEnumerable);
            }
        }

        public static void LessThan<T>(T value, T minValue, string message)
            where T : struct, IComparable<T>
        {
            if (value.CompareTo(minValue) < 0)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void LessThanOrEqual<T>(T value, T minValue, string message)
            where T : struct, IComparable<T>
        {
            if (value.CompareTo(minValue) <= 0)
            {
                throw new ValidationException(message, ValidationType.LessThan);
            }
        }

        public static void GreaterThan<T>(T value, T maxValue, string message)
            where T : struct, IComparable<T>
        {
            if (value.CompareTo(maxValue) > 0)
            {
                throw new ValidationException(message, ValidationType.GreaterThan);
            }
        }

        public static void GreaterThanOrEqual<T>(T value, T maxValue, string message)
            where T : struct, IComparable<T>
        {
            if (value.CompareTo(maxValue) >= 0)
            {
                throw new ValidationException(message, ValidationType.GreaterThanOrEqual);
            }
        }

        public static void InCollection<T>(T value, IEnumerable<T> collection, Func<T, T, bool> equals, string message)
        {
            if (collection.Any(item => equals(value, item)))
            {
                throw new ValidationException(message, ValidationType.InCollection);
            }
        }

        public static void InCollection<T>(T value, IEnumerable<T> collection, string message)
        {
            InCollection(value, collection, (param1, param2) => Equals(param1, param2), message);
        }

        public static void NotInCollection<T>(T value, IEnumerable<T> collection, Func<T, T, bool> equals, string message)
        {
            if (!collection.Any(item => equals(value, item)))
            {
                throw new ValidationException(message, ValidationType.NotInCollection);
            }
        }

        public static void NotInCollection<T>(T value, IEnumerable<T> collection, string message)
        {
            NotInCollection(value, collection, (param1, param2) => Equals(param1, param2), message);
        }
    }
}
