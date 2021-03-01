using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {


        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public object IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;
            foreach (var i in password)
            {
                if (char.IsLower(i))
                {
                    isLower = true;
                }
                if (char.IsUpper(i))
                {
                    isUpper = true;
                }
                if (char.IsNumber(i))
                {
                    isNumber = true;
                }
            }
            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            return val.First();
        }
        public char GetLastLetterOfString(string val)
        {
            //\var last = val;
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;

            }
            else
            {
                return dividend / divisor;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }

            }
            return list.ToArray();
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
