using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.StringManipulation
{
    class Palindrome
    {
        public Palindrome()
        {
            string str1 = "wasitacaroracatisaw";
            string str2 = "abcdbcda";
            Console.WriteLine(IsPalindrome(str1));
            Console.WriteLine(IsPalindrome(str2));
        }

        bool IsPalindrome(string str)
        {
            if (str.Length < 2)
                return true;

            return (str[0] == str[str.Length - 1]) && (IsPalindrome(str.Substring(1, str.Length - 2)));
        }
    }
}
