using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.StringCMajor
{
    public class CMajor
    {

        public string ConverToCMajor()
        {
            const string notes = "ABCDEFG";
            var cMajorStart = notes.Substring(2);
            var cMajorEnd = notes.Substring(0, 2);
            return cMajorStart + cMajorEnd;

        }

    }
}
