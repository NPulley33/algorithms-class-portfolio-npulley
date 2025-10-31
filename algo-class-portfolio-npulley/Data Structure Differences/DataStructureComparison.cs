using System;
using System.Collections.Generic;
using KarlTeaching;

namespace algo_class_portfolio_npulley.Data_Structure_Differences
{
    public static class DataStructureComparison
    {
        //an array can be filled with values on initilization, unlike other data structures
        static int[] array = new int[] { 1, 2, 3, 4, 5};
        static Dictionary<string, int> map = new Dictionary<string, int>();

        static Stack<int> stack = new Stack<int>();
        static Queue<int> queue = new Queue<int>();

        static DataStructureComparison()
        { 
            InitMap();
            InitQueue();
            InitStack();
        }


        public static void InitMap()
        {
            map.Add("first", 1);
            map.Add("second", 2);
            map.Add("third", 3);
            map.Add("fourth", 4);
            map.Add("fifth", 5);
        }

        public static void InitStack()
        { 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
        }

        public static void InitQueue()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
        }

    }
}
