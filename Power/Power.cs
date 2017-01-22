namespace Power
{
    public class Power : IPowerCalculator
    {
        public int Calculate(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            var sum = 1;

            for (var i = 0; i < power; i++)
            {
                sum = sum * number;
            }

            return sum;
        }
    }
}
