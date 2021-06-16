using System;

namespace Lista3Exercicio31SomaParImparIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero= 0, numeroPar = 0, numeroImpar = 0;

            do
            {
                Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"Este número é par");
                    numeroPar += numero;
                }
                else
                {
                    Console.WriteLine($"Este número é impar");
                    numeroImpar += numero;
                }

            } while (numero > -1);
            Console.WriteLine(" ");
            Console.WriteLine($"A soma de par é {numeroPar}");
            Console.WriteLine(" ");
            Console.WriteLine($"A soma de impar é {numeroImpar}");
        }
    }
}
