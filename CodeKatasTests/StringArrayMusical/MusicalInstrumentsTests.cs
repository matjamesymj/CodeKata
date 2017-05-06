using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKatas.StringArrayMusical;

namespace CodeKatasTests.StringArrayMusical
{
    [TestClass()]
    public class MusicalInstrumentsTests
    {
        [TestMethod()]
        public void RemoveVowelsTest()
        {
            var musicalIntruments = new MusicalInstruments();
            var musicalInstrumentsArray = new string[4];
            musicalInstrumentsArray[0] = "cello";
            musicalInstrumentsArray[1] = "guitar";
            musicalInstrumentsArray[2] = "violin";
            musicalInstrumentsArray[3] = "double bass";
            var musicalIntrumentsWithoutVowels = musicalIntruments.RemoveVowels(musicalInstrumentsArray);

            foreach (var musicalInstrumentWithoutVowel in musicalIntrumentsWithoutVowels)
            {
                Assert.IsFalse(ContainVowel(musicalInstrumentWithoutVowel));
                
            }

        }

        private static bool ContainVowel(string word)
        {
            const string vowels ="AEIOU";

            foreach (var vowel in vowels)
            {
                if (word.Contains(vowel.ToString()))
                {
                    return true;
                };
            }
            return false;
        }
    }
}