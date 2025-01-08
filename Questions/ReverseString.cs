using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class ReverseString
    {
        #region ReverseStringUsingStringBuilder
        public string ReverseStringUsingStringBuilder(string str)
        {
            StringBuilder revStr = new StringBuilder();
            char[] chars = str.ToCharArray();
            for (int i = str.Length-1; i >= 0; i--)
            {
                revStr.Append(chars[i]);
            }
            return revStr.ToString();
        }
        #endregion
        #region ReverseStringUsingArray
        public string ReverseStringUsingArray(string str)
        {
            char[] chars = str.ToCharArray();
            string outStr = String.Empty;
            Array.Reverse(chars);
            foreach (char c in chars)
            {
                outStr += c;
            }
            return outStr;
        }
        #endregion
        
        public int ReverseIntergerNumWithoutString(int num)
        {
            if (num < 10) return num;
            int digits = (int)Math.Log10(num); //To find the Digits in Integer
            int firstnum = num / (int)Math.Pow(10, digits); // first digit 4235/1000 = 4 ( 1000 = 10 * 3 digits)
            int lastNum = num % 10; //last digit 4235 % 10 = 5
            int middle = (num % (firstnum * ((int)Math.Pow(10, digits)))) / 10; 
            // 4235 % 4000 = 235,, 235/10 = 23 omitting first and last digits
            return (lastNum * ((int)Math.Pow(10, digits))) + (middle * 10) + firstnum;
            //changing the first and last digits 
            //(5 * 1000) + 23 + 4
            //changed Num = 5234
        }

        public string CheckPalindrome(string str)
        {
            int right = 0;
            int left = str.Length - 1;

            while (left > right)
            {
                if (!(str[left] == str[right]))
                {
                    return "Not a Palindrome";
                }
                right++;
                left--;
            }
            return "Given string is Palindrome";
        }
    }
}
