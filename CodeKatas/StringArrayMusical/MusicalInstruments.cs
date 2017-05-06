using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.StringArrayMusical
{
    public class MusicalInstruments
    {

        public List<string> RemoveVowels(String[] musicalInstruments)
        {
            var musicalInstrumentsWithoutVowels = new List<string>();
            foreach (var musicalInstrument in musicalInstruments)
            {
                var musicalInstrumentWithoutVowels = musicalInstrument.Replace("A", "").Replace("E","").Replace("I","").Replace("O","").Replace("U","");
                musicalInstrumentsWithoutVowels.Add(musicalInstrumentWithoutVowels);

            }
            return musicalInstrumentsWithoutVowels;
        }
    }
}
