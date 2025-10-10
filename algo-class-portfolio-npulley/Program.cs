namespace algo_class_portfolio_npulley
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5 };
            FisherYatesShuffle.Shuffle(test);

            foreach (int i in test)
            {
                Console.WriteLine(i);
            }

        }
    }
}
