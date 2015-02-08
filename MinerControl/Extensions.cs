using System;
using System.Collections.Generic;
using System.Globalization;

namespace MinerControl
{
    public static class Extensions
    {
        public static string FormatTime(this TimeSpan timeSpan, bool zeroAsEmpty = false)
        {
            if (timeSpan == TimeSpan.Zero && zeroAsEmpty)
                return string.Empty;

            return timeSpan.TotalDays > 1
                ? timeSpan.ToString(@"dd\.hh\:mm\:ss")
                : timeSpan.ToString(@"hh\:mm\:ss");
        }

        public static string FormatTime(this TimeSpan? timeSpan)
        {
            if (!timeSpan.HasValue)
                return string.Empty;

            return timeSpan.Value.FormatTime();
        }

        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
        {
            foreach (T item in items)
                list.Add(item);
        }

        public static decimal ExtractDecimal(this object raw)
        {
            decimal? decimalValue = raw as decimal?;
            if (decimalValue.HasValue) return decimalValue.Value;

            double? doubleValue = raw as double?;
            if (doubleValue.HasValue) return (decimal) doubleValue.Value;

            float? floatValue = raw as float?;
            if (floatValue.HasValue) return (decimal) floatValue.Value;

            long? longValue = raw as long?;
            if (longValue.HasValue) return longValue.Value;

            int? intValue = raw as int?;
            if (intValue.HasValue) return intValue.Value;

            decimal parseValue;
            const NumberStyles style = NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            if (decimal.TryParse(raw.ToString(), style, culture, out parseValue)) return parseValue;

            return 0;
        }

        public static string GetString(this IDictionary<string, object> data, string key)
        {
            if (!data.ContainsKey(key)) return null;
            return data[key] as string;
        }

        public static int? GetInt(this IDictionary<string, object> data, string key)
        {
            if (!data.ContainsKey(key)) return null;
            return data[key] is int ? (int) data[key] : 0;
        }
    }
}