using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestes1
{
    class Pausa
    {
        public static void PrecionarUmaTecla(String msg)
        {
            Console.WriteLine();
            Console.WriteLine($"pressione <Qualquer Tecla> {msg}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
