using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns the instance if it is not null, or the alternatives in order of preference if the instance is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">An object</param>
        /// <param name="alternative">The second choice, i.e. best alternative to the value.</param>
        /// <param name="alternatives">The other alternatives in order of preference</param>
        /// <returns></returns>
        public static T Coalesce<T>(this T? value, T alternative, params T[] alternatives)
            where T : class
        {
            if (!(value is null))
                return value!;

            if (!(alternative is null))
                return alternative!;

            for (int i = 0; i < alternatives.Length; i++)
            {
                if (!(alternatives[i] is null))
                    return alternatives[i];
            }

            throw new InvalidOperationException("No non-null alternative was provided.");
        }


        public static T Coalesce<T>(this T? value, T? alternative, params T?[] alternatives)
            where T : struct
        {
            if (value.HasValue)
                return value.Value;

            if (alternative.HasValue)
                return alternative.Value;

            for (int i = 0; i < alternatives.Length; i++)
            {
                if (alternatives[i].HasValue)
                    return alternatives[i]!.Value;
            }

            throw new InvalidOperationException("No non-null alternative was provided.");
        }
    }
}
