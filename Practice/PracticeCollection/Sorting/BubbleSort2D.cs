namespace PracticeCollection.Sorting.BubbleSort2D
{
    public class SolutionClass
    {
        public static int[,] BubbleSort2D(int[,] nums)
        {
            //Matrix
            int rows = nums.GetLength(0);
            int cols = nums.GetLength(1);

            // Sorting 2D array based on the first column
            //Iterate through the matrix
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (nums[j, 0] > nums[j + 1, 0])
                    {
                        //Iterate through each row
                        for (int k = 0; k < cols; k++)
                        {
                        // Swap the entire row
                            int temp = nums[j, k];
                            nums[j, k] = nums[j + 1, k];
                            nums[j + 1, k] = temp;
                        }
                    }
                }
            }

            return nums;
        }
    }
}
