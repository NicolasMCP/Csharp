/*
 * Autor: Nicolas Ramos
 * 
 * Ambiente: Visual Studio 2019 C#
 * 
 * Licença: GNU GPL 3
 * 
 */
using System;

namespace VariaveisECarateristicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de Variáveis do C# para números SEM virgula. Ou seja, inteiros.");
            Console.WriteLine();

            ulong maxUlong = ulong.MaxValue;
            long maxLong = long.MaxValue;
            uint maxUint = uint.MaxValue;
            int maxInt = int.MaxValue;
            ushort maxUshort = ushort.MaxValue;
            short maxShort = short.MaxValue;
            byte maxByte = byte.MaxValue;
            sbyte maxSbyte = sbyte.MaxValue;

            Console.WriteLine($"Tipo       Máximo Valor Positivo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"sbyte  {maxSbyte}");
            Console.WriteLine($"byte   {maxByte}");
            Console.WriteLine($"short  {maxShort}");
            Console.WriteLine($"ushort {maxUshort}");
            Console.WriteLine($"int    {maxInt}");
            Console.WriteLine($"uint   {maxUint}");
            Console.WriteLine($"long   {maxLong}");
            Console.WriteLine($"ulong  {maxUlong}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Tipo       Máximo Valor Negativo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"sbyte  {sbyte.MinValue}");
            Console.WriteLine($"byte   {byte.MinValue}");
            Console.WriteLine($"short  {short.MinValue}");
            Console.WriteLine($"ushort {ushort.MinValue}");
            Console.WriteLine($"int    {int.MinValue}");
            Console.WriteLine($"uint   {uint.MinValue}");
            Console.WriteLine($"long   {long.MinValue}");
            Console.WriteLine($"ulong  {ulong.MinValue}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Voçe pode usar 'MaxValue' ou 'MinValue' de cada tipo.");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Números de ponto flutuante.");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"float\n    " +
                $"Mínimo: {float.MinValue}\n    " +
                $"Máximo: {float.MaxValue}\n    " +
                $"Negativo Infinito: {float.NegativeInfinity}\n    " +
                $"Positivo Infinito: {float.PositiveInfinity}\n    " +
                $"Não é um Numero: {float.NaN}\n");
            Console.WriteLine("----------------------------------");

            Console.WriteLine($"double\n    " +
                $"Mínimo: {double.MinValue}\n    " +
                $"Máximo: {double.MaxValue}\n    " +
                $"Negativo Infinito: {double.NegativeInfinity}\n    " +
                $"Positivo Infinito: {double.PositiveInfinity}\n    " +
                $"Não é um Numero: {double.NaN}\n");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("\nCasting (conversão) de double para int\n");

            double varDouble = 111.99;
            int varInt = (int)varDouble;

            Console.WriteLine($"double Conteúdo do Número Real: {varDouble}");
            Console.WriteLine($"int (recebendo o valor acima) : {varInt}\n");


            Console.WriteLine("\nPressione uma tecla para concluir...");
            Console.ReadKey();
        }
    }
}
