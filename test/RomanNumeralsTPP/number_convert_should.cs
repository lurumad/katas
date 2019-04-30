using FluentAssertions;
using Xunit;

namespace RomanNumeralsTPP
{
    public class roman_converter_should
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(40, "XL")]
        [InlineData(44, "XLIV")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(1980, "MCMLXXX")]
        public void convert_number_to_roman(int number, string expected)
        {
            var roman = new RomanConverter().Convert(number);
            roman.Should().Be(expected);
        }
    }
}
