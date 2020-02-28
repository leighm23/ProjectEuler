using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Methods;

namespace ProjectEuler.ImplementedMethods
{
    public class ImplementedPageOne : PageOne
    {
        public int MultiplesOf3and5(int targetNum)
        {
            // int targetNum = 1000;
            int runningTotal = 0;

            for (int i=1; i<targetNum; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    runningTotal = runningTotal + i;
                }
            }

            return runningTotal;
        }
        
        public int EvenFibonacci(int topfibvalue)
        {
            int firstfib = 1;
            int secondfib = 2;
            int currfib = firstfib;
            int nextfib = secondfib;
            int evenSum = 0;

            while (currfib < topfibvalue)
            {
                if (currfib %2 == 0)
                {
                    evenSum = evenSum + currfib;
                }
                var prevfib = currfib;
                currfib = nextfib;
                nextfib = prevfib + currfib;
            }
            return evenSum;
        }


#region problem 3
        public long LargestPrimeFactor(long number)
        {
            List<long> primeFactors = PrimeFactorization(number);
            int largestPrime = 1;
            foreach(int num in primeFactors)
            {
                if(num > largestPrime)
                {
                    largestPrime = num;
                }
            }
            return largestPrime;
        }

        public List<long> PrimeFactorization(long number)
        {
            List<long> primeList = new List<long>();
            var rootnum = Math.Ceiling(Math.Sqrt(number));
            int indexer = 2;
            while (indexer<rootnum)
            {
                if(number % indexer == 0)
                {
                    primeList.Add(indexer);
                    number = number/indexer;
                }
                else
                {
                    indexer = indexer +1;
                }
            }
            primeList.Add(number);

            return primeList;
        }

#endregion

        public void LargestPalindromeProduct()
        {
            // largest product of 3x3 is 999x999 = 998,001
            // can either look at all the palindromes first then check products

            // highest 3x3 = 6 digits

            // var biggest3x3 = 999*999;






            //answer 992299 = 343x263
        } 

        // public int SplitNumber(int number)
        // {
        //     // split number

        //     if 
        // }

        // public bool IsPalindrome(long num)
        // {
            

        // }
       
        public int countDigit(long n) 
        { 
            if (n == 0) 
                return 0; 
            return 1 + countDigit(n / 10); 
        }
    }
}