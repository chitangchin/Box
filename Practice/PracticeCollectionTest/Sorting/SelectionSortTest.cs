using PracticeCollection.Sorting.SelectionSort;

namespace PracticeCollectionTest.Sorting;
public class SelectionSortTest
{
    private static readonly int[] expected = [1, 2, 3];
    private static readonly int[] expected2 = [1, 2, 3, 4, 6, 8];
    [Test]
    public void Test()
    {
        Assert.That(SolutionClass.SelectionSort([1,3,2]), Is.EqualTo(expected));
    }
    [Test]
    public void Test1()
    {
        Assert.That(SolutionClass.SelectionSort([1, 8, 6, 2, 3, 4]), Is.EqualTo(expected2));
    }
}
