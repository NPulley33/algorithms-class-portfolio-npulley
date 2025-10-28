using static System.Console;

namespace HanoiTower
{
    public class Program
    {
        static void Main(string[] args)
        {
            HanoiEngine engine = new HanoiEngine();
            //engine.Start();
        }

        public static void LinkedListTests()
        {
            HanoiTower.LinkedList<int> test = new HanoiTower.LinkedList<int>();
            Iterator<int> LLIterator = test.Iterator();

            test.AddFirst(1);
            //Console.WriteLine(test.GetFirst());
            test.AddLast(5);
            //Console.WriteLine(test.GetLast());
            test.InsertAt(1, 2);
            //Console.WriteLine(test.GetAt(1));
            test.InsertAt(2, 3);
            test.InsertAt(3, 4);
            test.AddLast(6);


            while (LLIterator.IsDone() == false)
            {
                WriteLine(LLIterator.Next());
            }
        }

        public static void StackTest()
        {
            HanoiTower.Stack<int> test = new HanoiTower.Stack<int>();
            StackIterator<int> sIterator = new StackIterator<int>(test);

            test.Push(1);
            test.Push(2);
            test.Push(3);
            test.Push(4);
            test.Push(5);

            while (test.IsEmpty() == false)
            {
                WriteLine(test.Pop());
            }
        }

        public static void QueueTest()
        {
            HanoiTower.Queue<int> test = new HanoiTower.Queue<int>();
            QueueIterator<int> qIterator = new QueueIterator<int>(test);

            test.Enqueue(1);
            test.Enqueue(2);
            test.Enqueue(3);
            test.Enqueue(4);
            test.Enqueue(5);

            while (test.IsEmpty() == false)
            {
                WriteLine(test.Dequeue());
            }
        }
    }
}
