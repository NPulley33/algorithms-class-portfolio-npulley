using algo_class_portfolio_npulley;
using algo_class_portfolio_npulley.Data_Structure_Differences;

namespace UnitTests
{
    //Following AAA testing stadards
    public class DataStructureTests
    {
        [Fact]
        public void BinaryTreeCreateTest()
        { 
            
            BinaryTree t = new BinaryTree();

            Assert.Null(t.Head);



            BinaryTree t2 = new BinaryTree(2);

            Assert.Equal(2, t2.Head.Data);
            Assert.Null(t2.Head.Left);
            Assert.Null(t2.Head.Right);

        }

        [Fact]
        public void BinaryTreeAddTest()
        {
            BinaryTree t = new BinaryTree();

            t.Insert(5);
            t.Insert(2);
            t.Insert(7);

            Assert.Equal(5, t.Head.Data);
            Assert.Equal(2, t.Head.Left.Data);
            Assert.Equal(7, t.Head.Right.Data);
        }

        [Fact]
        public void BinaryTreeAddDataTest()
        {
            BinaryTree t = new BinaryTree();
            int[] data = { 5, 6, 2, 9, 1, 4, 3, 0, 7, 8};

            for (int i = 0; i < data.Length; i++)
            {
                t.Insert(data[i]);
            }

            Assert.Equal(5, t.Head.Data);
            Assert.Equal(2, t.Head.Left.Data);
            Assert.Equal(6, t.Head.Right.Data);
            Assert.Equal(1, t.Head.Left.Left.Data);
            Assert.Equal(0, t.Head.Left.Left.Left.Data);
            Assert.Equal(4, t.Head.Left.Right.Data);
            Assert.Equal(3, t.Head.Left.Right.Left.Data);
            Assert.Equal(9, t.Head.Right.Right.Data);
            Assert.Equal(7, t.Head.Right.Right.Left.Data);
            Assert.Equal(8, t.Head.Right.Right.Left.Right.Data);


        }
    }
}
