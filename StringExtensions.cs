using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtensions
    {
        public static double GetNumbers(this string input)
        {
            return double.Parse(Regex.Replace(input, @"[\D\.]", ""));
        }

        public static T ParseToEnum<T>(this string instance)
        {
            return (T)Enum.Parse(typeof(T), instance);
        }

        public static IEnumerable<string> RemoveEmptyEntries(this IEnumerable<string> instance)
        {
            return instance.Where(s => !string.IsNullOrEmpty(s));
        }

        public static string[] Split(this string instance, string separator, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            if (trim)
            {
                var result = instance.Split(separator, options).Select(p => p.Trim()).ToArray();

                if (options == StringSplitOptions.RemoveEmptyEntries)
                    result = result.RemoveEmptyEntries().ToArray();

                return result;
            }
            else
            {
                return instance.Split(separator, options);
            }
        }

        public static string[] Split(this string instance, char separator, int count, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            if (trim)
            {
                var result = instance.Split(separator, count, options).Select(p => p.Trim()).ToArray();
                if (options == StringSplitOptions.RemoveEmptyEntries)
                    result = result.RemoveEmptyEntries().ToArray();

                return result;
            }
            else
            {
                return instance.Split(separator, count, options);
            }
        }

        public static string[] Split(this string instance, char separator, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            return instance.Split(new char[] { separator }, trim, options);
        }

        public static string[] Split(this string instance, char[] separator, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            if (trim)
            {
                var result = instance.Split(separator, options).Select(p => p.Trim()).ToArray();
                if (options == StringSplitOptions.RemoveEmptyEntries)
                    result = result.RemoveEmptyEntries().ToArray();

                return result;
            }
            else
            {
                return instance.Split(separator, options);
            }
        }
    }
}
