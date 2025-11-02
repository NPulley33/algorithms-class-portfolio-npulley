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
            //init towers and start game
            Tower1 = new Stack<int>();
            Tower2 = new Stack<int>();
            Tower3 = new Stack<int>();

            Start();
            //ruun auto solver after game is finished to simulate a perfect game
            RunAutoSolver();
        }

        private void Start()
        {
            //ask how many rings player wants (limit 3-5)
            //add rings to tower 1
            
            //making sure input is valid
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
            //init rings based on input
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
            //checks if every other tower is empty except the far right tower (tower 3)
            while (IsComplete() == false)
            {
                bool validMove = false;
                Stack<int> toStack = new Stack<int>();
                Stack<int> fromStack = new Stack<int>();
                int from = 0;
                int to = 0;

                //makes sure you can make the move the player attempts to
                while (validMove == false)
                { 
                    //get stacks from player input
                    var stacks = PickStacks();

                    from = stacks.from;
                    to = stacks.to;

                    if (from == to)
                    {
                        WriteLine("invalid move: same stack");
                        continue;
                    }
                    //can automatically move to an empty tower without checking ring size
                    if (CheckEmptyTo(to))
                    {
                        validMove = true;
                        continue;
                    }

                    //checks if the tower you intend to move has a ring bigger than the one you're moving
                    validMove = CheckSmaller(from, to);
                    WriteLine(validMove);

                    if (validMove == false) WriteLine("Invalid move: bigger onto smaller");
                }

                MoveDisc(from, to);
                Display();

            }
            WriteLine("Game Over, you win");
            WriteLine("Press any key to see the auto solver");
            ReadLine();
        }

        /// <summary>
        /// checks if the tower you intent to move a ring to is empty
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
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

        /// <summary>
        /// checks to make sure you can move a ring to the indicated stack
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
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

        /// <summary>
        /// move a disc from one tower to another tower
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
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

        /// <summary>
        /// reads player input for which stack to move a ring from, and which to move it to
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// checks if the string entered for number of rings is valid
        /// </summary>
        /// <param name="input"></param>
        /// <returns> if the input was valid or not </returns>
        private bool ValidInput(string input)
        {
            return (input == "1" || input == "2" || input == "3");
        }

        /// <summary>
        /// adds rings to tower 1 as a set up
        /// </summary>
        /// <param name="numRings"> number of rings for the game </param>
        private void AddRings(int numRings)
        {
            for (int i = numRings; i > 0; i--)
            { 
                Tower1.Push(i);
            }
        }

        /// <summary>
        /// displays tower information on the screen
        /// </summary>
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

        /// <summary>
        /// checks if first 2 toweres are empty. If the first two towers are empty, all discs are on the leftmost tower, resulting in a win
        /// </summary>
        /// <returns> if Towers 1 & 2 are empty </returns>
        private bool IsComplete()
        {
            //does not check if rings are in correct order as that is checked somewhere else
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

    //structure to hold information about moving rings automatically
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
