using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace RomanNumerals
{
    public class number_convert
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(101,"CI")]
        [InlineData(2009, "MMIX")]
        public void when_i_pass_a_number_i_get_back_a_string_representing_the_roman_number(int value, string expected)
        {
            var numberConvert = new NumberConvert();
            var roman = numberConvert.ArabicToRoman(value);
            roman.Should().Be(expected);
        }
    }

    public class NumberConvert
    {
        public Dictionary<int, string> table = new Dictionary<int, string>
        {
            { 1000 , "M" },
            { 900 , "CM" },
            { 500 , "D" },
            { 400 , "CD" },
            { 100 , "C" },
            { 90 , "XC" },
            { 50 , "L" },
            { 40 , "XL" },
            { 10 , "X" },
            { 9 , "IX" },
            { 5 , "V" },
            { 4 , "IV" },
            { 1 , "I" }
        };

        public string ArabicToRoman(int arabic)
        {
            var roman = new StringBuilder();

            for (int i = 0; i < table.Keys.Count; i++)
            {
                arabic = AppendRomanNumber(roman, arabic, table.ElementAt(i).Key);
            }

            return roman.ToString();
        }

        private int AppendRomanNumber(StringBuilder romanNumber, int arabic, int value)
        {
            int remaining = arabic;

            if (remaining < value)
            {
                return remaining;
            }

            romanNumber.Append(table[value]);
            remaining -= value;
            
            return AppendRomanNumber(romanNumber, remaining, value);
        }
    }
}
