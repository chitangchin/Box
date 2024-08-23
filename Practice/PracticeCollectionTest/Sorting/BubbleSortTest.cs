using PracticeCollection.Sorting.BubbleSort;

namespace PracticeCollectionTest.Sorting
{
    public class BubbleSortTest
    {
        private static readonly int[] expected = new int[] { 1, 2, 3 };
        private static readonly int[] expectedArray = new int[] { 1, 2, 3, 4, 6, 8 };

        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.BubbleSort([2, 3, 1]), Is.EqualTo(expected));
        }
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.BubbleSort([4,1,2,6,3,8]), Is.EqualTo(expectedArray));
        }
    }
}
