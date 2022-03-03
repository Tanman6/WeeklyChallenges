using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = alphabet.ToCharArray();
            
                if (array.Contains(c))
                {
                    return true;
                }
                return false;
            }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) return true;
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0) return false;
            return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int string1 = str1.Length;
            int string2 = str2.Length;
            if (string1 < string2) return string1;
            else return string2;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;
            if (numbers == null) return 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            int num = numbers.Sum();
            if (num % 2 == 1 || num % 2 == -1) return true;
            return false;
        }
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) return 0;
            return number / 2;
        }
    }
}
