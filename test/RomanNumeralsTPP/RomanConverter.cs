using System.Collections.Generic;

namespace RomanNumeralsTPP
{
    public class RomanConverter
    {
        public static readonly IDictionary<int, string> mappings =
            new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

        public string Convert(int number)
        {
            var result = string.Empty;

            foreach (var mapping in mappings)
            {
                while (number >= mapping.Key)
                {
                    number -= mapping.Key;
                    result += mapping.Value;
                }
            }

            return result;
        }
    }
}
