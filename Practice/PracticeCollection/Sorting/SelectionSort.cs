namespace PracticeCollection.Sorting.SelectionSort
{
    public class SolutionClass
    {
        public static int[] SelectionSort(int[] nums)
        {
            //Iterate through the array
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //Declare an int variable smallest assign it to i
                int smallest = i;
                //iterate through the all elements after i
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //initially Check if nums[j] is smaller than our i, then reassign. check every el if smaller than smallest and redefine index;
                    if (nums[j] < nums[smallest]) smallest = j;
                }
                //Swap the smallest value with our current i
                (nums[i], nums[smallest]) = (nums[smallest], nums[i]);
            }
            return nums;
        }
    }
}
