using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.StringSexOfSingers
{
    public class SingerSexHelper
    {
        public int CountSingersForSex(string[] singers, Sex sex)
        {
            var count = 0;

            foreach (var singer in singers)
            {
                if (sex == Sex.Male)
                {
                    if (singer.Contains("(m)"))
                    {
                        count += 1;
                    }
                }
                else
                {
                    if (singer.Contains("(f)"))
                    {
                        count += 1;
                    }
                }

            }
            return count;
        }

    }
}
