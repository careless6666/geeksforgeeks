using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GG.Easy;
using GG.School;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCounter = int.Parse(Console.ReadLine());

            var listRes = new List<int>();

            for (int i = 0; i < testCounter; i++)
            {
                var str = Console.ReadLine().Split(' ');

                var row = int.Parse(str[0]);
                var col = int.Parse(str[1]);

                var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                listRes.Add(RowWithMinimumNumberOf1.GetNumber(row, col, arr));
            }

            listRes.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
 