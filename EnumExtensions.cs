using Energetic.Enums;
using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class EnumExtensions
    {
        public static IEnumerable<Enum> GetFlags(this Enum input, SortOrder order = SortOrder.Ascending)
        {
            Array values = Enum.GetValues(input.GetType());
            Array.Sort(values);
            if (order == SortOrder.Descending)
                Array.Reverse(values);

            foreach (Enum value in values)
                if (input.HasFlag(value))
                    yield return value;
        }

        public static string GetName<TEnum>(this Enum enumValue)
            where TEnum : Enum
        {
            return Enum.GetName(typeof(TEnum), enumValue) ?? string.Empty;
        }

        public static object GetValue<TEnum>(this TEnum enumValue)
           where TEnum : Enum
        {
            return enumValue;
        }

        public static string GetValueAsString<TEnum>(this TEnum enumValue)
            where TEnum : Enum
        {
            return enumValue.ToString();
        }
    }
}
