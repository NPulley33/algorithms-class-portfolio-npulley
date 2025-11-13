using algo_class_portfolio_npulley.Data_Structure_Differences;
using System.Diagnostics;

namespace algo_class_portfolio_npulley
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MaxPQArray<int> priorityQueue = new MaxPQArray<int>();
            priorityQueue.Enqueue(1, 1);
            priorityQueue.Enqueue(2, 2);
            priorityQueue.Enqueue(3, 3);
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());

        }
    }
}
