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
            var count = int.Parse(Console.ReadLine());
            for (var i = 0; i < count; i++)
            {
                var res = NarcissisticNumber.Check(int.Parse(Console.ReadLine()));
                Console.WriteLine(res);
            }
        }
    }
}
