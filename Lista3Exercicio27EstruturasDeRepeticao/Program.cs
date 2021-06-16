using System;

namespace Lista3Exercicio27EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número:");
            int numero = int.Parse(Console.ReadLine());

            var fatorial = numero;

            for (int i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");
                fatorial = fatorial * i;

                Console.WriteLine($" i = {i}");
                Console.WriteLine($"Fatorial = {fatorial}");
                Console.WriteLine("  ");
            }

            Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
            Console.ReadLine();
        }
    }
}
