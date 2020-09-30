using System;

namespace exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos integrais assinados:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
        }
    }
}
