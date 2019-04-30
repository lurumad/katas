using FluentAssertions;
using Xunit;

namespace FizzBuzz
{
    public class fizzbuzz_should
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void get_back_a_string_representing_the_number_when_i_fizzbuzz(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(number);
            output.Should().Be(number.ToString());
        }

        [Fact]
        public void get_back_a_string_fizz_when_i_fizzbuzz_3()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(3);
            output.Should().Be("fizz");
        }

        [Fact]
        public void get_back_a_string_fizz_when_i_fizzbuzz_a_number_divisible_by_3()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(6);
            output.Should().Be("fizz");
        }

        [Fact]
        public void get_back_a_string_buzz_when_i_fizzbuzz_5()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(5);
            output.Should().Be("buzz");
        }

        [Fact]
        public void get_back_a_string_fizz_when_i_fizzbuzz_a_number_divisible_by_5()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(25);
            output.Should().Be("buzz");
        }

        [Fact]
        public void get_back_a_string_fizz_when_i_fizzbuzz_a_number_divisible_by_3_and_5()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetOutput(15);
            output.Should().Be("fizzbuzz");
        }
    }
}
