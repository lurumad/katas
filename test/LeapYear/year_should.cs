using FluentAssertions;
using Xunit;

namespace LeapYear
{
    public class year
    {
        [Fact]
        public void is_a_typical_leap_year()
        {
            var year = new Year();
            year.IsLeap(1996).Should().Be(true);
        }

        [Fact]
        public void is_typical_common_year()
        {
            var year = new Year();
            year.IsLeap(2001).Should().Be(false);
        }

        [Fact]
        public void is_an_atypical_common_year()
        {
            var year = new Year();
            year.IsLeap(2100).Should().Be(false);
        }

        [Fact]
        public void is_an_atypical_leap_year()
        {
            var year = new Year();
            year.IsLeap(2000).Should().Be(true);
        }
    }
}
