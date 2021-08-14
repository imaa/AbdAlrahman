using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public  static class Problem2
    {
        public static void Run()
        { 
            Console.WriteLine("Problem 2 result ");
            Console.WriteLine(String.Join("", TwoSum(new int[4] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine(String.Join("", TwoSum(new int[3] { 3, 2, 4 }, 6)));
            Console.WriteLine(String.Join("", TwoSum(new int[2] { 3, 3 }, 6)));
        }
        /// <summary>
        /// Credit : leetcode.com
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// Example 1:
        /// Input: nums = [2, 7, 11, 15], target = 9
        /// Output: [0,1]
        /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// Example 2:
        /// Input: nums = [3, 2, 4], target = 6
        /// Output: [1,2]
        /// Example 3:
        /// Input: nums = [3, 3], target = 6
        /// Output: [0,1]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>int[]</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indexs = new int[2];
            // Implement here . 
            return indexs;
        }
    }
}
