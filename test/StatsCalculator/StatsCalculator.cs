using System.Linq;

namespace StatsCalculator
{
    public class StatsCalculator
    {
        public Stats Calculate(int [] numbers)
        {
            var stats = new Stats
            {
                Average = numbers.Average(),
                NumberOfElements = numbers.Length
            };

            foreach (var number in numbers)
            {
                if (number < stats.MinimunValue)
                {
                    stats.MinimunValue = number;
                }
                if (number > stats.MaximumValue)
                {
                    stats.MaximumValue = number;
                }
            }

            return stats;
        }
    }
}