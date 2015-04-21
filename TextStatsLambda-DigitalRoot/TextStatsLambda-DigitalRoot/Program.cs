using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static int DigitalRoot(string rootThisNumber)
        {
            int sum = 0;
            int digRoot = 0;
            int temp = 0;
            //ForEach(i => rootThisNumber.Add(Int32.Parse(i))); // maybe Convert.ToInt32() is better?

            List<int> numbers = new List<int>(rootThisNumber.Length);
            foreach (char c in rootThisNumber)
            {
                temp = (c - '0');
                sum += temp;
            }

            //handles when sum is equal to digRoot
            if (sum < 10)
            {
                digRoot = sum;
                return digRoot;
            }

            //hanldes edge case of sum of 10
            else if (digRoot == 10)
            {
                digRoot = 1;
            }
            
            //hanldes cases over ten where both digits in sum need to be added to each other
            else if (sum > 10)
            {
                temp = 0;
                string sumString = sum.ToString();

                foreach (char c in sumString)
                {
                    temp = (c - '0');
                    digRoot += temp;
                }
            }
            return digRoot;
        }

        public static int NumberOfWords(string inputString)
        {
            return 0;
        }

        public static int NumberOfVowels(string inputString)
        {
            return 0;
        }

        public static int NumberOfConsonants(string inputString)
        {
            return 0;
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return 0;
        }

        public static string LongestWord(string inputString)
        {
            return string.Empty;
        }

        public static string ShortestWord(string inputString)
        {
            return string.Empty;
        }


    }
}
