namespace Week_6_Assignment_6._1._3
{
    //Given an integer array nums, move all 0's to the end of it
    //while maintaining the relative order of the non-zero elements.
    //Note that you must do this in-place without making a copy of the array.
    //Example 1:
    //Input: nums = [0, 1, 0, 3, 12]
    //Output: [1, 3, 12, 0, 0]
    internal class Program
    {
        static void MoveZeroesToEnd(int[] nums)
        {
            int position = 0; // To hold the index value of the postion

            // Move the not 0's forward
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) { nums[position] = nums[i]; position++; }

               Console.WriteLine(string.Join(",", nums));
            }


            for (int i = position; i < nums.Length; i++) { nums[i] = 0; }
        }

        // Display O(n^2)
        static void Main(string[] args)
        {
            int[] nums = {0, 1, 0, 3, 12 };
            MoveZeroesToEnd(nums);
            Console.WriteLine(string.Join(", ", nums));          
        }
    }
}
