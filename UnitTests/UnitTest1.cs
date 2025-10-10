using algo_class_portfolio_npulley;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PeekTest()
        {
            LLQueue<int> q = new LLQueue<int>();
            q.Push(1);
            Assert.Equal(1, q.Peek());
        }

        [Fact]
        public void PopTest()
        {
            LLQueue<int> q = new LLQueue<int>();
            q.Push(1);
            q.Pop();
            Assert.True(q.Empty());
        }

        [Fact]
        public void DrainTest()
        {
            LLQueue<int> q = new LLQueue<int>();

            q.Push(1);
            q.Push(2);

            Assert.Equal(1, q.Peek());

            q.Pop();

            Assert.Equal(2, q.Peek());
        }
    }
}