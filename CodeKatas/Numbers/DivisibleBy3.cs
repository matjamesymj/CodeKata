using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Numbers
{
    public class DivisibleBy3
    {
        public int CountNumbersDivisibleBy3(int number)
        {
            //using loop
            var resultCounter = 0;
            for (var i = 0; i < (number - 1); i++)
            {
                if (i % 3 == 0)
                {
                    resultCounter++;
                }
            }

            return resultCounter;

            //just devide by 3 method
            //return (number/3);
        }
    }
}
