/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Primos
{
    class Auxiliar
    {
        long[] primos;

        public void Primos(long ini, long fim)
        {
            long total = fim / 2;
            if (total < 10) total = 10;
            long x = ini;
            long i = 0;
            primos = new long[total];

            while (x <= fim)
            {
                if ((x == 1) ||
                    (x == 2) ||
                    (x == 3))
                {
                    primos[i++] = x++;
                    continue;
                }
                else
                {
                    int y;
                    for (y = 2; (y * y) < x; y++)
                    {
                        if (x % y == 0) break;
                    }
                    if ((y * y) > x) primos[i++] = x;
                    x++;
                }
            }
        }

        public void Imprime()
        {
            if (primos == null) return;

            foreach (long p in primos)
            {
                if (p == 0) break;
                Console.Write($"{p} ");
            }
        }
    }
}
