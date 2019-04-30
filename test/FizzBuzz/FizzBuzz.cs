namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetOutput(int number)
        {
            var multipleOfThree = number % 3 == 0;
            var multipleOfFive = number % 5 == 0;

            if (multipleOfThree & multipleOfFive)
            {
                return "fizzbuzz";
            }
            else if (multipleOfThree)
            {
                return "fizz";
            }
            else if (multipleOfFive)
            {
                return "buzz";
            }

            return number.ToString();
        }
    }
}
