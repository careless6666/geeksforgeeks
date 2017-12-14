

//http://www.geeksforgeeks.org/length-longest-balanced-parentheses-prefix/


namespace GG.Easy
{
    public class LengthOfLongestBalancedParenthesesPrefix
    {
        public static int Check(string bracketsStr)
        {
            var leftBrackets = 0;
            var lrPairs = 0;
            var maxPairs = 0;

            for (var i = 0; i < bracketsStr.Length; i++)
            {
                if (bracketsStr[i] == '(')
                    leftBrackets++;

                if (leftBrackets > 0 && bracketsStr[i] == ')')
                {
                    leftBrackets--;
                    lrPairs++;

                    if (lrPairs > maxPairs)
                        maxPairs = lrPairs;
                }

                if (leftBrackets == 0)
                    lrPairs = 0;
            }
            
            return maxPairs * 2;
        }
    }
}
