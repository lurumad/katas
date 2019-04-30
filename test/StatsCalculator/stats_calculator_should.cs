using Xunit;
using FluentAssertions;

namespace StatsCalculator
{
    public class stats_calculator_should
    {
        [Fact]
        public void determine_the_correct_statistics_given_a_sequence_of_integer_numbers()
        {
            var statsCalculator = new StatsCalculator();
            var numbers = new[] { 6, 9, 15, -2, 92, 11 };
            var stats = statsCalculator.Calculate(numbers);
            stats.MinimunValue.Should().Be(-2);
            stats.MaximumValue.Should().Be(92);
            stats.Average.Should().Be(21.833333333333332);
            stats.NumberOfElements.Should().Be(6);

        }
    }
}
