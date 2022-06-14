using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (String.Equals(words, null) || words.Contains(null))
            { return containsWord; }

            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;

            
            
            
            
            
            /*
            bool contains = false;
            
            if (words == null)
            { return false; }
            foreach (string word2 in words)
            {
                if (words == null)
                    contains = false;
                
            }


            if (ignoreCase)
            {
                foreach (string word1 in words)
                {
                    if (word1.ToLower() == word)
                    { contains = true;}
                }
            }
            if (!ignoreCase)
            {
                foreach (string word1 in words)
                {
                    if (word1 == word)
                    { contains = true; }
                }
            }
            return contains;*/
           
        }

        public bool IsPrimeNumber(int num)
        {
            //final
            if (num == 1 || num == 0) return false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0) return true;
            }
            if (num == 2 || num == 3) return true;
            return false;       
          /*  var isPrime = false;
            if (num == 1)
                {return  false; }
            if (num == 2 || num == 3)
            { isPrime = true;               
            }
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
                if (num == 0)
                { isPrime = false; }

            }
            return isPrime;
          */
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uindex;
            for (int i = 0; i < str.Length; i++)
            { uindex = true;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }                    
                }
                if (uindex)
                {
                    index = i;
                }
            }return index; 
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int t = 0; t < numbers.Length; t++)
            {
                var currentCount = 1;
                for (int j = t + 1; j < numbers.Length; j++)
                {
                    if (numbers[t] != numbers[j] && t != j)
                    { break; }                   
                   currentCount++;
                }
                if (currentCount > count) 
                { 
                    count = currentCount;
                }

            }return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];
            if (elements == null)
            { return nullCheck; }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                { nthElement.Add(elements[i]); }
                if (n < 0 || n > elements.Count)
                { nthElement.Clear(); }
            }return nthElement.ToArray();
        }
    }
}
