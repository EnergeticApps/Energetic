using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// Extracts any numbers (represented by the characters 0-9 and the decimal point "." symbol) from a string.
        /// a <see cref="double"/>.
        /// </summary>
        /// <param name="input">A string containing some numbers.</param>
        /// <returns>A string containing only the numbers (including decimal points)</returns>
        /// <remarks>This will work if the string has multiple decimal points, like a version number. The numbers will
        /// be in the same order as they were in the input string.</remarks>
        /// <example>input = "hello1234"; output = "1234"</example>
        /// <example>input = "version 1.6.234"; output = "1.6.234"</example>
        public static string GetNumbers(this string input)
        {
            return Regex.Replace(input, @"[\D\.]", "");
        }

        /// <summary>
        /// Where <typeparamref name="T"/> is an <see cref="Enum"/>, returns the enumeration value represented by the input string.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/>.</typeparam>
        /// <param name="value">A string that can be parsed to a value of the enum <typeparamref name="T"/>.</param>
        public static T ParseToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }


        /// <summary>
        /// Removes all the items that are null or empty strings from the enumerable.
        /// </summary>
        /// <param name="value">An enumerable of strings.</param>
        /// <returns>An enumerable resembling the input enumerable but with all the null and empty items removed.</returns>
        public static IEnumerable<string> WhereNotNullOrEmpty(this IEnumerable<string> value)
        {
            return value.Where(s => !string.IsNullOrEmpty(s));
        }

        /// <summary>
        /// Splits the input string into an array of strings at every occurance of the separator.
        /// </summary>
        /// <param name="value">The string to split</param>
        /// <param name="separator">The string that will be used to separate each item. The separator will be removed from the output.</param>
        /// <param name="trim">True to strip the leading and trailing whitespace from the items after they have been split.</param>
        /// <param name="options">Options to remove empty entries or leave them in the output.</param>
        public static string[] Split(this string value, string separator, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            if (trim)
            {
                var result = value.Split(separator, options).Select(p => p.Trim()).ToArray();

                if (options == StringSplitOptions.RemoveEmptyEntries)
                    result = result.WhereNotNullOrEmpty().ToArray();

                return result;
            }
            else
            {
                return value.Split(separator, options);
            }
        }

        /// <summary>
        /// Splits the input string into an array of strings at every occurance of the separator.
        /// </summary>
        /// <param name="value">The string to split</param>
        /// <param name="separator">The character that will be used to separate each item. The separator will be removed from the output.</param>
        /// <param name="trim">True to strip the leading and trailing whitespace from the items after they have been split.</param>
        /// <param name="options">Options to remove empty entries or leave them in the output.</param>
        public static string[] Split(this string value, char separator, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            return value.Split(new char[] { separator }, trim, options);
        }

        /// <summary>
        /// Splits the input string into an array of strings at every occurance of the separator.
        /// </summary>
        /// <param name="value">The string to split</param>
        /// <param name="separators">The characters that will be used to separate each item. The separators will be removed from the output.</param>
        /// <param name="trim">True to strip the leading and trailing whitespace from the items after they have been split.</param>
        /// <param name="options">Options to remove empty entries or leave them in the output.</param>
        public static string[] Split(this string value, char[] separators, bool trim, StringSplitOptions options = StringSplitOptions.None)
        {
            if (trim)
            {
                var result = value.Split(separators, options).Select(p => p.Trim()).ToArray();
                if (options == StringSplitOptions.RemoveEmptyEntries)
                    result = result.WhereNotNullOrEmpty().ToArray();

                return result;
            }
            else
            {
                return value.Split(separators, options);
            }
        }
    }
}
