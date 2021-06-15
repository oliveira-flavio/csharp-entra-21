using System;

namespace Lista2Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                int b = numero;
                Console.WriteLine($"Variável B: {b}");
            }
            else
            {
                int a = numero;
                Console.WriteLine($"Variável A: {a}");
            }
            Console.ReadLine();
        }
    }
}
