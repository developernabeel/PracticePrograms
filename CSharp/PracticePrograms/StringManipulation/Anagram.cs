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

            int len = str1.Length;
            char[] charArr1 = new char[len];
            char[] charArr2 = new char[len];

            for (int i = 0; i < len; i++)
                charArr1[i] = (char)str1[i];

            for (int i = 0; i < len; i++)
                charArr2[i] = (char)str2[i];

            Sort(charArr1);
            Sort(charArr2);

            for (int i = 0; i < len; i++)
            {
                if (charArr1[i] != charArr2[i])
                    return false;
            }

            return true;
        }

        void Sort(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - (1 + i); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
}
