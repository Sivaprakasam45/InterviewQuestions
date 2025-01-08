using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class LHS
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> nums_cnts = new Dictionary<int, int>();

            // Count the occurrences of each number in the array
            foreach (int num in nums)
            {
                if (nums_cnts.ContainsKey(num))
                {
                    nums_cnts[num] += 1;
                }
                else
                {
                    nums_cnts.Add(num, 1);
                }
            }

            int LHS = 0;

            // Iterate through the dictionary and look for harmonious subsequences
            foreach (var kv in nums_cnts)
            {
                int num = kv.Key;

                // Check if num + 1 exists in the dictionary
                if (nums_cnts.ContainsKey(num + 1))
                {
                    int LHS_temp = kv.Value + nums_cnts[num + 1];
                    LHS = Math.Max(LHS, LHS_temp);
                }
            }

            return LHS;
        }
    }
}
