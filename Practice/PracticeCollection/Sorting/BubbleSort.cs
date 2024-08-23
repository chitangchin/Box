namespace PracticeCollection.Sorting.BubbleSort
{
    public class SolutionClass
    {
        public static int[] BubbleSort(int[] nums)
        {
            //Double loop where we check j and j+1 and swap if lower then we iterate againg
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
