using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome reverseInt = new Palindrome();
            Console.WriteLine(reverseInt.IsPalindrome(121));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] points = new int[2];

            for(int index = 0; index < nums.Length; index++)
            {
                 for(int innerIndex = index+1; innerIndex <nums.Length; innerIndex++)
                {
                    if(nums[index] + nums[innerIndex] == target)
                    {
                        points[0] = index;
                        points[1] = innerIndex;
                    }
                }
            }

            return points;
        }
    }
}
