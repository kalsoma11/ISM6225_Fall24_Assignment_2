using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
            // Initializing variables    
            var numbers = new List<int>();
            var numSet = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!numSet.Contains(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
            // Initializing variables      
            List<int> EvenList = new List<int>();
            List<int> OddList = new List<int>();
            // Looping through array
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    EvenList.Add(num);
                }
                else
                {
                    OddList.Add(num);
                }
            }

            EvenList.AddRange(OddList);
            return EvenList.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                var numberdictionary = new Dictionary<int, int>();
            // Looping through array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numberdictionary.ContainsKey(complement))
                {
                    return new int[] { numberdictionary[complement], i };
                }
                numberdictionary[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
            // Sorting the array        
                Array.Sort(nums);
            return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], 
                            nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                //Converting decimal to binary conversion
                return Convert.ToString(decimalNumber, 2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                //Initialzing variables
                int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] > nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return nums[l];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {   
            if (x < 0) return false; // Negative numbers are not palindromes
            int orig = x, rev = 0;
            while (x > 0)
            {
                rev = rev * 10 + x % 10;
                x /= 10;
            }
            return orig == rev;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n <= 1) return n;
            int a = 0, b = 1;
            // Swapping numbers
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
