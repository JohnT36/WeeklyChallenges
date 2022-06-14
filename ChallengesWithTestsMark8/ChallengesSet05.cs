using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
          /*  var num = 0;
            var loop = startNumber + n;
            if (startNumber == 0)
            { return n; }

            for (int i = startNumber + 1; i <= loop ; i++)
            {
                if (i % n == 0)
                { num = i; }

            }
             return num;*/
            return ((startNumber / n) + 1) * n; 
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";

                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            { return false; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            { return 0; }
            var number = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    number += numbers[i];

                } 
            }
            return number;
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            var wordCount = 0;
            var wordList = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                { }
                else { wordList.Add(words[i].Trim());
                    wordCount++;}
            }
            if (wordCount > 0)
            { return String.Join(" ", wordList) + "."; }
            return "";


        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) return new double[0];
            List<double> result = new List<double>();
            for(int i = 3; i < elements.Count; i+= 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[k] + nums[i] == targetNumber)
                    { return true; }
                }
            }
            return false;
        }
    }
}
