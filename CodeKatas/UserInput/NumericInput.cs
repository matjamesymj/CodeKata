using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.UserInput
{
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (char.IsDigit(c))
                Input += c;
        }

    }
}
