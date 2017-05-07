using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Numbers
{
    public class ConsecutiveNumbers
    {
        public ConsecutiveResult IsConsectiveNumbers(string numbers)
        {
            var numbersSplit = numbers.Split('-');

            for (var i = 0; i < numbersSplit.Length - 1; i++)
            {
                var thisNumber = int.Parse(numbersSplit[i]);
                var nextNumber = int.Parse(numbersSplit[i + 1]);

                if (thisNumber < nextNumber)
                {
                    if (thisNumber - nextNumber != -1)
                    {
                        return ConsecutiveResult.No;
                    }
                }
                else
                {
                    if (thisNumber == nextNumber)
                    {
                        return ConsecutiveResult.ContainsPair;
                    }
                    else
                    {
                         if (thisNumber - nextNumber != 1)
                    {
                        return ConsecutiveResult.No;
                    }
                    }
                   
                }

            }

            return ConsecutiveResult.Yes;
        }
    }
}
