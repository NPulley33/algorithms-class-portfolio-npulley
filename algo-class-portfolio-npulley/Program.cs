using algo_class_portfolio_npulley.Data_Structure_Differences;
using System.Diagnostics;

namespace algo_class_portfolio_npulley
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine();

            Graph g = new Graph(10);
            Console.WriteLine(g.ToString());


            g.AddEdge(1,5);
            g.AddEdge(2,5);
            g.AddEdge(1,8);
            g.AddEdge(0,7);

            Console.WriteLine();
            Console.WriteLine(g.ToString());
        }
    }
}
