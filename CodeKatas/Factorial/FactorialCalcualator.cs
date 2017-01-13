using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Factorial
{
    public class FactorialCalcualator
    {

        public double CalculateUsingForLoop(int facotrialNumber)
        {
            var facotrialResult = 1;

            for (int i = 1; i <= facotrialNumber; i++)
            {
                facotrialResult *= i;

            }
            return facotrialResult;


        }

        public double CalculateUsingRecursion(int number)
        {
            if (number == 0)
            {
                return 1;

            }
            else
            {
                return number * (CalculateUsingRecursion(number - 1));
            }

        }
    }
}
