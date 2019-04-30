namespace Fibonacci
{
    public class Fibonacci
    {
        public int Calculate(int index)
        {
            if (index == 1) return 1;
            if (index == 0) return 0;

            return Calculate(index - 1) + Calculate(index - 2);
        }
    }
}
