using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    //TODO: write test cases
    public class Graph
    {
        private List<int>[] graph;

        public int Verticies { get; set; }
        public int Edges { get; set; }

        public Graph() : this(10) { }

        public Graph(int verticies)
        {
            this.Verticies = verticies;
            graph = new List<int>[verticies];
        }

        public void AddEdge(int v, int w)
        { 
            if (graph[v] == null) graph[v] = new List<int>();
            if (graph[w] == null) graph[w] = new List<int>();

            if (graph[v].Contains(w) || graph[w].Contains(v)) return; 

            graph[v].Add(w);
            graph[w].Add(v);
        }

        public int Adjacent(int v) => Degree(v);

        public int Degree(int v) => graph[v].Count;

        public int MaxDegree()
        {
            int max = 0;
            for (int i = 0; i < graph.Length; i++)
            { 
                if (graph[i].Count > max) max = graph[i].Count;
            }
            return max;
        }

        public int AverageDegree()
        {
            int sum = 0;
            for (int i = 0; i < graph.Length; i++)
            {
                sum += graph[i].Count;
            }
            return sum/graph.Length;
        }

        public int NumberOfSelfLoops()
        {
            int num = 0;
            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[i].Contains(i)) num++;
            }
            return num;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[i] == null) graph[i] = new List<int>();
                sb.Append($"Vertex: {i} | Edges: ");
                for (int j = 0; j < graph[i].Count; j++)
                {
                    if (graph[i].Count == 0) sb.Append($"0");
                    else sb.Append($"{graph[i].ElementAt(j)}");

                    if (j < graph[i].Count - 1) sb.Append(", ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}
