using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Fibbonacci
    {

        public int FindFibonacci(int n)
        {
            int[] numArry = new int[n];
            numArry[0] = 0;
            numArry[1] = 1;
            for(int i = 2; i < n; i++)
            {
                numArry[i] = numArry[i-1]+ numArry[i-2];
            }
            return numArry[numArry.Length-1];
        }

        public int FindFibonacciUsingRecursion(int n)
        {
            if (n <= 1) { return n; }
            return FindFibonacciUsingRecursion(n-1) + FindFibonacciUsingRecursion(n-2);
        }
    }
}
