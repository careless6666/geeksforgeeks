using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var data = new int[count];

            for (int i = 0; i < count; i++)
                data[i] = int.Parse(Console.ReadLine());

            var res = FullPrime.Check(count, data);

            for (int i = 0; i < count; i++)
                Console.WriteLine(res[i] ? "Yes" : "No");
            
        }
    }
}
