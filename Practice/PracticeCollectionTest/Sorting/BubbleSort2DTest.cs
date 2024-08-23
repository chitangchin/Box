using PracticeCollection.Sorting.BubbleSort2D;

namespace PracticeCollectionTest.Sorting
{
    public class BubbleSort2DTest
    {
        private static readonly int[,] expected = new int[,] { { 1, 2 }, { 2, 5 }, { 10, 11 } };
        private static readonly int[,] expected2 = new int[,] { { -10, 4 }, { 2, 10 }, { 10, 11 } };
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.BubbleSort2D(new int[,] { { 1, 2 }, { 10, 11 }, { 2, 5 } }), Is.EqualTo(expected));
            Assert.That(SolutionClass.BubbleSort2D(new int[,] { { 2, 10 }, { 10, 11 }, { -10, 4 } }), Is.EqualTo(expected2));
        }
    }
}
