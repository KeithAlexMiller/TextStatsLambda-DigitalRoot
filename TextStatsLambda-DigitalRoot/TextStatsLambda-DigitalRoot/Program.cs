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

            //loops through digits sets them to int in temp var and adds to sum 
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
            return inputString.Split(' ').Count();
        }

        public static int NumberOfVowels(string inputString)
        {
            //returns count of vowel chars only
            return inputString.Count(x => ("aeiou".Contains(x.ToString().ToLower())));
        }

        public static int NumberOfConsonants(string inputString)
        {
            //returs count of all specified consonants
            return inputString.Count(x => ("qwrtyplkjhgfdszxcvbnm".Contains(x.ToString().ToLower())));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => (" .,?;'!@#$%^&*()".Contains(x.ToString().ToLower())));
        }

        public static string LongestWord(string inputString)
        {
            return inputString.Split(' ').OrderByDescending(x => x.Length).First();
        }

        public static string ShortestWord(string inputString)
        {
            return inputString.Split(' ').OrderBy(x => x.Length).First();
        }


    }
}
