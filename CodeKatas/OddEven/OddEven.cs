using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.OddEven
{
    public class OddEven
    {
        public string Print(int startNumber, int lastNumber)
        {
            string result = string.Empty;
            for (int i = startNumber; i < lastNumber; i++)
            {

                if (IsPrimeNumber(i))
                {
                    result += string.Format(" {0}", i);
                }

                if (!IsPrimeNumber(i) & IsOddNumber(i))
                    if (i == startNumber)
                    {
                        result += string.Format("{0}" + "Odd", result);
                    }
                    else
                    {
                        result = string.Format("{0} " + "Odd", result);
                    }


                if (IsEvenNumber(i))
                {
                    result = string.Format("{0} Even", result);
                }

            }
            return result;
        }
        private static bool IsEvenNumber(int number)
        {
            return number >= 2 && number % 2 == 0;
        }
        private static bool IsOddNumber(int number)
        {
            return (number % 2 != 0);
        }
        private static bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;
            if (IsEvenNumber(number)) return false;
            var divisble = 3;
            while (divisble * divisble <= number)
            {
                if (number % divisble == 0) return false;
                divisble += 2;
            }
            return true;

        }
    }
}
