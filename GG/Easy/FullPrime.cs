using System;
using System.Linq;


//Task http://www.geeksforgeeks.org/check-number-full-prime/

namespace GG.Easy
{
    public class FullPrime
    {
        public static bool[] Check(int count, int[] numbers)
        {
            var res = new bool[count];

            for (int i = 0; i < count; i++)
            {
                res[i] = IsFullPrime(numbers[i]);
            }

            return res;
        }

        private static bool IsFullPrime(int number)
        {
            var strNumber = number.ToString().Select(x=>int.Parse(x.ToString())).ToArray();

            return CheckIsPrime(number) && strNumber.All(CheckIsPrime);
        }

        private static bool CheckIsPrime(int number)
        {
            if (number == 0 || number == 1 || (number & 1) == 0)
                return false;
            
            var sqrt = Math.Round(Math.Sqrt(number));

            if (number % 2 == 0)
                return false;

            for (int i = 3; i < sqrt; i+=2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
