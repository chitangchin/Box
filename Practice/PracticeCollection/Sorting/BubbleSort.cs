namespace PracticeCollection.Sorting.BubbleSort
{
    public class SolutionClass
    {
        public static int[] BubbleSort(int[] nums)
        {
            //Iterate through nums
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        (nums[j], nums[j+1]) = (nums[j+1], nums[j]);
                    }
                }
            }
            return nums;
        }
    }
}
