using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.RomanNumerals
{
    public class RomanNumeralsUtils
    {
        public static string ArabicToRoman(int arabic)
        {
            var remainingResult = arabic;
            var stringBuilder = new StringBuilder();
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
  
            for (var i = 0; i < values.Length; i++)
            {
                remainingResult = AppendRomanNumerals(remainingResult, values[i], symbols[i], stringBuilder);
            }

            return stringBuilder.ToString();
        }

        private static int AppendRomanNumerals(int arabic, int value, string romanNumerals, StringBuilder stringBuilder)
        {
            var remainingResult = arabic;
            while (remainingResult >= value)
            {
                stringBuilder.Append(romanNumerals);
                remainingResult -= value;
            }
            return remainingResult;
        }
    }
}
