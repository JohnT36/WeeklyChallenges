using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {


        public bool ArrayContainsAFalse(bool[] vals)
        {
             foreach (var x in vals)
             { if (x == false)
                {
                    return true;
                }
             } return false;

        // for (int i = 0; i < vals.Length; i++)
        // {
        //     if (vals[i] == false)
        //         return true;
        // }
        // return false;
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return false;
         //   
         //       var sum = numbers.Sum();
         //   return sum % 2 != 0;
            var sum = 0;
            foreach (int x in numbers)
            {
                if (x % 2 != 0)
                { sum += x; }

            }
                return sum % 2 != 0 ? true : false;
            
              



            
        }



        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
            var lower = false;
            var number = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                    lower = true;
                if (Char.IsUpper(password[i]))
                    upper = true;
                if (Char.IsNumber(password[i]))
                    number = true;
             }

            return upper && lower && number ;

        }



        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //return val.First();
        }



        public char GetLastLetterOfString(string val)
        {

            return (val[val.Length - 1]);
        }



        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }



        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }



        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) odds.Add(i);
            }
            return odds.ToArray();
        }



        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }


    }
}
