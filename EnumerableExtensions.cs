using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace System.Collections.Generic
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks to see if all the elements in the enumerable are the same as all the elements in the other enumerable, including their count, and ignoring their order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="other"></param>
        /// <returns>True if the items of the two enumerables are exactly the same. True if any of the elements is different between the two enumerables,
        /// or if the count of each enumerable is different to the other. </returns>
        public static bool AreAllTheSameAs<T>(this IEnumerable<T>? enumerable, IEnumerable<T>? other)
        {
            if (enumerable.IsNullOrEmpty() && other.IsNullOrEmpty())
                return true;

            return enumerable?.Count() == other?.Count() && 
                !(enumerable.Except(other).Any() || other.Except(enumerable).Any());
        }

        /// <summary>
        /// Checks to see if all the elements in the enumerable are the same as all the elements in the other enumerable, including their count, and ignoring their order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="other"></param>
        /// <returns>True if any of the elements is different between the two enumerables, or if the count of each enumerable is different to the other. False
        /// if the items of the two enumerables are exactly the same.</returns>
        public static bool AreNotTheSameAs<T>(this IEnumerable<T>? enumerable, IEnumerable<T>? other)
        {
            return !AreAllTheSameAs(enumerable, other);
        }

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?>? enumerable)
            where T : class
        {
            if (enumerable is null)
                return new List<T>();

            return enumerable.Where(item => item is { }).Cast<T>();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T>? enumerable)
        {
            return enumerable is null || !enumerable.Any();
        }

        public static bool IsNullOrEmpty(this IEnumerable? enumerable)
        {
            if (enumerable is { })
            {
                foreach (object _ in enumerable)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? enumerable)
        {
            return !enumerable.IsNullOrEmpty();
        }

        public static bool IsNotNullOrEmpty(this IEnumerable? enumerable)
        {
            return !enumerable.IsNullOrEmpty();
        }
    }
}
