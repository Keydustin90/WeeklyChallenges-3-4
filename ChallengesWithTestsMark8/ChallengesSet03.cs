using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public viod IsSumOfOddsOdd(IEnumerable<int> numbers, bool expected)
        {
            if (numbers == null || numbers.Count() == 0
            {
                return false;
            }

            var sum = numbers.Sum();

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password, bool expected)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    isNumber = true;

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

            public void GetFirstLetterOfString(string val)
            {
                return ValueTuple.First();
            }

            public char GetLastLetterOfString(string val)
            {
                return val[val.Length - 1];
            }

            public void Divide(decimal dividend, decimal divisor, decimal expected)
            {
                if (divisor == 0)
                {
                    return 0;
                }
                return dividend / divisor;
            }

            public void LastMinusFirst(int[] numbers, int expected)
            {
                return nums[nums.Length - 1] - nums[0];
            }

        public int[] ShouldGetOddsBelow100()
            {
                var list = new List<int>();

                for (int i = 0; i < 100; i++)
                {
                    if(i % 2 != 0)
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
                    words[i] = words[i].ToUpper[]; 
                }
        }
    }
}
