using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class SomaInt1to20
    {
        public void Soma1to20()
        {
            Console.WriteLine("Soma1to20()"); 
            Console.WriteLine("Construa um loop que efetue a Soma dos inteiros de 1 a 20");
            Console.WriteLine();

            int soma = 0;
            for (int i = 1; i <= 20; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos inteiros de 1 a 20 é {soma}");
        }
    }
}
