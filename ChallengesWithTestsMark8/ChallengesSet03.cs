﻿using System;
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
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];

        }
        public char GetLastLetterOfString(string val)
        {
            var last = val;
            return last[val.Length - 1];
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
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }

        private bool ToUpperCase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
