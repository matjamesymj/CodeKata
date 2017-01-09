using System;
using System.Linq;

namespace CodeKatas.Pailindrome
{
    /// <summary>
    /// A palindrome is a word that reads the same backward or forward.
    /// Write a function that checks if a given word is a palindrome.Character case should be ignored.
    //For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
    /// </summary>
    public class Palindrome
    {
        public static bool IsPalindromeUsingArray(string word)
        {
            var array = word.ToCharArray();
            Array.Reverse(array);
            var wordBackwards = new string(array);
            return string.Equals(word, wordBackwards, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsPalindromeUsingLinq(string word)
        {
            return word.ToLower() == new string(word.ToLower().Reverse().ToArray());
        }
    }
}
