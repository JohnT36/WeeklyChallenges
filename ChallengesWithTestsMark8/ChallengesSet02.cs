using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }
        
        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
            //or use this code
            //if (vals.Length % 2 == 0)
            //    return true;
            //return false;
        }

        public bool IsNumberEven(int number)
        {
            // return (number % 2 == 0) ? true : false;
            //return (number % 2 == 0);
            if (number % 2 == 0)
                return true;
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            //return (number % 2 != 0) ? true : fasle;
            //return (number % 2 != 0)
            if (num % 2 != 0)
                return true;
            return false;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //return numbers == null || numbers.Count() == 0
            // ? 0 : numbers.Min() + numbers.Max();
            if (numbers == null || numbers.Count() == 0) { return 0; }
            var large = numbers.Min();
            var small = numbers.Max();

            return small + large;
        
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            /*if (str1.Length < str2.Length)
                return str1.Length;
            return str2.Length;*/
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
          //if (numbers == null)
         // { return 0; }
         // return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //return numbers == null ? 0 : numbers.Where(num => num % 2 == 0).Sum();
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }    
                return sum;
        
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }
            // return numbers == null ? false : numbers.Sum() % 2 != 0;
            var sum = 0;
           for (int i = 0; i < numbers.Count(); i++)
            {
                sum += numbers[i];
              //sum = sum + numbers[i];
            }
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
          return number <0 ? 0 : number / 2;

            
        }
    }
}
