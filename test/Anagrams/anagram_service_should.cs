using System;
using Xunit;
using FluentAssertions;

namespace Anagrams
{
    public class anagram_service_should
    {
        [Fact]
        public void generate_all_potential_anagrams_of_an_input_string_and_the_input_should_be_contains()
        {
            var input = "biro";
            var service = new AnagramService();
            var anagrams = service.GetAnagramsFrom(input);
            anagrams.Should().Contain(input);
        }

        [Fact]
        public void generate_all_potential_anagrams_of_an_input_string_and_should_contains_bior()
        {
            var input = "biro";
            var service = new AnagramService();
            var anagrams = service.GetAnagramsFrom(input);
            anagrams.Should().Contain("bior");
        }

        [Fact]
        public void generate_all_potential_anagrams_of_an_input_string_and_should_contains_brio()
        {
            var input = "biro";
            var service = new AnagramService();
            var anagrams = service.GetAnagramsFrom(input);
            anagrams.Should().Contain("brio");
        }

        [Fact]
        public void generate_all_potential_anagrams_of_an_input_string_and_the_result_should_be_equivalent()
        {
            var expected = new[] { "biro", "bior", "brio", "broi", "boir", "bori", "ibro", "ibor", "irbo", "irob", "iobr", "iorb", "rbio", "rboi", "ribo", "riob", "roib", "robi", "obir", "obri", "oibr", "oirb", "orbi", "orib" };
            var input = "biro";
            var service = new AnagramService();
            var anagrams = service.GetAnagramsFrom(input);
            anagrams.Should().BeEquivalentTo(expected);
        }
    }
}
