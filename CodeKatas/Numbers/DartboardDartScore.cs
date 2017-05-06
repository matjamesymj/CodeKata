using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Numbers
{
    public class DartboardDartScore

    {

        public int ThrowDart()
        {
            var random = new Random();
            NumberScore = random.Next(1, 20);
            return NumberScore;

        }
        public int NumberScore { get; set; }
        public  int Double => NumberScore *2;
        public int Trebble => NumberScore*3;
    }
}
