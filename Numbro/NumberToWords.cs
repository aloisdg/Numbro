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
            if (number < 0)
                return $"{minus} {ConvertInside (-number)}";
            return number <= 1 ? UnitsMap[number] : ConvertInside (number);
        }

        // todo: Rename this method really...
        private static string ConvertInside(int number) {
            if (number == 1)
                return string.Empty;

            var parts = new List<string> ();
            foreach (var item in TensMap.Where (x => number / x.Key > 0)) {
                parts.Add (!string.IsNullOrEmpty (item.Value)
                    ? $"{ConvertInside (number / item.Key)}{item.Value}"
                    : UnitsMap[number]);
                number %= item.Key;
            }

            var toWords = string.Join (" ", parts.ToArray ()).TrimStart (' ');
            return toWords;
        }

        public static string ToWords(this int number) {
            return Convert (number);
        }
    }
}