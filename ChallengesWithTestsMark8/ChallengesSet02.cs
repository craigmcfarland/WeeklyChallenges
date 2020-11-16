using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            
          

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if ( number % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;

            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }


        public int SumEvens(int[] numbers)
        {
            var evenSum = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum.Add(num);
                    return evenSum.Sum();
                }
            }
        }

        private void Sum()
        {
            throw new NotImplementedException();
        }
    }

        public bool IsSumOdd(List<int> numbers)
        {
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
