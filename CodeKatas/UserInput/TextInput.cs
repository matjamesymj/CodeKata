using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.UserInput
{
   public class TextInput
    {
        public string Input { get; set; }
        public virtual void Add(char c)
        {
            Input += c;
        }

        public string GetValue()
        {
            return Input;
        }



    }
}
