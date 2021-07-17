namespace _04.BinarySearchTree.Tests
{
    using NUnit.Framework;
    using _04.BinarySearchTree;

    public class Tests
    {
        private IAbstractBinarySearchTree<int> _bst;

        [SetUp]
        public void InitializeBST()
        {
            this._bst = new BinarySearchTree<int>();
            this._bst.Insert(12);
            this._bst.Insert(21);
            this._bst.Insert(5);
            this._bst.Insert(1);
            this._bst.Insert(8);
            this._bst.Insert(18);
            this._bst.Insert(23);
        }


        [Test]
        public void TestLeftSideBST()
        {
            var root = this._bst.Root;
            var left = root.LeftChild;
            var left_left = left.LeftChild;
            var left_right = left.RightChild;

            Assert.AreEqual(12, root.Value);
            Assert.AreEqual(5, left.Value);
            Assert.AreEqual(1, left_left.Value);
            Assert.AreEqual(8, left_right.Value);
        }

        [Test]
        public void TestRightSideBST()
        {
            var root = this._bst.Root;
            var right = root.RightChild;
            var right_left = right.LeftChild;
            var right_right = right.RightChild;

            Assert.AreEqual(12, root.Value);
            Assert.AreEqual(21, right.Value);
            Assert.AreEqual(18, right_left.Value);
            Assert.AreEqual(23, right_right.Value);
        }

        [Test]
        public void TestSearchCheckReturnedTreeStructure()
        {
            var searched = this._bst.Search(5);
            var root = searched.Root;
            var left = searched.LeftChild;
            var right = searched.RightChild;

            Assert.AreEqual(5, root.Value);
            Assert.AreEqual(1, left.Value);
            Assert.AreEqual(8, right.Value);
        }

        [Test]
        public void TestSearchCheckReturnedTreeStructureWithOnlyLeftNode()
        {
            this._bst.Insert(-2);
            var searched = this._bst.Search(1);
            var root = searched.Root;
            var left = searched.LeftChild;
            var right = searched.RightChild;

            Assert.AreEqual(1, root.Value);
            Assert.AreEqual(-2, left.Value);
            Assert.AreEqual(null, right);
        }

        [Test]
        public void TestContainsCheckReturnedTrue()
        {
            Assert.IsTrue(this._bst.Contains(5));
        }

        [Test]
        public void TestContainsCheckReturnedFalse()
        {
            Assert.IsFalse(this._bst.Contains(77));
        }
    }
}