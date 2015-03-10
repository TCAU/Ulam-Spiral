using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ulam_Spiral
{
    class Primes
    {
        public bool[] list;

        public Primes(int x)
        {
            list = new bool[x + 1];

            for (int i = 0; i < list.Length; i++)
                list[i] = true;

            list[0] = list[1] = false;

            for (int i = 2; i * i < list.Length; i++)
                if (list[i])
                    for (int j = i + i; j < list.Length; j += i)
                        list[j] = false;
        }

    }
}
