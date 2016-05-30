using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbro {
    public static class NumberToWords {

        private static readonly string[] UnitsMap = { "nul", "unu", "du", "tri", "kvar", "kvin", "ses", "sep", "ok", "naŭ" };
        private static readonly Dictionary<int, string> TensMap = new Dictionary<int, string>
        {{ 1000000000, " miliardo" }, { 1000000 , " miliono" }, { 1000, " mil" }, { 100, "cent" }, { 10, "dek" }, { 1, null }};

        private const string minus = "minus";

        public static string Convert(int number) {
            var words = number < 0 ? minus + " " : string.Empty;
            number = Math.Abs (number);
            words += number <= 1 ? UnitsMap[number] : ConvertInside (number);
            return words;
        }

        // todo: Rename this method really...
        private static string ConvertInside(int number) {
            if (number == 1)
                return string.Empty;

            var parts = new List<string> ();
            foreach (var item in TensMap.Where (x => number / x.Key > 0)) {
                parts.Add (!string.IsNullOrEmpty (item.Value)
                    ? $"{ConvertInside (number / item.Key)}{TrimMil (item, number)}"
                    : UnitsMap[number]);
                number %= item.Key;
            }

            var toWords = string.Join (" ", parts.ToArray ()).TrimStart (' ');
            return toWords;
        }

        private static string TrimMil(KeyValuePair<int, string> item, int number) {
            if (item.Key != 1000)
                return item.Value;
            var quotient = number / item.Key % 10;
            return quotient < 2 || quotient > 9
                ? item.Value
                : item.Value.TrimStart (' ');
        }

        public static string ConvertToOrdinal(int number) {
            return Convert (number) + "a";
        }

        public static string ToWords(this int number) {
            return Convert (number);
        }

        public static string ToOrdinalWords(this int number) {
            return ConvertToOrdinal (number);
        }
    }
}