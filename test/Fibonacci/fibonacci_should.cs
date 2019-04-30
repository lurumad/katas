using FluentAssertions;
using Xunit;

namespace Fibonacci
{
    public class fibonacci_should
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        public void get_the_fibonacci_number_at_the_index(int index, int value)
        {
            var fibonacci = new Fibonacci();
            fibonacci.Calculate(index).Should().Be(value);
        }
    }
}
