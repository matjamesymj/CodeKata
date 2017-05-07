using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Numbers
{
    public class ConsecutiveNumbers
    {
        public bool IsConsectiveNumbers(string numbers)
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
                        return false;
                    }
                }
                else
                {
                    if (thisNumber - nextNumber != 1)
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
