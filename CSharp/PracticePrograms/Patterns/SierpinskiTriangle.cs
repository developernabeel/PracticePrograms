using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Patterns
{
    class SierpinskiTriangle
    {
        public SierpinskiTriangle()
        {
            int n = 8;

            for (int i = 1; i <= n; i++)
            {
                int x = i - 1;
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    if (IsPositionEmpty(i, j + 1, n))
                        Console.Write("  ");
                    else
                        Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        bool IsPositionEmpty(int y, int x, int n)
        {
            if (n < 4)
                return false;

            if (n % 2 != 0)
                n--;

            int subsetSize = n;
            while (subsetSize / 2 > y && (subsetSize / 2 >= 4))
            //while (subsetSize / 2 >= 4)
            {
                subsetSize /= 2;
            }
            return false;
        }
    }
}
