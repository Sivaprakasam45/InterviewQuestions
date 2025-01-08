using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questions
{
    public class LeetCodeProblems
    {
        public string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            char[] str = s.ToCharArray();
            while (left < right)
            {
                if (vowels.Contains(str[left]))
                {
                    while (left < right)
                    {
                        if (vowels.Contains(str[right]))
                        {
                            char temp = str[left];
                            str[left] = str[right];
                            str[right] = temp;
                            right--;
                            break;
                        }
                        right--;
                    }
                }
                left++;
                
            }
            return new string(str);
        }

        public bool IsPalindrome(string s)
        {
            string val = Regex.Replace(s, "[^0-9a-zA-Z]", "");
            Console.WriteLine(val);
            char[] revVal = val.ToLower().ToCharArray();
            Array.Reverse(revVal);
            Console.WriteLine(revVal.ToString());
            return val.ToLower() == new string(revVal);
        }

       //GFG
        public int maximizeTheCuts(int n, int x,
                                         int y, int z)
        {

            // Create a table to store results of subproblems
            int[] dp = new int[n + 1];

            // Initialize the dp array with -1 for all
            // lengths greater than 0
            for (int i = 1; i <= n; ++i)
            {
                dp[i] = -1;
            }

            for (int i = 1; i <= n; ++i)
            {

                // Check if the current length is at least x
                // If so, check if the previous result
                // (dp[i - x]) is valid (not -1)
                // Update dp[i] by considering this cut
                if (i >= x && dp[i - x] != -1)
                {
                    dp[i] = Math.Max(dp[i], dp[i - x] + 1);
                }

                // Similarly, check for the other two possible
                // cuts (y and z)
                if (i >= y && dp[i - y] != -1)
                {
                    dp[i] = Math.Max(dp[i], dp[i - y] + 1);
                }

                if (i >= z && dp[i - z] != -1)
                {
                    dp[i] = Math.Max(dp[i], dp[i - z] + 1);
                }

                // If no valid cut was found for length i,
                if (dp[i] == 0)
                {
                    dp[i] = -1;
                }
            }

            // If no valid cuts are found for the full
            // length n, return 0
            if (dp[n] == -1)
            {
                return 0;
            }

            // Return the maximum number of cuts for
            // the rod of length n
            return dp[n];
        }

        public int CoinChange(int[] coins, int amount)
        {
            // Create a DP array to store minimum coins for each amount
            int[] dp = new int[amount + 1];
            Array.Fill(dp, int.MaxValue); // Initialize all values to a large number
            dp[0] = 0; // Base case: 0 coins needed for amount 0

            // Fill the DP array
            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    if (dp[i - coin] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            // If amount is not reachable, return -1
            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }

        public int Reverse(int x)
        {
            long curr = 0;
            while (x != 0)
            {
                int digit = x % 10;
                curr = curr * 10 + digit;
                x /= 10;
            }
            if (curr < Int32.MinValue || curr > Int32.MaxValue)
            {
                return 0;
            }
            x = (int)curr;
            return x;
        }
    }
}
