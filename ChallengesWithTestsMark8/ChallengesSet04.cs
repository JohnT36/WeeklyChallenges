using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            /*var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
                if (number % 2 != 0)
                    sum -= number;
                
            } return sum;*/
            return numbers.Where(x=>x % 2 == 0).Sum() - numbers.Where(x=>x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<string>() { str1, str2, str3, str4 };
            return list.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 + sideLength2 > sideLength3
            && sideLength1 + sideLength3 > sideLength2
            && sideLength2 + sideLength3 > sideLength1)
            { return true; }
            return false;
            
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;

            foreach ( var obj in objs )
            {  if ( obj == null )
                { count++; }                  
                     
            }
            if (count >= majority)
            { return true; }
            return false;
            

        }

        public double AverageEvens(int[] numbers)
        {
         //var sum = 0;
         //var count = 0;
         //if ( numbers == null)
         //    { return 0; }
         //
         //foreach (var number in numbers )
         //{
         //    if (number % 2 == 0)
         //    { 
         //        sum += number;
         //        count++; 
         //    }
         //
         //}
         //if (count > 0)
         //{
         //    return sum / count;
         //}
         //else
         //{
         //    return 0;
         //}
            
            if (numbers == null || numbers.Length == 0)
                return 0;
            var n = numbers.Where(x => x % 2 == 0);
            if (n.Count() == 0)
                { return 0; }
            return n.Average();
            
            
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            { throw new ArgumentOutOfRangeException("number"); }
            if (number > 0)
            { return 1; }
            return number * Factorial(number - 1);
        }
    }
}
