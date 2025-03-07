﻿using System;
using System.Collections.Generic;

namespace SumOfThreeUniqueInteger
{
    class Program
    {
        // https://leetcode.com/problems/3sum/
        static void Main(string[] args)
        {
            int[] data = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = SumOfThreeUniqueInteger(data);
            Console.ReadLine();
        }

        private static IList<IList<int>> SumOfThreeUniqueInteger(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            for (int index1 = 0; index1 + 2 < nums.Length; index1++)
            {
                if (index1 > 0 && nums[index1] == nums[index1 - 1])
                    continue;

                int index2 = index1 + 1, index3 = nums.Length - 1;
                while (index2 < index3)
                {
                    int sum = nums[index1] + nums[index2] + nums[index3];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[index1], nums[index2], nums[index3] });
                        index3--;
                        while (index2 < index3 && nums[index3] == nums[index3 + 1])
                            index3--;
                    }
                    else if (sum > 0)
                    {
                        index3--;
                    }
                    else
                    {
                        index2++;
                    }
                }
            }

            return result;
        }
    }
}
