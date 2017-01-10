using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.String_Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var returnValue = 0;
            if (string.IsNullOrEmpty(numbers))
            {
                returnValue = 0;
            }
            else
            {
                string[] delimeters = new string[] { ",",";","***" };
               

                if (numbers.StartsWith("//"))
                {
                    
                   numbers = numbers.Substring(4);
                }

                var sum = 0;
               var values = numbers.Replace("\n", ",").Split(delimeters,StringSplitOptions.None);
                foreach (var number in values)
                {
                    var intNumber = int.Parse(number);
                    if (intNumber < 0)
                    {
                        throw new Exception("negatives not allowed");
                    }
                    if (intNumber <= 1000)
                    {
                        sum += intNumber;
                    }
                   
                }

               // List<int> arrayNumbers = numbers.Replace("\n", delimeter.ToString()).Split(delimeter).Select(int.Parse).ToList();

                returnValue = sum;

            }
            return returnValue;
        }
    }
}
