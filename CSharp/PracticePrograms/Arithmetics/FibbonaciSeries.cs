using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Arithmetics
{
    class FibbonaciSeries
    {
        public FibbonaciSeries()
        {
            int n = 10;
            int a = 0, b = 1;
            Console.WriteLine(b);
            for (int i = 1; i < n; i++)
            {
                int x = a + b;
                Console.WriteLine(x);
                a = b;
                b = x;
            }
        }
    }
}
