using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
                
            } return false;
#pragma warning restore CS0162 // Unreachable code detected

        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            { return false; }

            var sum = numbers.Sum();
            return sum % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (var i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                { isLower = true; }
                if (char.IsUpper(password[i]))
                { isUpper = true; }
                if (char.IsNumber(password[i]))
                { isNumber = true; }
            }
            if (isLower && isUpper && isNumber )
                { return true; }
             return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
            // return val[0];
            //return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
            //return val.Last();
            //return val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            { return 0; }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddSum = new List<int>();
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum.Add(i);
                }
            }
            return oddSum.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
