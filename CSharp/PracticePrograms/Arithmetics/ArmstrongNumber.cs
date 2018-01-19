using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Arithmetics
{
    class ArmstrongNumber
    {
        public ArmstrongNumber()
        {
            int n = 372;
            Console.WriteLine(IsArmstrong(n));
        }

        bool IsArmstrong(int n)
        {
            string str = n.ToString();
            int size = str.Length;
            if (size == 1)
                return true;

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                int digit = Convert.ToInt32(str[i].ToString());
                int power = (int)Math.Pow(digit, size);
                sum += power;
            }
            return sum == n;
        }
    }
}
