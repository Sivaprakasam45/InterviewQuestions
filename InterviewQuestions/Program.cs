
using System;
using Questions;

namespace InterviewQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString reverseString = new ReverseString();
            //Console.WriteLine("Enter the string to be reversed");
            //string inStr =Console.ReadLine();
            //string reversedStr = reverseString.ReverseStringUsingStringBuilder(inStr);
            //Console.WriteLine(reversedStr);
            //reversedStr = reverseString.ReverseStringUsingArray(reversedStr);
            //Console.WriteLine(reversedStr);


            //Console.WriteLine("Enter the number to show the fibbonacci");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Fibbonacci fib = new Fibbonacci();
            //Console.WriteLine(fib.FindFibonacciUsingRecursion(num));

            //Find LHS
            //int[] nums = { 1, 3, 2, 2, 5, 2, 3, 7 };
            //LHS lhs = new LHS();
            //Console.WriteLine(lhs.FindLHS(nums));

            //TwoSum ts = new TwoSum();
            //int[] n = { 0, 0, 3, 4 };
            //int target = 0;
            //int[] nums = new int[2];
            ////nums = ts.TwoSumUsingDictionary(n, target);
            ////Console.WriteLine(nums[0], nums[1]);
            //int num = 10;
            //string str = ts.IsPalindrome(num)?"Palindrome": "Not a Palindrome";
            //Console.WriteLine(str);
            //int num = 4235;
            //int res = reverseString.ReverseIntergerNumWithoutString(num);
            //Console.WriteLine(res);

            //string str = "racecar";
            //Console.WriteLine(reverseString.CheckPalindrome(str));

            LeetCodeProblems problems = new LeetCodeProblems();

            string str = "leetcode";
            //Console.WriteLine(problems.ReverseVowels(str));

            string str2 = "raCecAr^&_!";
            //Console.WriteLine(problems.IsPalindrome(str2));

            int n = 11;
            int x = 2, y = 3, z = 5;

            //Console.WriteLine(problems.maximizeTheCuts(n, x, y, z));

            int[] coins = { 1, 2, 5 }; // Coin denominations
            int amount = 11;          // Target amount

            //int result = problems.CoinChange(coins, amount);

            //Console.WriteLine(result);

            int result = problems.Reverse(123);
            Console.WriteLine(result);



        }
    }
}
