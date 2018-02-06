using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.StringManipulation
{
    public class Anagram
    {
        public Anagram()
        {
            string str1 = "tom marvolo riddle";
            string str2 = "iam lord voldemort";

            Console.WriteLine(IsAnagram(str1, str2));
        }

        bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            str1 = Sort(str1);
            str2 = Sort(str1);

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            }
            return true;
        }

        string Sort(string str)
        {
            StringBuilder strb = new StringBuilder(str);
            int len = strb.Length;

            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if ((char)strb[j] > (char)strb[j + 1])
                    {
                        char temp = strb[j];
                        strb[j] = strb[j + 1];
                        strb[j + 1] = temp;
                    }
                }
            }
            return strb.ToString();
        }
    }
}
