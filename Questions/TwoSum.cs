using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class TwoSum
    {
        public int[] TwoSumUsingDictionary(int[] numbers, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] nums = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsValue(numbers[i]))
                {
                    int vals = target - numbers[i];
                    if (dict.ContainsValue(vals))
                    {
                        //dist.tryGetValue;
                        nums[0] = (dict.FirstOrDefault(x => x.Value == vals).Key) + 1;
                        nums[1] = i + 1;
                        return nums;
                    }
                    dict.Add(i, numbers[i]);
                }
                else
                {
                    dict.Add(i, numbers[i]);
                }
            }
            return null;
        }

        public bool IsPalindrome(int x)
        {
            string val = x.ToString();
            string[] nums = val.Split("");
            Array.Reverse(nums);
            string revStr = String.Join("", nums);
            return val == revStr;
        }
    }
}
