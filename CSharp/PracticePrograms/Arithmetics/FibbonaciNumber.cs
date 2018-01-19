using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Arithmetics
{
    class FibbonaciNumber
    {
        public FibbonaciNumber()
        {
            int n = 6;
            Console.WriteLine(Fibbonaci(n));
        }

        int Fibbonaci(int n)
        {
            if (n <= 1)
                return n;
            return Fibbonaci(n - 1) + Fibbonaci(n - 2);
        }
    }
}
