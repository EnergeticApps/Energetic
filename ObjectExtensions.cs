using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class ObjectExtensions
    {
        ///// <summary>
        ///// Returns the instance if it is not null, or the fallback if the instance is null.
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="instance"></param>
        ///// <param name="fallBackValue"></param>
        ///// <param name="alternatives"></param>
        ///// <returns></returns>
        //public static T Coalesce<T>(this T? instance, T fallBackValue, params T[] alternatives)
        //    where T : class
        //{
        //    if (!(instance is null))
        //        return instance!;

        //    for (int i = 0; i < alternatives.Length; i++)
        //    {
        //        if (!(alternatives[i] is null))
        //            return alternatives[i];
        //    }

        //    return fallBackValue;
        //}


        //public static T Coalesce<T>(this T? instance, T fallBackValue, params T?[] alternatives)
        //    where T : struct
        //{
        //    if (instance.HasValue)
        //        return instance.Value;

        //    for (int i = 0; i < alternatives.Length; i++)
        //    {
        //        if (alternatives[i].HasValue)
        //            return alternatives[i]!.Value;
        //    }

        //    return fallBackValue;
        //}
    }
}
