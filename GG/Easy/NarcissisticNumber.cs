using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Easy
{
    //http://www.geeksforgeeks.org/narcissistic-number/

    public class NarcissisticNumber
    {
        public static bool Check(long number)
        {
            var digits = number.ToString();

            long sum = 0;
            var power = digits.Length;

            foreach (var digit in digits)
                sum += (long) Math.Pow(int.Parse(digit.ToString()), power);

            return sum == number;

        }
    }
}
