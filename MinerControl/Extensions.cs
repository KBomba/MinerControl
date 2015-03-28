using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace MinerControl
{
    public static class Extensions
    {
        public static string FormatTime(this TimeSpan timeSpan, bool zeroAsEmpty = false)
        {
            if (timeSpan == TimeSpan.Zero && zeroAsEmpty)
                return string.Empty;

            if (timeSpan < TimeSpan.Zero && !zeroAsEmpty)
                return "00:00:00";

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
            const NumberStyles style = NumberStyles.Any;
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

        private static double[] GetDecimalRepresentation(this string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            HashAlgorithm hashAlgo = new SHA1Managed();
            byte[] hash = hashAlgo.ComputeHash(bytes);
            byte xor1 = 170;
            byte xor2 = 85;
            byte xor3 = 127;
            foreach (byte b in hash)
            {
                xor1 ^= b;
                xor2 ^= b;
                xor3 ^= b;
            }

            return new []{ xor1/ 255.0, xor2/765.0, xor3/765.0 };
        }

        private static Color GetColorRepresentation(this double[] d)
        {
            // Decimal number to Color by using HSL, HSL to RGB taken from: 
            // http://www.codeproject.com/Articles/19045/Manipulating-colors-in-NET-Part
            double hk = d[0];
            double l = (1.0/3.0) + d[1];
            double s = (2.0/3.0) + d[2];

            double q = (l < 0.5) ? (l * (1.0 + s)) : (l + s - (l * s));
            double p = (2.0 * l) - q;

            double[] T = new double[3];
            T[0] = hk + (1.0 / 3.0);    // Tr
            T[1] = hk;                // Tb
            T[2] = hk - (1.0 / 3.0);    // Tg

            for (int i = 0; i < 3; i++)
            {
                if (T[i] < 0) T[i] += 1.0;
                if (T[i] > 1) T[i] -= 1.0;

                if ((T[i] * 6) < 1)
                {
                    T[i] = p + ((q - p) * 6.0 * T[i]);
                }
                else if ((T[i] * 2.0) < 1)
                {
                    T[i] = q;
                }
                else if ((T[i] * 3.0) < 2)
                {
                    T[i] = p + (q - p) * ((2.0 / 3.0) - T[i]) * 6.0;
                }
                else T[i] = p;
            }

            return Color.FromArgb((int)(T[0] * 255.0), (int)(T[2] * 255.0), (int)(T[1] * 255.0));
        }

        public static Color GetColorRepresentation(this string s)
        {
            return s.GetDecimalRepresentation().GetColorRepresentation();
        }

        public static string Remove(this string s, string removal)
        {
            return s.Replace(removal, String.Empty).Trim();
        }

        public static string Remove(this string s, char removal)
        {
            return s.Replace(removal, String.Empty[0]).Trim();
        }
    }
}