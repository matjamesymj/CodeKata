using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.String_Calculator
{
    public class StringCalculator
    {
        public StringCalculator(IConsole console)
        {
            Console = console;
        }

  
        public  IConsole Console { get; set; }
        public int Add(string numbers)
        {
            var returnValue = 0;
            if (string.IsNullOrEmpty(numbers))
            {
                returnValue = 0;
            }
            else
            {
                var values = SplitDelimiterString(numbers);

                var sum = CalculateSum(values);

                Console?.WriteLine($"The result is {sum}");

                returnValue = sum;

            }
            return returnValue;
        }

        private static string[] SplitDelimiterString(string numbers)
        {
            string[] delimeters = new string[] {",", ";", "***"};

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(4);
            }
            var values = numbers.Replace("\n", ",").Split(delimeters, StringSplitOptions.None);
            return values;
        }

        private static int CalculateSum(string[] values)
        {
            var sum = 0;
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
            return sum;
        }
    }
}
