using System;
using System.Collections.Generic;

namespace GG.School
{
    //https://practice.geeksforgeeks.org/problems/row-with-minimum-number-of-1s/0
    public class RowWithMinimumNumberOf1
    {
        public static void GetNumberWithTests(int testCount, int row, int col, int[] arr)
        {
            for (var i = 0; i < testCount; i++)
            {
                var res = GetNumber(row, col, arr);
                Console.WriteLine(res);
            }
        }

        public static int GetNumber(int row, int col, int[] arr)
        {
            var minIndex = 0;
            var min = int.MaxValue;
            var index = 0;

            for (var i = 0; i < row * col; i += col)
            {
                var sum = 0;
                for (var j = i; j < i + col; j++)
                    sum += arr[j];

                if (sum > 0 && sum < min)
                {
                    min = sum;
                    minIndex = index;
                }

                index++;
            }

            return min == int.MaxValue ? -1 : minIndex;
        }
    }
}
