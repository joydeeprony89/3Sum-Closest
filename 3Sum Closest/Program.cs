using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum_Closest
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -1, 2, 1, -4 };
            Console.WriteLine(ThreeSumClosest(nums,1));
        }
        static int ThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            if (nums.Length == 3)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int l = i + 1, r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum > target) r--;
                    else if (sum < target) l++;
                    else return sum;

                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                        result = sum;
                }
            }

            return result;
        }
    }
}
