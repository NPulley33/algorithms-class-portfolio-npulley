using System.Text;
using static System.Console;

namespace HanoiTower
{
    public class HanoiEngine
    {
        public Stack<int> Tower1;
        public Stack<int> Tower2;
        public Stack<int> Tower3;

        public HanoiEngine() 
        { 
            Tower1 = new Stack<int>();
            Tower2 = new Stack<int>();
            Tower3 = new Stack<int>();

            Start();
            RunAutoSolver();
        }

        private void Start()
        {
            //ask how many rings player wants (limit 3-5)
            //add rings to tower 1
            
            bool validInput = false;
            string input = "";
            while (!validInput)
            {
                WriteLine("How many rings? Pick 3-5");
                input = ReadLine();
                if (input == "3" || input == "4" || input == "5")
                { 
                    validInput = true;
                    break;
                }
            }

            int numRings = 0;
            switch(input)
            {
                case "3":
                    numRings = 3;
                    break;
                case "4":
                    numRings = 4;
                    break;
                case "5":
                    numRings = 5;
                    break;
            }

            AddRings(numRings);
            Display();

            Run();
        }

        private void Run()
        {
            while (IsComplete() == false)
            {
                bool validMove = false;
                Stack<int> toStack = new Stack<int>();
                Stack<int> fromStack = new Stack<int>();
                int from = 0;
                int to = 0;

                while (validMove == false)
                { 
                    var stacks = PickStacks();

                    from = stacks.from;
                    to = stacks.to;

                    if (from == to)
                    {
                        WriteLine("invalid move: same stack");
                        continue;
                    }

                    if (CheckEmptyTo(to))
                    {
                        validMove = true;
                        continue;
                    }

                    validMove = CheckSmaller(from, to);
                    WriteLine(validMove);

                    if (validMove == false) WriteLine("Invalid move: bigger onto smaller");
                    //validMove = true;
                }

                //toStack.Push((int)fromStack.Pop()); //does not work
                MoveDisc(from, to);
                Display();

            }
            WriteLine("Game Over, you win");
            WriteLine("Press any key to see the auto solver");
            ReadLine();
        }

        private bool CheckEmptyTo(int to)
        {
            switch (to)
            {
                case 1:
                    if (Tower1.Size() == 0) { return true; }
                    break;
                case 2:
                    if (Tower2.Size() == 0) { return true; }
                    break;
                case 3:
                    if (Tower3.Size() == 0) { return true; }
                    break;
            }
            return false;
        }

        private bool CheckSmaller(int from, int to)
        {
            switch (from)
            {
                case 1:
                    if (to == 2 && Tower2.Peek() > Tower1.Peek()) return true;
                    if (to == 3 && Tower3.Peek() > Tower1.Peek()) return true;
                    break;
                case 2:
                    if (to == 1 && Tower1.Peek() > Tower2.Peek()) return true;
                    if (to == 3 && Tower3.Peek() > Tower2.Peek()) return true;
                    break;
                case 3:
                    if (to == 1 && Tower1.Peek() > Tower3.Peek()) return true;
                    if (to == 2 && Tower2.Peek() > Tower3.Peek()) return true;
                    break;
            }
            return false;
        }

        private void MoveDisc(int from, int to)
        {
            switch (from)
            {
                case 1:
                    if (to == 2) Tower2.Push((int)Tower1.Pop());
                    if (to == 3) Tower3.Push((int)Tower1.Pop());
                    break;
                case 2:
                    if (to == 1) Tower1.Push((int)Tower2.Pop());
                    if (to == 3) Tower3.Push((int)Tower2.Pop());
                    break;
                case 3:
                    if (to == 1) Tower1.Push((int)Tower3.Pop());
                    if (to == 2) Tower2.Push((int)Tower3.Pop());
                    break;
            }
        }

        private (int from, int to) PickStacks()
        {
            string stackFrom = string.Empty;
            while (ValidInput(stackFrom) == false)
            {
                WriteLine("Select a stack to move from");
                stackFrom = ReadLine();
            }

            string stackTo = string.Empty;
            while (ValidInput(stackTo) == false)
            {
                WriteLine("Select a stack to move to");
                stackTo = ReadLine();
            }

            int from = Convert.ToInt32(stackFrom);
            int to = Convert.ToInt32(stackTo);
            return (from, to);
        }

        private bool ValidInput(string input)
        {
            return (input == "1" || input == "2" || input == "3");
        }


        private void AddRings(int numRings)
        {
            for (int i = numRings; i > 0; i--)
            { 
                Tower1.Push(i);
            }
        }

        private void Display()
        {
            StringBuilder sb = new StringBuilder();

            string tower1Top = "";
            if (Tower1.Peek() == null || Tower1.Size() == 0) tower1Top = "empty";
            else tower1Top = $"{Tower1.Peek()}";

            string tower2Top = "";
            if (Tower2.Peek() == null || Tower2.Size() == 0) tower2Top = "empty";
            else tower2Top = $"{Tower2.Peek()}";

            string tower3Top = "";
            if (Tower3.Peek() == null || Tower3.Size() == 0) tower3Top = "empty";
            else tower3Top = $"{Tower3.Peek()}";

            sb.Append($"Tower 1 Top: {tower1Top} \t \t");
            sb.Append($"Tower 2 Top: {tower2Top} \t");
            sb.Append($"Tower 3 Top: {tower3Top} \t");
            sb.AppendLine();
            sb.Append($"Tower 1 Total: {Tower1.Size()} \t");
            sb.Append($"Tower 2 Total: {Tower2.Size()} \t");
            sb.Append($"Tower 3 Total: {Tower3.Size()} \t");

            WriteLine(sb.ToString());
        }

        private bool IsComplete()
        { 
            if (Tower1.IsEmpty() == false) return false;
            if (Tower2.IsEmpty() == false) return false;
            return true;
        }

        private void RunAutoSolver()
        {
            AddRings(3);
            AutoSolver solver = new AutoSolver();
            solver.AddStep(1, 3);
            solver.AddStep(1, 2);
            solver.AddStep(3, 2);
            solver.AddStep(1, 3);
            solver.AddStep(2, 1);
            solver.AddStep(2, 3);
            solver.AddStep(1, 3);
            WriteLine("Start:");
            Display();
            WriteLine();

            int i = 1;
            while (solver.steps.Size() > 0)
            {
                HanoiAction step = solver.DoStep();
                int to = step.to;
                int from = step.from;

                MoveDisc(from, to);
                WriteLine($"Step: {i}");
                Display();
                WriteLine();
                i++;
            }
        }
    }

    internal class AutoSolver
    {
        public Queue<HanoiAction> steps = new Queue<HanoiAction>();

        public AutoSolver()
        {
        }

        public void AddStep(int from, int to)
        {
            steps.Enqueue(new HanoiAction(from, to));
        }

        public HanoiAction DoStep() => (HanoiAction)steps.Dequeue();
    }

    internal struct HanoiAction
    {
        public int to;
        public int from;

        public HanoiAction(int from, int to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
