using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GG.Easy;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "()(())((()";
            var res = LengthOfLongestBalancedParenthesesPrefix.Check(s);
            Console.WriteLine(res);
        }
    }
}
